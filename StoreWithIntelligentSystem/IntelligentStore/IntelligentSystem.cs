using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWithIntelligentSystem
{
    public class IntelligentSystem: IIntelligent
    {
        public IEnumerable<string> GetsNecessaryProducts(Buyer buyer, List<Product> production)
        {
            var productsForBuyer = new List<string>();
            var categories = CategoryForPerson().Where(categ => categ.Key == buyer.Profesion).SelectMany(c => c.Value).ToList<Categories>();
            var product = production.Where(prod => buyer.Cash >= prod.Price ).ToList<Product>();
            var listOfProductsAndPrieces =
                from prod in product
                from categ in categories
                where prod.Category == categ
                select prod.ToString();
            
            return listOfProductsAndPrieces;
        }
        protected Dictionary<Professions, List<Categories>> CategoryForPerson()
        {
            var categBuyer = new Dictionary<Professions, List<Categories>>();
            categBuyer.Add(Professions.Housewife, new List<Categories> { Categories.Food });
            categBuyer.Add(Professions.Builder, new List<Categories> { Categories.Building });
            categBuyer.Add(Professions.Cook, new List<Categories> { Categories.Food, Categories.Cooking });
            categBuyer.Add(Professions.Sportsman, new List<Categories> { Categories.Food, Categories.Sport });
            return categBuyer;
        }
    }
}
