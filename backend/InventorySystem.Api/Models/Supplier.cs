namespace InventorySystem.Api.Models;

public class Supplier
{
    public int Id { get; set; }
    public string CompanyName { get; set; } = string.Empty;

    public string? ContatctName { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    // #Link between Supplier model and Product model. one-to-many
    public List<Product> Products { get; set; } = new();

}
