namespace Motors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Statisztika statisztika = new Statisztika();
            statisztika.ReadFromFile("motors.txt");

            Console.WriteLine($"Az összes motor ára: {statisztika.SumPrices()}");
            Console.WriteLine($"Van e Ninja 1100 SX benne: {statisztika.Contains("Ninja 1100 SX")}");
            Console.WriteLine($"A legrégebbi évjáratú motor: {statisztika.Oldest().Name}");
            Console.WriteLine($"Az össze motor ára, ami Aprilia : {statisztika.SumBasedOnBrand("Aprilia", "motors.txt")}");
            statisztika.Sort();
            Console.WriteLine("Sorba lettek a motorok állítva performance szerint.");

        }
    }
}