using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWithIntelligentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            DiscountStoreSystem newPriecies = new DiscountStoreSystem(CreateProducts());
            IntelligentStoreSystem store = new IntelligentStoreSystem(newPriecies.MakeADiscount());
            List<Buyer> listOfBuyers = CreateBuyersList();
            BuyersAndProductsOutput(store, listOfBuyers);
            Console.ReadKey();
        }

        public static List<Product> CreateProducts()
        {
            var production = new List<Product>();
            production.Add(new Product(0, Products.Ball, 10, Categories.Sport,0));
            production.Add(new Product(1, Products.Banannas, 20, Categories.Food,0));
            production.Add(new Product(2, Products.Bricks, 100, Categories.Building,0));
            production.Add(new Product(3, Products.Oven, 1000, Categories.Cooking,0));
            return production;
        }
        public static List<Buyer> CreateBuyersList()
        {
            var buyers = new List<Buyer>();
            buyers.Add(new Buyer(0, "Mary", "", Professions.Housewife, 100));
            buyers.Add(new Buyer(1, "Peter", "", Professions.Builder, 500));
            buyers.Add(new Buyer(2, "Mike", "", Professions.Sportsman, 2000));
            buyers.Add(new Buyer(3, "Kate", "", Professions.Cook, 400));
            return buyers;
        }
        public static void BuyersAndProductsOutput(IntelligentStoreSystem store, List<Buyer> buyers)
        {
            foreach (var buyer in buyers)
            {
                Console.Write(buyer.Name + " can buy: ");
                store.GetsNecessaryProducts(buyer).ToList<string>().ForEach(print => Console.Write(print + "; "));
                Console.WriteLine();
            }
        }
    }
}
