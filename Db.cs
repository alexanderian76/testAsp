using System.Numerics;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using TestAsp.Models;

public class MobileContext : DbContext
{
    public DbSet<Phone> Phones { get; set; }

    public MobileContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Filename=Mobile.db");
    }
}