namespace rentalsystem.api.Models;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Address { get; set; } = null!;
    public DateTime EmploymentDate { get; set; }
    public string Phone { get; set; } = null!;
    public DateTime? BirthDate { get; set; }
    public string Role { get; set; } = null!; // If Role is enum, define it
    public int? ManagerId { get; set; }

    public Employee? Manager { get; set; }
}

