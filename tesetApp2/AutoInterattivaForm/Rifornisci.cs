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
    public partial class Rifornisci : Form
    {
        testApp2.Auto autoDetails;

        public int tempFuel;


        public Rifornisci()
        {
            InitializeComponent();
        }
        public Rifornisci(testApp2.Auto auto)
        {
            this.autoDetails = auto;
            InitializeComponent();
        }

        public void addCustomFuel()
        {

            this.tempFuel = 0;
            this.tempFuel = Convert.ToInt32(textBox1.Text);


            if (tempFuel < 0 || tempFuel > testApp2.Auto.maxFuelLevel)
            {
                label2.Visible = true;
            }
            else
            {
                this.tempFuel = Convert.ToInt32(textBox1.Text);
                this.Close();

            }

            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            addCustomFuel();
        }
    }
}
