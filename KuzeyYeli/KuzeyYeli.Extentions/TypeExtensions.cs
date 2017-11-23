using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.Extensions
{
    public static class TypeExtensions
    {
        public static T MapTo<T>(this object source)
        {
            Type hedeftipi = typeof(T);
            Type kaynaktipi = source.GetType();

            T result = Activator.CreateInstance<T>();

            PropertyInfo[] hedefProps = hedeftipi.GetProperties();
            PropertyInfo[] kaynakProps = kaynaktipi.GetProperties();

            foreach (PropertyInfo kaynakProp in kaynakProps)
            {
                PropertyInfo hedefProp = hedefProps.FirstOrDefault(x => x.Name.ToLower() == kaynakProp.Name.ToLower());

                if (hedefProp != null)
                {
                    hedefProp.SetValue(result, kaynakProp.GetValue(source)); 
                }
            }

            if (result != null)
                return result;
            return default(T);
        }
    }
}
