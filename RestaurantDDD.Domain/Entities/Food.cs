namespace RestaurantDDD.Domain.Entities;

public class Food
{
    public long Id { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public bool IsActive { get; set; }
}
