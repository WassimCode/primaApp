namespace AutoInterattivaForm
{
    public partial class Form1 : Form
    {

        testApp2.AutoInterattiva a3 = new testApp2.AutoInterattiva("Ferrari", "LaFerrari", "Rossa", testApp2.Auto.motori.diesel, 20, 20);

        public Form1()
        {


            InitializeComponent();
            updateFuelBar(a3.fuel);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            updateFuelBar(a3.fuel);

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

        }


        private void button3_Click(object sender, EventArgs e)
        {
            a3.turnOn();
            updateFuelBar(a3.fuel);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            a3.turnOff();
            updateFuelBar(a3.fuel);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (a3.isOn)
            {
                AlterSpeed A = new AlterSpeed("speed up");
                A.ShowDialog();
                a3.chilometraggio += A.value;
            }
            else
            {
                //OnClosing;
            }
            updateFuelBar(a3.fuel);

        }


        private void button6_Click(object sender, EventArgs e)
        {
            AlterSpeed A = new AlterSpeed("slow down");
            A.ShowDialog();
            a3.chilometraggio = Math.Max(a3.chilometraggio -= A.value, 0);
            updateFuelBar(a3.fuel);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            updateFuelBar(a3.fuel);

        }


        private void button8_Click(object sender, EventArgs e)
        {
            updateFuelBar(a3.fuel);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Details d1 = new Details(a3);
            d1.ShowDialog();
            updateFuelBar(a3.fuel);

        }

        private void updateFuelBar(int newFuel)
        {
            progressBar1.Value = newFuel;
        }
    }
}