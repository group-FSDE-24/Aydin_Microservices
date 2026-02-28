namespace ProductWebAPI.Models.Entities;

public class Customer
{
    private static int _staticId = 1;
    public int Id { get; set; }
    public string Name { get; set; }

    public Customer()
    {
        Id = _staticId++;
    }
}
