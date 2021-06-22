using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.DbContexts
{
  public class MyDBContext : DbContext
  {
    public DbSet<Person> Persons { get; set; }

    public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      // Use Fluent API to configure  

      // Map entities to tables  
      modelBuilder.Entity<Person>().ToTable("persons");

      // Configure Primary Keys  
      modelBuilder.Entity<Person>().HasKey(u => u.Id).HasName("PK_Person");

      // Configure indexes  
      modelBuilder.Entity<Person>().HasIndex(u => u.FirstName).HasDatabaseName("Idx_FirstName");
      modelBuilder.Entity<Person>().HasIndex(u => u.LastName).HasDatabaseName("Idx_LastName");

      // Configure columns  
      modelBuilder.Entity<Person>().Property(u => u.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
      modelBuilder.Entity<Person>().Property(u => u.FirstName).HasColumnType("nvarchar(50)").IsRequired();
      modelBuilder.Entity<Person>().Property(u => u.LastName).HasColumnType("nvarchar(50)").IsRequired();
      modelBuilder.Entity<Person>().Property(u => u.Address).HasColumnType("nvarchar(50)").IsRequired();
    }
  }
}