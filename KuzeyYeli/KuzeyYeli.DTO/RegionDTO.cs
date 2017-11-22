using System;
using System.Collections.Generic;

namespace KuzeyYeli
{
    public partial class RegionDTO
    {
        public RegionDTO()
        {
            this.Territories = new List<TerritoryDTO>();
        }

        public int RegionID { get; set; }
        public string RegionDescription { get; set; }
        public virtual ICollection<TerritoryDTO> Territories { get; set; }
    }
}
