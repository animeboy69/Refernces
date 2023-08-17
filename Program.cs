namespace Refernces
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Sedan myFirstSedan = new Sedan(0);
            IAutomobile myAutomobile = myFirstSedan;


            Sedan myOtherSedan = new Sedan(0);

            myFirstSedan.IncreaseSpeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myAutomobile.Speed);
            Console.WriteLine(myFirstSedan.Equals(myAutomobile));

            myFirstSedan.IncreaseSpeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myAutomobile.Speed);
            Console.WriteLine(myFirstSedan.Equals(myOtherSedan));

            Truck myTruck = new Truck(40,400, "MyTrUck");

            // Calls stringfly method and describes automobiles.
            myFirstSedan.Stringfly();
            myAutomobile.Stringfly();
            myOtherSedan.Stringfly();
            myTruck.Stringfly();
        }
    }
}