using System.Reflection;
using System.Text.Json;

namespace InterviewConsoleApp;

public static class ProductLoader
{
    public static List<Product> LoadProductsFromEmbeddedResource()
    {
        // Get the current assembly
        var assembly = Assembly.GetExecutingAssembly();


        // Hardcode the name of the embedded resource (adjust the namespace as needed)
        var resourceName = "InterviewConsoleApp.Products.json";  // Replace "MyNamespace" with your actual namespace

        // Access the embedded resource using its full name
        using var stream = assembly.GetManifestResourceStream(resourceName);
        if (stream == null)
        {
            throw new Exception("Resource not found.");
        }

        // Read and deserialize the JSON data
        using var reader = new StreamReader(stream);
        string jsonString = reader.ReadToEnd();

        return JsonSerializer.Deserialize<List<Product>>(jsonString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new List<Product>();
    }
}