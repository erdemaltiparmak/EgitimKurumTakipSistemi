using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKurumTakipSistemi.Common.Helper
{
    public static class DachtHelper
    {
        public static TCast Cast<TCast>(object from)
        {
            return (TCast)from;
        }
    }
}
