using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JLEDC1_App
{

    public partial class ControlForm: Form
    {
        LEDCommander Ledc;

        public ControlForm(LEDCommander Ledc)
        {
            this.Ledc = Ledc;
            InitializeComponent();
        }
        private void redBar_Scroll(object sender, EventArgs e)
        {
            Ledc.SetRed((byte) redBar.Value);
        }
        private void greenBar_Scroll(object sender, EventArgs e)
        {
            Ledc.SetGreen((byte) greenBar.Value);

        }
        private void blueBar_Scroll(object sender, EventArgs e)
        {
            Ledc.SetBlue((byte) blueBar.Value);

        }
        private void ControlForm_Load(object sender, EventArgs e)
        {

        }

        private void chooseNewConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetupForm setupForm = new SetupForm();
            setupForm.Show();
            this.Close();
        }
    }
}
