namespace OrderWebAPI.Models.Entities;

public class Order
{
    private static int _staticId = 1;
    public int Id { get; set; }
    public string Name { get; set; }

    public Order()
    {
        Id = _staticId++;
    }
}
