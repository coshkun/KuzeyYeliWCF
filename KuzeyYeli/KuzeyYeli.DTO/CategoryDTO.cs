using System;
using System.Collections.Generic;

namespace KuzeyYeli
{
    public partial class CategoryDTO
    {
        public CategoryDTO()
        {
            this.Products = new List<ProductDTO>();
        }

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public virtual ICollection<ProductDTO> Products { get; set; }
    }
}
