using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KukaMovementEditor
{
    public partial class Form1 : Form
    {
        private KukaRoboter _KR;
        private Timer _TimerPositionUpdate;

        public Form1()
        {
            InitializeComponent();
            _KR = new KukaRoboter();

            //Create the timer
            _TimerPositionUpdate = new Timer();
            _TimerPositionUpdate.Interval = 1000;
            _TimerPositionUpdate.Tick += PositionUpdate;
            _TimerPositionUpdate.Start();
        }

        private void PositionUpdate(object sender, EventArgs e)
        {
            textBox_Joints.Text = _KR.GetJointsPosition();
            textBox_Positions.Text = _KR.GetPositionCordinates();
        }

        private void IncrementalMoveRadioCheckedChange(object sender, EventArgs e)
        {
            //Get the radio button
            RadioButton radio_sender = (RadioButton)sender;
            
            //If the button is not checked return it
            if (!radio_sender.Checked) { return; }

            //Change the buttons depending on the buttons names
            if (radio_sender.Text == "Reference") { SetIncrementalButtonsCartesian(); }
            if (radio_sender.Text == "Tool") { SetIncrementalButtonsCartesian(); }
            if (radio_sender.Text == "Joint Move") { SetIncrementalButtonsJoints(); }
        }

        private void SetIncrementalButtonsCartesian()
        {
            //Get the movement unit 
            //string unit = "Step (mm):";

            //Display text for positive Cartesian movements:
            button_Xplus.Text = "+Tx";
            button_Yplus.Text = "+Ty";
            button_Zplus.Text = "+Tz";
            button_rXplus.Text = "+Rx";
            button_rYplus.Text = "+Ry";
            button_rZplus.Text = "+Rz";

            //Display text for negative Cartesian movements:
            button_Xminus.Text = "-Tx";
            button_Yminus.Text = "-Ty";
            button_Zminus.Text = "-Tz";
            button_rXminus.Text = "-Rx";
            button_rYminus.Text = "-Ry";
            button_rZminus.Text = "-Rz";
        }

        private void SetIncrementalButtonsJoints()
        {
            //Get the movement unit 
            //string unit = "Step (deg):";

            //Display text for positive Cartesian movements:
            button_Xplus.Text = "+J1";
            button_Yplus.Text = "+J2";
            button_Zplus.Text = "+J3";
            button_rXplus.Text = "+J4";
            button_rYplus.Text = "+J5";
            button_rZplus.Text = "+J6";

            //Display text for negative Cartesian movements:
            button_Xminus.Text = "-J1";
            button_Yminus.Text = "-J2";
            button_Zminus.Text = "-J3";
            button_rXminus.Text = "-J4";
            button_rYminus.Text = "-J5";
            button_rZminus.Text = "-J6";
        }

        private void IncrementalMovementClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _KR.Incremental_Move(btn.Text, Int32.Parse(textBox_DistanceStep.Text), radioButton_Reference, radioButton_Tool, radioButton_JointMove);
        }

        private void btn_RobotSimulation_Click(object sender, EventArgs e)
        {
            _KR.SwitchSimulationMode();
            SPSClaw.SetOnlineMode(false);
        }

        private void btn_RobotRealRobot_Click(object sender, EventArgs e)
        {
            _KR.SwitchRealMode();
            SPSClaw.SetOnlineMode(true);
            SPSClaw.ReceiveCommand("~ClawClose");
            SPSClaw.ReceiveCommand("~ClawOpen");
        }

        private void button_GripperOpen_Click(object sender, EventArgs e)
        {
            SPSClaw.ReceiveCommand("~ClawOpen");
        }

        private void button_GripperClose_Click(object sender, EventArgs e)
        {
            SPSClaw.ReceiveCommand("~ClawClose");
        }

        private void button_New_Click(object sender, EventArgs e)
        {
            listBox_NameList.Items.Add(textBox_Name.Text);
            listBox_JointsList.Items.Add(textBox_Joints.Text);
            listBox_PositionList.Items.Add(textBox_Positions.Text);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox_NameList.SelectedIndex;
            
            //When there is an item selected
            if(selectedIndex != -1)
            {
                listBox_NameList.Items.RemoveAt(selectedIndex);
                listBox_JointsList.Items.RemoveAt(selectedIndex);
                listBox_PositionList.Items.RemoveAt(selectedIndex);
            }
        }

        private void button_Select_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox_NameList.SelectedIndex;

            //When there is an item selected
            if (selectedIndex != -1)
            {
                if(listBox_PositionList.Items[selectedIndex].ToString().Contains('~'))
                {
                    SPSClaw.ReceiveCommand(listBox_PositionList.Items[selectedIndex].ToString());
                }
                else
                {
                    textBox_Name.Text = listBox_NameList.Items[selectedIndex].ToString();
                    _KR.MoveToPose(listBox_PositionList.Items[selectedIndex].ToString());
                }
            }
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox_NameList.SelectedIndex;

            //When there is an item selected
            if (selectedIndex != -1)
            {
                listBox_NameList.Items.Insert(selectedIndex, textBox_Name.Text);
                listBox_JointsList.Items.Insert(selectedIndex, textBox_Joints.Text);
                listBox_PositionList.Items.Insert(selectedIndex, textBox_Positions.Text);
            }
        }

        private void button_LoadSaveTxT_Click(object sender, EventArgs e)
        {
            //Load all positions into an list
            List<string> positions = new List<string>();
            for(int i = 0; i < listBox_NameList.Items.Count; i++)
            {
                positions.Add(listBox_NameList.Items[i].ToString() + "#" + listBox_JointsList.Items[i].ToString() + "#" + listBox_PositionList.Items[i].ToString());
            }

            //Write the positions to the file
            TextWriter tw = new StreamWriter("MovementList.kmf");

            foreach (String s in positions)
                tw.WriteLine(s);

            tw.Close();
        }

        private void button_LoadTxT_Click(object sender, EventArgs e)
        {
            //Clear textboxes
            listBox_NameList.Items.Clear();
            listBox_JointsList.Items.Clear();
            listBox_PositionList.Items.Clear();

            //Add the read items
            string[] positions = File.ReadAllLines("MovementList.kmf");
            for(int i = 0; i < positions.Length; i++)
            {
                string[] split = positions[i].Split('#');
                listBox_NameList.Items.Add(split[0]);
                listBox_JointsList.Items.Add(split[1]);
                listBox_PositionList.Items.Add(split[2]);
            }
        }

        private void button_Run_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listBox_JointsList.Items.Count; i++)
            {
                if (listBox_JointsList.Items[i].ToString().Contains('~'))
                {
                    SPSClaw.ReceiveCommand(listBox_JointsList.Items[i].ToString());
                }
                else
                {
                    _KR.MoveToJoints(listBox_JointsList.Items[i].ToString());
                }
            }
        }

        private void button_PositionMove_Click(object sender, EventArgs e)
        {
            _KR.MoveToPose(textBox_MoveToPosition.Text);
        }

        private void button_JointsMove_Click(object sender, EventArgs e)
        {
            _KR.Move(textBox_MoveToJoints.Text);
        }

        private void button_InsertGripperOpen_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox_NameList.SelectedIndex;

            //When there is an item selected
            if (selectedIndex != -1)
            {
                listBox_NameList.Items.Insert(selectedIndex, "Gripper Open");
                listBox_JointsList.Items.Insert(selectedIndex, "~ClawOpen");
                listBox_PositionList.Items.Insert(selectedIndex, "~ClawOpen");
            }
        }

        private void button_InsertGripperClose_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox_NameList.SelectedIndex;

            //When there is an item selected
            if (selectedIndex != -1)
            {
                listBox_NameList.Items.Insert(selectedIndex, "Gripper Close");
                listBox_JointsList.Items.Insert(selectedIndex, "~ClawClose");
                listBox_PositionList.Items.Insert(selectedIndex, "~ClawClose");
            }
        }
    }
}
