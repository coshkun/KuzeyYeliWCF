using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli
{
    [ServiceContract]
    public interface IServiceBase<DTO>
    {
        [OperationContract]
        List<DTO> Listele();
        [OperationContract]
        bool Ekle(DTO entity);
        [OperationContract]
        bool Guncelle(DTO entity);
        [OperationContract]
        bool Sil(DTO entity);

    }
}
