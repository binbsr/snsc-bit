using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PMS.Models;

namespace PMS.Data;
public class PMSDbContext: IdentityDbContext
{
    public DbSet<Department> Departments { get; set; }
    public DbSet<Doctor> Doctors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=PMS_DB_BIT;Integrated Security=True;";
        optionsBuilder.UseSqlServer(connectionString);
    }
}
