using System.Net.Http.Headers;

namespace InterviewConsoleApp;
/*
 * A warehouse has the following functionality:

    Add products to the warehouse

    Remove products from the warehouse

    Get a list of all products in the warehouse
 */
public class Warehouse
{

    public int ID { get; init; }
    private string Name;
    public List<Product> Products { get; private set;}

    public int currentProducts { get; private set; }

    private int maxProducts = 10;

    public Warehouse(int id, string name)
    {
        ID = id;
        Name = name;
        Products = new List<Product>();
        currentProducts = 0;
    }

    public bool AddProduct(Product product)
    {
        // raise error properly
        if (++currentProducts > maxProducts) return false;
        
        Products.Add(product);
        currentProducts++;
        return true;
    }

    public bool RemoveProduct(Product product)
    {
        if (Products.Contains(product))
        {
            if (Products.Remove(product))
            {
                currentProducts--;
                return true;
            }
            // error / exceptions
        }

        return false;
    }

}