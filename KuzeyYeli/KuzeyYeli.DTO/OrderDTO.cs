using System;
using System.Collections.Generic;

namespace KuzeyYeli
{
    public partial class OrderDTO
    {
        public OrderDTO()
        {
            this.Order_Details = new List<Order_DetailDTO>();
        }

        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<System.DateTime> RequiredDate { get; set; }
        public Nullable<System.DateTime> ShippedDate { get; set; }
        public Nullable<int> ShipVia { get; set; }
        public Nullable<decimal> Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public virtual CustomerDTO Customer { get; set; }
        public virtual EmployeeDTO Employee { get; set; }
        public virtual ICollection<Order_DetailDTO> Order_Details { get; set; }
        public virtual ShipperDTO Shipper { get; set; }
    }
}
