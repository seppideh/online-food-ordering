using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Food_Ordering_System.Data
{
  public class User : BaseEntity
  {
    public Role Role { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public bool Verified { get; set; }
    public ICollection<DiscountTicket> DiscountTickets { get; set; }
    public ICollection<Order> Orders { get; set; }
    public ICollection<Payment> Paymets { get; set; }
  }
}