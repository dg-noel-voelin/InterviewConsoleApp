namespace InterviewConsoleApp;


public record Product(string Name, ProductType Type, decimal Price);


public enum ProductType
{
    Phone = 1,
    Laptop = 2,
    Headphone = 3,
    SmartWatch = 4
    
}