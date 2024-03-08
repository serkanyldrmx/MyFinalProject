using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    //SOLID
    //open closed principle

    internal class Program
    {
        static void Main(string[] args)
        {
            productTest();
            //productTest2();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void productTest2()
        {
            ProductManager productManager = productTest();
            Console.WriteLine();
            Console.WriteLine("---------------------------------");

            foreach (var product in productManager.GetByUnitPrice(50, 100))
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static ProductManager productTest()
        {
            ProductManager productManager = new ProductManager(new EFProductDal());
            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }

            return productManager;
        }
    }
}
