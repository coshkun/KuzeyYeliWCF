using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.Extensions
{
    public static class TypeExtensions
    {
        public static T MapTo<T>(this object source)
        {
            return default(T);
        }
    }
}
