using S7.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KukaMovementEditor
{
    internal class SPSClaw
    {
        private static bool _Online;

        static SPSClaw()
        {
            //Set default value of online to false
            _Online = false;
        }

        public static void SetOnlineMode(bool newState)
        {
            _Online = newState;
        }

        public static void ReceiveCommand(string command)
        {
            if (_Online == true)
            {
                if (command == "~ClawOpen")
                {
                    GreiferAuf();
                }
                if (command == "~ClawClose")
                {
                    GreiferZu();
                }
            }
            if (_Online == false)
            {
                if (command == "~ClawOpen")
                {
                    MessageBox.Show("virtual ClawOpen");
                }
                if (command == "~ClawClose")
                {
                    MessageBox.Show("virtual ClawClose");
                }
            }
        }

        private static void GreiferZu()
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

        private static void GreiferAuf()
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
}
