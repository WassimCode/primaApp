namespace AutoInterattivaForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.



            testApp2.AutoInterattiva auto = new testApp2.AutoInterattiva("Ferrari", "LaFerrari", "Rossa", testApp2.Auto.motori.diesel, 20, 20);
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(auto));
        }
    }
}