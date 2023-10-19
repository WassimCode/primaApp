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


        public Rifornisci()
        {
            InitializeComponent();
        }
        public Rifornisci(testApp2.Auto auto)
        {
            this.autoDetails = auto;
            InitializeComponent();
        }

        public int addCustomFuel(int fuel)
        {
            int tempFuel;
            tempFuel = Convert.ToInt32(Console.ReadLine());

            while (tempFuel < 0 || tempFuel > maxFuelLevel)
            {
                if (tempFuel < 0 || tempFuel > maxFuelLevel)
                {

                }
                Console.WriteLine("\n Insert the level of desired added fuel: ");
                tempFuel = Convert.ToInt32(Console.ReadLine());


            }


            return
        }

    }
}
