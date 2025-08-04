namespace classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student("Nazrin", "Abbasova", "TI-86", 93);

            student1.PrintInfo();
            student1.CheckGraduation();
            student1.GetDiplomDegree();


            Product p1 = new Product("clothes", "shirt", 100, 80, 2);

            p1.PrintInfo();
            Console.WriteLine();

            p1.Sale(3);
            p1.PrintInfo();
            Console.WriteLine();

            p1.Refill(5);
            p1.PrintInfo();
        }


       
    }
}
