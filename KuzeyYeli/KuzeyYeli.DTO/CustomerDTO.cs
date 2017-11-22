using System;
using System.Collections.Generic;

namespace KuzeyYeli
{
    public partial class CustomerDTO
    {
        public CustomerDTO()
        {
            this.Orders = new List<OrderDTO>();
            this.CustomerDemographics = new List<CustomerDemographicDTO>();
        }

        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public virtual ICollection<OrderDTO> Orders { get; set; }
        public virtual ICollection<CustomerDemographicDTO> CustomerDemographics { get; set; }
    }
}
