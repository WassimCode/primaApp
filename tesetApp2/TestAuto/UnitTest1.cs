using testApp2;

namespace TestAuto;


    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Testa Auto.turnOn
        /// </summary>
        [TestMethod]
        public void TestTurnOn()
        {
            // declaring the obj Auto with parameters
            Auto a2 = new Auto("Ford", "Mustang", "Red", Auto.motori.benzina, 10);

            // turning on the car
            a2.turnOn();

            // showing the stats to check
            if (a2.showStateOut() == "\nTurned on.") ;
            //ok
            else {
            throw new Exception("");
            }
            
          }


        [TestMethod]
        public void TestSpeedUp()
        {
            // declaring the obj Auto with parameters
            Auto a2 = new Auto("Ford", "Mustang", "Red", Auto.motori.benzina, 10);
            a2.chilometraggio = 20;
        // turning on the car
            a2.accelera(20);

            // showing the stats to check
            if (a2.chilometraggio == 40) ;
            //ok
            else
            {
            throw new Exception("Speed is not synchronized");
            }

        }
}