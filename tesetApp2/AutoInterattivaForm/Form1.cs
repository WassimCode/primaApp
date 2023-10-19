using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace AutoInterattivaForm
{
    public partial class Form1 : Form
    {

        testApp2.AutoInterattiva a3 = new testApp2.AutoInterattiva("Ferrari", "LaFerrari", "Rossa", testApp2.Auto.motori.diesel, 20, 0);

        public Form1()
        {

            InitializeComponent();
            updateFuelBar(a3.fuel);
            updateGuageBar(a3.chilometraggio);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            updateFuelBar(a3.fuel);
            updateGuageBar(a3.chilometraggio);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rifornisci r1 = new Rifornisci();
            r1.ShowDialog();
            a3.fuel += r1.tempFuel;
            if (a3.fuel > testApp2.Auto.maxFuelLevel)
            {
                a3.fuel = testApp2.Auto.maxFuelLevel;
            }
            updateFuelBar(a3.fuel);
            updateGuageBar(a3.chilometraggio);

        }


        private void button3_Click(object sender, EventArgs e)
        {
            a3.turnOn();
            timer1.Enabled = true;


            updateFuelBar(a3.fuel);
            updateGuageBar(a3.chilometraggio);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            a3.turnOff();
            timer1.Enabled = false;

            updateFuelBar(a3.fuel);
            updateGuageBar(a3.chilometraggio);


        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (a3.isOn)
            {
                AlterSpeed A = new AlterSpeed("accelera");
                A.ShowDialog();
                a3.chilometraggio += A.value;
                a3.fuel = Math.Max(a3.fuel -= A.value, 0);
            }
            else
            {

                //OnClosing;
            }
            updateFuelBar(a3.fuel);
            updateGuageBar(a3.chilometraggio);


        }


        private void button6_Click(object sender, EventArgs e)
        {
            AlterSpeed A = new AlterSpeed("decelera");
            A.ShowDialog();
            updateGuageBar(a3.chilometraggio);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            updateFuelBar(a3.fuel);
            updateGuageBar(a3.chilometraggio);

        }


        private void button8_Click(object sender, EventArgs e)
        {
            updateFuelBar(a3.fuel);
            updateGuageBar(a3.chilometraggio);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Details d1 = new Details(a3);
            d1.ShowDialog();
            updateFuelBar(a3.fuel);
            updateGuageBar(a3.chilometraggio);
        }

        private void updateFuelBar(int newFuel)
        {
            progressBar1.Value = newFuel;
            if (newFuel == 0)
            {
                timer1.Enabled = false;
            }
        }

        private void updateGuageBar(int newSpeed)
        {
            radialGauge1.Value = newSpeed;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a3.fuel < 0)
            {
                a3.fuel = 0;
                a3.turnOff();
            }

            if (a3.chilometraggio < 0)
            {
                a3.chilometraggio = 0;
                a3.turnOff();
            }
            if (a3.isOn)
            {
                a3.rallenta(5);
                if (a3.chilometraggio == 0)
                {
                    a3.fuel--;
                    
                }
                else
                {
                    a3.fuel = a3.fuel - 3;
                }
            }

        }
    }//

}