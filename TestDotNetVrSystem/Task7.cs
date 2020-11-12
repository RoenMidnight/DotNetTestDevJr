using System.Collections.Generic;
using System.Linq;
using TestDotNetVrSystem.HelpClasses;

namespace TestDotNetVrSystem
{
    public class Task7
    {
        /*
         * Desenvolma um método que retorne o nome dos produtos que estão com estoque zerado
         * Dica: A classe Repository possui as informções dos Products
         */
        public static List<string> GetProductsOutOfStock()
        {
            var repository = new Repository();

            return repository.Products.Where(x => x.Stock.Quantity == 0).Select(x => x.Name).ToList();
        }

        /*
        * Desenvolma um método que retorne a soma total das quantidades de estoque dos itens
        * Dica: A classe Repository possui as informções dos Products
        */
        public static int GetSumStock()
        {
            var repository = new Repository();

            return repository.Products.Sum(x => x.Stock.Quantity);
        }

        /*
         * Crie um método que verifique, dado Id e quantidade solicitada do produto
         * se o mesmo possui quantidade em estoque para venda
         * Dica: A classe Repository possui as informções dos Products
         * 
         */
        public static bool IsSalePossible(int productId, int orderQuantity)
        {
            var repository = new Repository();

            return repository.Products.Where(
                x => x.Id == productId && x.Stock.Quantity >= orderQuantity)
                .FirstOrDefault() != null ?  true : false ;
        }
    }
}
