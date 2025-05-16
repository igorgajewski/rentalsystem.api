namespace rentalsystem.api.Models;

public class Client
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string TaxNumber { get; set; } = null!;
}

