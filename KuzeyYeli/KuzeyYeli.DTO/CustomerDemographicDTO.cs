using System;
using System.Collections.Generic;

namespace KuzeyYeli
{
    public partial class CustomerDemographicDTO
    {
        public CustomerDemographicDTO()
        {
            this.Customers = new List<CustomerDTO>();
        }

        public string CustomerTypeID { get; set; }
        public string CustomerDesc { get; set; }
        public virtual ICollection<CustomerDTO> Customers { get; set; }
    }
}
