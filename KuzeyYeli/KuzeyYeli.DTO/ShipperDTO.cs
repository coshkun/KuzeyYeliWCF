using System;
using System.Collections.Generic;

namespace KuzeyYeli
{
    public partial class ShipperDTO
    {
        public ShipperDTO()
        {
            this.Orders = new List<OrderDTO>();
        }

        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<OrderDTO> Orders { get; set; }
    }
}
