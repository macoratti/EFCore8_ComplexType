using EFCore8_ComplexType.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EFCore8_ComplexType;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=desktop-dk57unp\\sqlexpress;Initial Catalog=ExemploDB;Integrated Security=True;TrustServerCertificate=True;");
        optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>().ComplexProperty(a => a.Endereco, 
                                                       a=> a.IsRequired());
    }
    public DbSet<Cliente> Clientes { get; set; }
}
