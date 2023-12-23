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

  }
}