using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KukaMovementEditor
{
    public partial class WarningDialogue : Form
    {
        public WarningDialogue()
        {
            InitializeComponent();

            //Initialise the default Dialog Result with Cancel
            this.DialogResult = DialogResult.Cancel;
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
