
namespace classes
{
    internal class Product
    {
        public string BrandName;
        public string Model;
        public double Price;
        public double Cost;
        public double Income;
        public int Count;
        public Product(string brandName, string model, double price, double cost, int count)
        {
            BrandName = brandName;
            Model = model;
            Price = price;
            Cost = cost;
            Income = 0;
            if (count < 0)
            {
                Count = 0;
            }
            else
            {
                Count = count;
            }
        }
        public void PrintInfo()
        {
            Console.WriteLine("Brand: " + BrandName);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Price: " + Price + " AZN");
            Console.WriteLine("Cost: " + Cost + " AZN");
            Console.WriteLine("Count: " + Count);
            Console.WriteLine("Income: " + Income + " AZN");
        }
        public void Sale(int quantity)
        {
            if (quantity <= 0)
            {
                Console.WriteLine("count is not add for sale");
                return;
            }

            if (Count >= quantity)
            {
                double profit = (Price - Cost) * quantity;
                Income += profit;
                Count -= quantity;
                Console.WriteLine($"{quantity} product is saled. add {profit} AZN to the profit");
            }
            else
            {
                Console.WriteLine("there is no enough product");
            }
        }
        public void Refill(int quantity)
        {
            if (quantity <= 0)
            {
                Console.WriteLine("added count is not true");
                return;
            }

            Count += quantity;
            Console.WriteLine($"{quantity} product is added. new count: {Count}");
        }
    }
}

