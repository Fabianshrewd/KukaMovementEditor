using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;

namespace Weasel_Server_2.Weasel_Server1_Logic.RoboDKLibraries
{
    internal class KukaRoboter
    {
        //RoboDK Variables
        private RoboDK RDK = null;
        private RoboDK.Item ROBOT = null;
        private const bool MOVE_BLOCKING = false;
        //string objekt = "";
        private static double[] jointsNEU;
        private bool _AppOnline;

        //Constructor
        public KukaRoboter(bool AppOnline1)
        {
            //Set if the Kuka is really online
            _AppOnline = AppOnline1;

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

        //Encapsulation
        public bool AppOnline
        {
            get { return this._AppOnline; }
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

        public void PickUp()
        {
            //To test the SPS
            GreiferZu();
            GreiferAuf();

            // Home
            jointsNEU = ROBOT.JointsHome();
            ROBOT.MoveJ(jointsNEU);
            ROBOT.WaitMove();

            // Step 1
            jointsNEU = String_2_Values_NEU("84,9 ; -57,14 ; 78,47 ; -18,18 ; 43,62 ; -8,54");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();

            // Step 2
            jointsNEU = String_2_Values_NEU("83,53 ; -29,04 ; 78,49 ; -41,31 ; 18,07 ; 16,71");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();

            // Step 3
            jointsNEU = String_2_Values_NEU("85,15 ; -32,34 ; 89,08 ; -62,02 ; 14,23 ; 39,59");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();

            // Step 4
            jointsNEU = String_2_Values_NEU("85,32 ; -30,44 ; 84,34 ; -53,15 ; 15,84 ; 30,54");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();

            // Step 5
            jointsNEU = String_2_Values_NEU("85,32 ; -51,53 ; 81,34 ; -21,95 ; 35,77 ; -3,43");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();

            // Step 6
            jointsNEU = String_2_Values_NEU("87,48 ; -50,58 ; 96,41 ; 4,33 ; 44,71 ; 70,63");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();
            GreiferAuf();

            // Step 7
            jointsNEU = String_2_Values_NEU("88,15 ; -44 ; 99,12 ; -0,67 ; 35,19 ; 75,15");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();

            // Step 8
            jointsNEU = String_2_Values_NEU("88,22 ; -33,98 ; 97,68 ; -0,86 ; 26,61 ; 75,7");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();
            GreiferZu();

            // Step 9
            jointsNEU = String_2_Values_NEU("87,8 ; -63,68 ; 93,39 ; 0,8 ; 59,55 ; 73,3");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();

            // Step 10
            jointsNEU = String_2_Values_NEU("30,77 ; -69,06 ; 101,41 ; 1,17 ; 57,84 ; 16,04");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();

            // Step 11
            jointsNEU = String_2_Values_NEU("17,07 ; -16,59 ; 36,76 ; 0,58 ; 68,98 ; 83,75");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();

            // Step 12
            jointsNEU = String_2_Values_NEU("17,07 ; -11 ; 35,6 ; 0,6 ; 64,56 ; 83,7");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();
            GreiferAuf();

            // Step 13
            jointsNEU = String_2_Values_NEU("17,07 ; -20,82 ; 34,78 ; 0,56 ; 75,2 ; 83,81");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();

            // Home
            jointsNEU = ROBOT.JointsHome();
            ROBOT.MoveJ(jointsNEU);
            ROBOT.WaitMove();
        }

        public void PickUp2()
        {
            //To test the SPS
            GreiferZu();
            GreiferAuf();

            // Step 1
            jointsNEU = String_2_Values_NEU("85,6719284000001 ; -40,1077384999999 ; 49,0251616999997 ; -15,5197802 ; 55,7212410000003 ; -12,3155000000001");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();

            // Step 2
            jointsNEU = String_2_Values_NEU("86,3778305 ; -25,0595893999976 ; 27,209829299995 ; -25,5521506999993 ; 56,006900000002 ; -1,48121000000116");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();

            // Step 3
            jointsNEU = String_2_Values_NEU("86,5107727 ; -10,1597794999997 ; 20,5891303999996 ; -25,7888602999999 ; 17,6271 ; -2,14715000000013");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();

            // Step 4
            jointsNEU = String_2_Values_NEU("86,5107727 ; -10,159779499998 ; 29,5891303999958 ; -25,7888602999983 ; 33,6271000000024 ; -2,14715000000196");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();

            // Step 5
            jointsNEU = String_2_Values_NEU("86,8824768 ; -9,42768000000065 ; 28,0469398000014 ; -30,6476000000004 ; 37,1969108999996 ; 6,35593000000053");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();

            // Step 6
            jointsNEU = String_2_Values_NEU("86,8824768 ; -3,14254999999802 ; 24,3774394999958 ; -32,5280608999984 ; 34,9684000000017 ; 8,68218999999816");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();

            // Step 7
            jointsNEU = String_2_Values_NEU("86,8824768 ; -3,14254999999802 ; 24,3774394999958 ; -32,5280608999985 ; 34,9684000000017 ; 8,68218999999816");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();

            // Step 8
            jointsNEU = String_2_Values_NEU("86,7184601 ; -12,8612498999997 ; 45,4505195999993 ; -44,4939803999989 ; 25,9330406000005 ; 22,4167594999987");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();

            // Step 9
            jointsNEU = String_2_Values_NEU("86,7184601 ; -12,8612498999997 ; 45,4505195999993 ; -44,4939803999989 ; 25,9330406000005 ; 22,4167594999987");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();

            // Step 10
            jointsNEU = String_2_Values_NEU("86,9105606000001 ; -10,7146300999982 ; 22,9347999999963 ; -26,9890403999991 ; 42,8207397000014 ; 1,59614999999895");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();

            // Step 11
            jointsNEU = String_2_Values_NEU("83,9533463 ; -22,2237796999996 ; 42,0987395999992 ; 3,10368999999998 ; 71,7927000000005 ; 72,2094116000004");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();

            // Step 12
            jointsNEU = String_2_Values_NEU("83,9533463 ; -10,5088195999996 ; 40,1772999999993 ; 3,33900000000005 ; 62,0144999999999 ; 71,6118164000004");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();
            GreiferZu();

            // Step 13
            jointsNEU = String_2_Values_NEU("83,9533463 ; -18,1570205999999 ; 42,7372817999998 ; 3,20079999999998 ; 67,0945282000002 ; 71,9331206999995");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();
        }

        public void PutDown()
        {
            //To test the SPS
            GreiferZu();
            GreiferAuf();

            // Home
            jointsNEU = ROBOT.JointsHome();
            ROBOT.MoveJ(jointsNEU);
            ROBOT.WaitMove();

            // Step 13
            jointsNEU = String_2_Values_NEU("17,07 ; -20,82 ; 34,78 ; 0,56 ; 75,2 ; 83,81");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();

            // Step 12
            jointsNEU = String_2_Values_NEU("17,07 ; -11 ; 35,6 ; 0,6 ; 64,56 ; 83,7");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();
            GreiferZu();

            // Step 11
            jointsNEU = String_2_Values_NEU("17,07 ; -16,59 ; 36,76 ; 0,58 ; 68,98 ; 83,75");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();

            // Step 10
            jointsNEU = String_2_Values_NEU("30,77 ; -69,06 ; 101,41 ; 1,17 ; 57,84 ; 16,04");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();

            //Step 10.5
            jointsNEU = String_2_Values_NEU("87,48 ; -50,58 ; 96,41; 4,33 ; 44,71 ; 70,63");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();

            // Step 8
            jointsNEU = String_2_Values_NEU("88,22 ; -33,98 ; 97,68 ; -0,86 ; 26,61 ; 75,7");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();
            GreiferAuf();

            // Step 7
            jointsNEU = String_2_Values_NEU("88,15 ; -44 ; 99,12 ; -0,67 ; 35,19 ; 75,15");
            ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            ROBOT.WaitMove();

            //// Step 6
            //jointsNEU = String_2_Values_NEU("87,48 ; -50,58 ; 96,41 ; 4,33 ; 44,71 ; 70,63");
            //ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            //ROBOT.WaitMove();

            //// Step 5
            //jointsNEU = String_2_Values_NEU("85,32 ; -51,53 ; 81,34 ; -21,95 ; 35,77 ; -3,43");
            //ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            //ROBOT.WaitMove();

            //// Step 4
            //jointsNEU = String_2_Values_NEU("85,32 ; -30,44 ; 84,34 ; -53,15 ; 15,84 ; 30,54");
            //ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            //ROBOT.WaitMove();
            //GreiferZu();

            //// Step 3
            //jointsNEU = String_2_Values_NEU("85,15 ; -32,34 ; 89,08 ; -62,02 ; 14,23 ; 39,59");
            //ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            //ROBOT.WaitMove();

            //// Step 2
            //jointsNEU = String_2_Values_NEU("83,53 ; -29,04 ; 78,49 ; -41,31 ; 18,07 ; 16,71");
            //ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            //ROBOT.WaitMove();

            //// Step 1
            //jointsNEU = String_2_Values_NEU("84,9 ; -57,14 ; 78,47 ; -18,18 ; 43,62 ; -8,54");
            //ROBOT.MoveJ(jointsNEU, MOVE_BLOCKING);
            //ROBOT.WaitMove();

            // Home
            jointsNEU = ROBOT.JointsHome();
            ROBOT.MoveJ(jointsNEU);
            ROBOT.WaitMove();
        }

        public void Step1()
        {
            MoveToStep("84,9 ; -57,14 ; 78,47 ; -18,18 ; 43,62 ; -8,54");
        }

        public void Step2()
        {
            MoveToStep("83,53 ; -29,04 ; 78,49 ; -41,31 ; 18,07 ; 16,71");
        }

        public void Step3()
        {
            MoveToStep("85,15 ; -32,34 ; 89,08 ; -62,02 ; 14,23 ; 39,59");
        }

        public void Step4()
        {
            MoveToStep("85,32 ; -30,44 ; 84,34 ; -53,15 ; 15,84 ; 30,54");
        }

        public void Step5()
        {
            MoveToStep("85,32 ; -51,53 ; 81,34 ; -21,95 ; 35,77 ; -3,43");
        }

        public void Step6()
        {
            MoveToStep("87,48 ; -50,58 ; 96,41 ; 4,33 ; 44,71 ; 70,63");
        }

        public void Step7()
        {
            MoveToStep("88,15 ; -44 ; 99,12 ; -0,67 ; 35,19 ; 75,15");
        }

        public void Step8()
        {
            MoveToStep("88,22 ; -33,98 ; 97,68 ; -0,86 ; 26,61 ; 75,7");
        }

        public void Step9()
        {
            MoveToStep("87,8 ; -63,68 ; 93,39 ; 0,8 ; 59,55 ; 73,3");
        }

        public void Step10()
        {
            MoveToStep("112,01 ; -31,01 ; 54,46 ; 0,35 ; 66,08 ; 97,77");
        }

        public void Step11()
        {
            MoveToStep("112,90 ; -17,38 ; 37,06 ; 0,33 ; 71,35 ; 98,69");
        }

        public void Step12()
        {
            MoveToStep("112,93 ; -11,77 ; 36,77 ; 0,34 ; 66,04 ; 98,68");
        }

        public void Step13()
        {
            MoveToStep("112,88 ; -20,02 ; 35,46 ; 0,32 ; 75,59 ; 98,70");
        }

        public void GreiferZu()
        {
            int mode = RDK.RunMode();
            if (_AppOnline == true && mode == 6)
            {
                using (Plc plc = new Plc(CpuType.S71200, "10.0.9.106", 0, 1))
                {
                    plc.Open();
                    System.Threading.Thread.Sleep(1000);
                    plc.Write("M12.0", 0);
                    plc.Write("M12.1", 1);
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }

        public void GreiferAuf()
        {
            int mode = RDK.RunMode();
            if (_AppOnline == true && mode == 6)
            {
                using (Plc plc = new Plc(CpuType.S71200, "10.0.9.106", 0, 1))
                {
                    plc.Open();
                    System.Threading.Thread.Sleep(1000);
                    plc.Write("M12.0", 1);
                    plc.Write("M12.1", 0);
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }

        public void Incremental_Move(string button_name)
        {
            if (!Check_ROBOT()) { return; }

            Console.WriteLine("Button selected: " + button_name);

            if (button_name.Length < 3)
            {
                Console.WriteLine("Internal problem! Button name should be like +J1, -Tx, +Rz or similar");
                return;
            }

            double move_step = 0.0;
            if (button_name[0] == '+')
            {
                move_step = +Convert.ToDouble(10);
            }
            else if (button_name[0] == '-')
            {
                move_step = -Convert.ToDouble(10);
            }
            else
            {
                Console.WriteLine("Internal problem! Unexpected button name");
                return;
            }

            if (1 != 1)
            {
                //This code is temporary and only required for other features
                //This code is temporary and only required for other features
                //This code is temporary and only required for other features
                //double[] joints = ROBOT.Joints();

                //int joint_id = Convert.ToInt32(button_name[2].ToString()) - 1;

                //joints[joint_id] = joints[joint_id] + move_step;

                //try
                //{
                //    ROBOT.MoveJ(joints, MOVE_BLOCKING);
                //}
                //catch (RoboDK.RDKException rdkex)
                //{
                //    Console.WriteLine("The robot can't move to the target joints: " + rdkex.Message);
                //}
            }
            else
            {
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

                Mat robot_pose = ROBOT.Pose();

                Mat new_robot_pose;
                bool is_TCP_relative_move = false;
                if (is_TCP_relative_move)
                {
                    new_robot_pose = robot_pose * movement_pose;
                }
                else
                {
                    Mat transformation_axes = new Mat(robot_pose);
                    transformation_axes.setPos(0, 0, 0);
                    Mat movement_pose_aligned = transformation_axes.inv() * movement_pose * transformation_axes;
                    new_robot_pose = robot_pose * movement_pose_aligned;
                }

                try
                {
                    ROBOT.MoveJ(new_robot_pose, MOVE_BLOCKING);
                }
                catch (RoboDK.RDKException rdkex)
                {
                    Console.WriteLine("The robot can't move to " + new_robot_pose.ToString() + " " + rdkex.ToString());
                }
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
