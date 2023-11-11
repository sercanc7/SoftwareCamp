namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {  //1.Yol Product Property Oluşturma.
         Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryID = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;
        
            // 2.Yol Property Oluşturma.
         Product product2 = new Product {Id = 2, CategoryID = 5,
             UnitsInStock = 5, ProductName = "Kalem",UnitPrice = 35};

            //PascalCase    //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

     
                      
        }
    }
}