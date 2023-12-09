using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Food_Ordering_System.Data
{
    public class Order
    {
        public int Id { get; set; }
        public string User_Id { get; set; }
        public string Address { get; set; }
        public int TotalPrice { get; set; }
        public int Discount { get; set; }  
        public int ServiceCost { get; set; }
        public int Tax { get; set; }
        public string Status { get; set; } //(Active,Paid,Cancelled)
        public int TotalAmountPayable { get; set; } //(TotalAmountPayable = TotalPrice+ServiceCost+Tax+-Discount)

  }
}