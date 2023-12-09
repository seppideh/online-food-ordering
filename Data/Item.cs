using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Food_Ordering_System.Data
{
    public class Item
    {
      public int Id { get; set; }
       public string ItemName { get; set; } 
       public string Description { get; set; }
       public int Price { get; set; }
       public int Category_Id { get; set; }
       public int Type_Id { get; set; }
    }
}