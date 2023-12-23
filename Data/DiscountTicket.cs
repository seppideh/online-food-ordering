using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Food_Ordering_System.Data
{
  public class DiscountTicket
  {
    public int Id { get; set; }
    public int UserId { get; set; }
    public string discountCode { get; set; }
    public int Amount { get; set; }
    public DateTime ActiveDate { get; set; }
    public DateTime ExpireDate { get; set; }
    public bool Used { get; set; }
    public User User { get; set; }
  }
}