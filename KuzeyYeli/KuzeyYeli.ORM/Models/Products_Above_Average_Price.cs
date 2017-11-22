using System;
using System.Collections.Generic;

namespace KuzeyYeli.ORM.Models
{
    public partial class Products_Above_Average_Price
    {
        public string ProductName { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
    }
}
