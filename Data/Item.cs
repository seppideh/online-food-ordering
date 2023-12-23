using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Food_Ordering_System.Data
{
  public class Item : BaseEntity
  {
    public string ItemName { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public DateTime Created_at { get; set; }
    public bool IsDeleted { get; set; }
    public Category Category { get; set; }
    public Type Type { get; set; }
  }
}