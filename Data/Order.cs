using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Food_Ordering_System.Data
{
  public class Order : BaseEntity
  {
    public string User_Id { get; set; }
    public int TotalPrice { get; set; }
    public int Discount { get; set; }  //should be calculated
    public int ServiceCost { get; set; }
    public int Tax { get; set; }
    public Status Status { get; set; } //(incomplete,pending(before payment),cancelled,finilized(paid),send,received)
    public int TotalAmountPayable { get; set; } //(TotalAmountPayable = TotalPrice+ServiceCost+Tax+-Discount)
    public DateTime Created_at { get; set; }
    public User User { get; set; }
    public ICollection<OrderDetail> OrderDetails { get; set; }

  }
}