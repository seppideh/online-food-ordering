using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Online_Food_Ordering_System.Data
{
  public class FoodStoreContext : DbContext
  {
    public FoodStoreContext(DbContextOptions<FoodStoreContext> options) : base(options)
    {
    }
    public DbSet<Item> Items { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<DiscountTicket> DiscountTickets { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Item>()
          .Property(e => e.Category)
          .HasConversion<string>(); // Configure the first enum property to be stored as string

      modelBuilder.Entity<Item>()
          .Property(e => e.Type)
          .HasConversion<string>(); // Configure the second enum property to be stored as string

      modelBuilder.Entity<User>()
          .Property(e => e.Role)
          .HasConversion<string>();

      modelBuilder.Entity<Order>()
          .Property(e => e.Status)
          .HasConversion<string>();
    }
  }
}