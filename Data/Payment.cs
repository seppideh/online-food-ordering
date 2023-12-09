using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Food_Ordering_System.Data
{
  public class Payment
  {
    public int Id { get; set; }
    public int Order_Id { get; set; }
    public int PaymentAmount { get; set; }
    public DateTime Date { get; set; }

  }
}