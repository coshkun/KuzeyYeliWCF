using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using KuzeyYeli.Extensions;
using KuzeyYeli.ORM.Models;

namespace KuzeyYeli
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductService.svc or ProductService.svc.cs at the Solution Explorer and start debugging.
    public class ProductService : IProductService
    {

        public List<ProductDTO> Listele()
        {
            throw new NotImplementedException();
        }

        public bool Ekle(ProductDTO entity)
        {
            Product p = entity.MapTo<Product>();
            return true;
        }

        public bool Guncelle(ProductDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Sil(ProductDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
