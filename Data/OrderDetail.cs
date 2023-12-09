using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Food_Ordering_System.Data
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Order_Id { get; set; }
        public int Item_Id { get; set; }
        public int quantity { get; set; }
        public int Item_Price { get; set; }
    }
}