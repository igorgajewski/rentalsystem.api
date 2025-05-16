using Microsoft.EntityFrameworkCore;
using rentalsystem.api.Models;

namespace rentalsystem.api;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<Client> Clients => Set<Client>();
    public DbSet<Equipment> Equipment => Set<Equipment>();
    public DbSet<RepairEntry> RepairEntries => Set<RepairEntry>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Equipment>()
            .Property(e => e.Types)
            .HasColumnType("text[]");

        modelBuilder.Entity<Employee>()
            .HasOne(e => e.Manager)
            .WithMany()
            .HasForeignKey(e => e.ManagerId);
    }
}

