using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoInterattivaForm
{
    public partial class AlterSpeed : Form
    {
        public string choice;
        // Amount of speed in Km/h to gain/lose
        public int value;
        public AlterSpeed()
        {
            InitializeComponent();
        }

        public AlterSpeed(string choice)
        {
            InitializeComponent();
            this.choice = choice;
            label1.Text = "Enter by how many km/h you want to " + choice;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            value = Convert.ToInt32(numericUpDown1.Value);
            this.Close();
        }



        // Override the OnClosing method to perform some custom actions
        protected override void OnClosing(CancelEventArgs e)
        {
            // Call the base class method first
            base.OnClosing(e);
            string alertText;
            if(choice == "accelera")
                alertText = "Questa " + choice + "zione ti costerà " + numericUpDown1.Value + "litri di benzina, vuoi procedere?";
            else
                alertText = "Stai per decelerare, vuoi procedere?";
            // Check if the user wants to cancel the closing
            if (MessageBox.Show(alertText, "Certo!", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // Set the Cancel property to true to prevent the form from closing
                e.Cancel = true;
            }
        }
    }
}
