namespace ProductWebAPI.Models.Entities;

public class Product
{
    private static int _staticId = 1;
    public int Id { get; set; }
    public string Name { get; set; }

    public Product()
    {
        Id = _staticId++;
    }
}
