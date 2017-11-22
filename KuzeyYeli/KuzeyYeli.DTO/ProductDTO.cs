using System;
using System.Collections.Generic;

namespace KuzeyYeli
{
    public partial class ProductDTO
    {
        public ProductDTO()
        {
            this.Order_Details = new List<Order_DetailDTO>();
        }

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<short> UnitsInStock { get; set; }
        public Nullable<short> UnitsOnOrder { get; set; }
        public Nullable<short> ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public virtual CategoryDTO Category { get; set; }
        public virtual ICollection<Order_DetailDTO> Order_Details { get; set; }
        public virtual SupplierDTO Supplier { get; set; }
    }
}
