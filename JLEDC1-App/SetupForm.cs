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
    public partial class SetupForm : Form
    {
        LEDCommander Ledc;

        public SetupForm()
        {
            Ledc = new LEDCommander();
            InitializeComponent();

            foreach (String com in LEDCommander.GetComs()) {
                listBox1.Items.Add(com);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String com = listBox1.SelectedItem.ToString();
            Ledc.Connect(com);
            ControlForm controlForm = new ControlForm(Ledc);
            controlForm.Show();
            this.Hide();
        }
    }
}
