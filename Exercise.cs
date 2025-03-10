namespace InterviewConsoleApp;

public class Exercise
{
    private List<Product> Products = new List<Product>();
    
    public void Run()
    {
        Products = ProductLoader.LoadProductsFromEmbeddedResource();

        foreach (var product in Products)
        {
            Console.WriteLine(product.ToString());
        }
    }

}