namespace InterviewConsoleApp;

public class Exercise
{
    private List<Product> Products = new List<Product>();

    public void Run()
    {
        Products = ProductLoader.LoadProductsFromEmbeddedResource();

        // Write your Code Here.

        Warehouse warehouse1 = new Warehouse(1, "Galaxus");
        Warehouse warehouse2 = new Warehouse(2, "Digitec");

        foreach (var product in Products)
        {
            if (product.Type == ProductType.Phone || product.Type == ProductType.Laptop)
            {
                warehouse1.AddProduct(product);
            }
            else
            {
                warehouse2.AddProduct(product);
            }
        }

        // Most expensive phone in warehouse 1
        var expensiveProduct = warehouse1.Products.Where(p => p.Type == ProductType.Phone)
            .OrderByDescending(p => p.Price)
            .First();
        Console.WriteLine(expensiveProduct);

        // warehouse1 -> p.Count where p.Type == headphones 
        // warehouse2 .... 


        // product 1 total values 
        var product1TotalValue1 = warehouse1.Products.Where(p => p.Type == ProductType.Phone).Sum(p => p.Price);
        var product1TotalValue2 = warehouse2.Products.Where(p => p.Type == ProductType.Phone).Sum(p => p.Price);
    }
}