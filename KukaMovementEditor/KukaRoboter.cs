using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;

namespace KukaMovementEditor
{
    internal class KukaRoboter
    {
        //RoboDK Variables
        private RoboDK RDK = null;
        private RoboDK.Item ROBOT = null;
        private const bool MOVE_BLOCKING = false;
        //string objekt = "";
        private static double[] jointsNEU;

        //Constructor
        public KukaRoboter()
        {

            //Gets the Robot
            if (!Check_RDK())
            {
                RDK = new RoboDK();

                // Check if RoboDK started properly
                if (Check_RDK())
                {
                    SelectRobot();
                }

                // set default movement on the simulator only:
                SwitchSimulationMode();

                // display RoboDK by default:
                // Not working: rad_RoboDK_show.PerformClick();

                // Set incremental moves in cartesian space with respect to the robot reference frame
                // Only buttons: rad_Move_wrt_Reference.PerformClick();

                //numStep.Value = 10; // set movement steps of 50 mm or 50 deg by default
            }
        }

        //Methods
        public bool Check_RDK()
        {
            // check if the RDK object has been initialised:
            if (RDK == null)
            {
                return false;
            }

            // Check if the RDK API is connected
            if (!RDK.Connected())
            {
                // Attempt to connect to the RDK API
                if (!RDK.Connect())
                {
                    return false;
                }
            }
            return true;
        }

        public bool Check_ROBOT(bool ignore_busy_status = false)
        {
            if (!Check_RDK())
            {
                return false;
            }
            if (ROBOT == null || !ROBOT.Valid())
            {
                return false;
            }
            try
            {
            }
            catch (RoboDK.RDKException rdkex)
            {
                Console.WriteLine(rdkex.ToString());
                return false;
            }

            // Safe check: If we are doing non blocking movements, we can check if the robot is doing other movements with the Busy command
            if (!MOVE_BLOCKING && (!ignore_busy_status && ROBOT.Busy()))
            {
                return false;
            }
            return true;
        }

        public void SelectRobot()
        {
            if (!Check_RDK())
            {
                ROBOT = null;
                return;
            }
            ROBOT = RDK.ItemUserPick("Select a robot", RoboDK.ITEM_TYPE_ROBOT);
            if (ROBOT.Valid())
            {
                ROBOT.NewLink();
            }
        }

        public void SwitchSimulationMode()
        {
            // Check that there is a link with RoboDK
            if (!Check_ROBOT()) { return; }

            // Important: stop any previous program generation (if we selected offline programming mode)
            RDK.Finish();

            // Set to simulation mode
            RDK.setRunMode(RoboDK.RUNMODE_SIMULATE);
        }

        public void SwitchRealMode()
        {
            if (!Check_ROBOT()) { return; }

            // Important: stop any previous program generation (if we selected offline programming mode)
            RDK.Finish();

            // Connect to real robot
            if (ROBOT.Connect())
            {
                // Set to Run on Robot robot mode:
                RDK.setRunMode(RoboDK.RUNMODE_RUN_ROBOT);
            }
            else
            {
                Console.WriteLine("Can't connect to the robot. Check connection and parameters.");
                SwitchSimulationMode();
            }
        }

        public void Move(string postions)
        {
            if (!Check_ROBOT()) { Console.WriteLine("Keine Verbindung zum Roboter"); return; }

            jointsNEU = new double[6];
            jointsNEU = String_2_Values_NEU(postions);

            // make sure RDK is running and we have a valid input
            if (!Check_ROBOT() || jointsNEU == null) { return; }

            try
            {
                ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
                ROBOT.WaitMove();
            }
            catch (RoboDK.RDKException rdkex)
            {
                Console.WriteLine("Problems moving the robot: " + rdkex.Message);
            }
        }

        public double[] String_2_Values_NEU(string strvalues)
        {
            double[] dvalues = null;
            try
            {
                dvalues = Array.ConvertAll(strvalues.Split(';'), Double.Parse);
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Invalid input: " + strvalues);
            }
            return dvalues;
        }

        public void Incremental_Move(string button_name, int distance, RadioButton RB1, RadioButton RB2, RadioButton RB3)
        {
            if (!Check_ROBOT()) { return; }

            if (button_name.Length < 3)
            {
                return;
            }

            // get the the sense of motion the first character as '+' or '-'
            double move_step = 0.0;
            if (button_name[0] == '+')
            {
                move_step = +Convert.ToDouble(distance);
            }
            else if (button_name[0] == '-')
            {
                move_step = -Convert.ToDouble(distance);
            }
            else
            {
                return;
            }

            //////////////////////////////////////////////
            //////// if we are moving in the joint space:
            if (RB3.Checked)
            {
                double[] joints = ROBOT.Joints();

                // get the moving axis (1, 2, 3, 4, 5 or 6)
                int joint_id = Convert.ToInt32(button_name[2].ToString()) - 1; // important, double array starts at 0

                joints[joint_id] = joints[joint_id] + move_step;

                try
                {
                    ROBOT.MoveJ(joints, MOVE_BLOCKING);
                    //ROBOT.MoveL(joints, MOVE_BLOCKING);
                }
                catch (RoboDK.RDKException rdkex)
                {
                    string error = rdkex.Message;
                    //MessageBox.Show("The robot can't move to " + new_pose.ToString());
                }
            }
            else
            {
                //////////////////////////////////////////////
                //////// if we are moving in the cartesian space
                // Button name examples: +Tx, -Tz, +Rx, +Ry, +Rz

                int move_id = 0;

                string[] move_types = new string[6] { "Tx", "Ty", "Tz", "Rx", "Ry", "Rz" };

                for (int i = 0; i < 6; i++)
                {
                    if (button_name.EndsWith(move_types[i]))
                    {
                        move_id = i;
                        break;
                    }
                }
                double[] move_xyzwpr = new double[6] { 0, 0, 0, 0, 0, 0 };
                move_xyzwpr[move_id] = move_step;
                Mat movement_pose = Mat.FromTxyzRxyz(move_xyzwpr);

                // the the current position of the robot (as a 4x4 matrix)
                Mat robot_pose = ROBOT.Pose();

                // Calculate the new position of the robot
                Mat new_robot_pose;
                bool is_TCP_relative_move = RB2.Checked;
                if (is_TCP_relative_move)
                {
                    // if the movement is relative to the TCP we must POST MULTIPLY the movement
                    new_robot_pose = robot_pose * movement_pose;
                }
                else
                {
                    // if the movement is relative to the reference frame we must PRE MULTIPLY the XYZ translation:
                    // new_robot_pose = movement_pose * robot_pose;
                    // Note: Rotation applies from the robot axes.

                    Mat transformation_axes = new Mat(robot_pose);
                    transformation_axes.setPos(0, 0, 0);
                    Mat movement_pose_aligned = transformation_axes.inv() * movement_pose * transformation_axes;
                    new_robot_pose = robot_pose * movement_pose_aligned;
                }

                // Then, we can do the movement:
                try
                {
                    ROBOT.MoveJ(new_robot_pose, MOVE_BLOCKING);
                }
                catch (RoboDK.RDKException rdkex)
                {
                    string error = rdkex.Message;
                    //MessageBox.Show("The robot can't move to " + new_pose.ToString());
                }


                // Some tips:
                // retrieve the current pose of the robot: the active TCP with respect to the current reference frame
                // Tip 1: use
                // ROBOT.setFrame()
                // to set a reference frame (object link or pose)
                //
                // Tip 2: use
                // ROBOT.setTool()
                // to set a tool frame (object link or pose)
                //
                // Tip 3: use
                // ROBOT.MoveL_Collision(j1, new_move)
                // to test if a movement is feasible by the robot before doing the movement
                //
            }
        }

        public void MoveToJoints(string postion_to_move_to)
        {
            //Convert string into joints
            double[] joints = String_2_Values_NEU(postion_to_move_to);

            //Make sure RoboDK Gui is running
            if (!Check_ROBOT() || joints == null) { return; }

            try
            {
                ROBOT.MoveJ(joints, MOVE_BLOCKING);
                ROBOT.WaitMove();
            }
            catch (RoboDK.RDKException rdkex)
            {
                Console.WriteLine("Problems moving the robot: " + rdkex.Message);
            }
        }

        public void MoveToPose(string position_to_move_to)
        {
            //Convert the values to pos
            double[] xyzwpr = String_2_Values_NEU(position_to_move_to);

            //Make sure RoboDK is running
            if (!Check_ROBOT() || xyzwpr == null) { return; }

            //Move to that position
            Mat pose = Mat.FromTxyzRxyz(xyzwpr);
            try
            {
                ROBOT.MoveJ(pose, MOVE_BLOCKING);
            }
            catch (RoboDK.RDKException rdkex)
            {
                Console.WriteLine("Problems moving the robot: " + rdkex.Message);
            }
        }

        public string GetJointsPosition()
        {
            if (!Check_ROBOT(true)) { return "Error!"; }
            double[] joints = ROBOT.Joints();
            string strjoints = Values_2_String(joints);
            return strjoints;
        }

        public string GetPositionCordinates()
        {
            if (!Check_ROBOT(true)) { return "Error!"; }
            Mat pose = ROBOT.Pose();
            double[] xyzwpr = pose.ToTxyzRxyz();
            string strpose = Values_2_String(xyzwpr);
            return strpose;
        }

        public string Values_2_String(double[] dvalues)
        {
            if (dvalues == null || dvalues.Length < 1)
            {
                return "Invalid values";
            }

            string strvalues = dvalues[0].ToString();
            for (int i = 1; i < dvalues.Length; i++)
            {
                strvalues += " ; " + dvalues[i].ToString();
            }

            return strvalues;
        }

        public void HomeRobot()
        {
            if (!Check_ROBOT()) { Console.WriteLine("Keine Verbindung zum Roboter"); return; }

            double[] joints_home = ROBOT.JointsHome();
            ROBOT.MoveJ(joints_home);
        }

        private void MoveToStep(string Cordinates)
        {
            if (!Check_ROBOT()) { Console.WriteLine("No connection to the robot..."); return; }

            jointsNEU = new double[6];

            //Import Joint values from step 1
            jointsNEU = String_2_Values_NEU(Cordinates);

            //Make sure that RoboDK is running
            if (!Check_ROBOT() || jointsNEU == null) { return; }

            try
            {
                //Try to move the robot
                ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
                ROBOT.WaitMove();
            }
            catch (RoboDK.RDKException rdkex)
            {
                Console.WriteLine("Problems moving the robot: " + rdkex.Message);
            }
        }
    }
}
