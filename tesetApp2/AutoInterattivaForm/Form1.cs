namespace AutoInterattivaForm
{
    public partial class Form1 : Form
    {

        testApp2.AutoInterattiva a3 = new testApp2.AutoInterattiva("Ferrari", "LaFerrari", "Rossa", testApp2.Auto.motori.diesel, 20, 20);

        public Form1()
        {


            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rifornisci r1 = new Rifornisci();
            r1.ShowDialog();
            a3.fuel = r1.tempFuel;
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(a3.isOn)
            {
                AlterSpeed A = new AlterSpeed("speed up");
                A.ShowDialog();
                a3.chilometraggio += A.value;
            }
            else
            {
                OnClosing
            }
            //a3.chilometraggio -=
        }


        private void button6_Click(object sender, EventArgs e)
        {
            AlterSpeed A = new AlterSpeed("slow down");
            A.ShowDialog();
            a3.chilometraggio = Math.Max(a3.chilometraggio -= A.value, 0);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }


        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Details d1 = new Details(a3);
            d1.ShowDialog();

        }


    }
}