using System;
using System.Collections.Generic;

namespace KuzeyYeli
{
    public partial class TerritoryDTO
    {
        public TerritoryDTO()
        {
            this.Employees = new List<EmployeeDTO>();
        }

        public string TerritoryID { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionID { get; set; }
        public virtual RegionDTO Region { get; set; }
        public virtual ICollection<EmployeeDTO> Employees { get; set; }
    }
}
