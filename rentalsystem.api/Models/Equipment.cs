namespace rentalsystem.api.Models;

public class Equipment
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Producer { get; set; } = null!;
    public decimal RentPerDay { get; set; }
    public string[] Types { get; set; } = Array.Empty<string>(); // PostgreSQL array
    public string UsageType { get; set; } = null!;
    public int Quantity { get; set; }

    public List<RepairEntry> RepairHistory { get; set; } = new();
}

public class RepairEntry
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }

    public int EquipmentId { get; set; }
    public Equipment Equipment { get; set; } = null!;
}

