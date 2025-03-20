using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqulatorApp
{
    public class GenericEqulator
    {
        public static bool AreEqual<T>(T firstNam, T SceandNam)
        { return firstNam.Equals(SceandNam); }

        public static A Dothnig<T, A>(T firstNam, A SceandNam)
        {
            return SceandNam;
        }
    }
}
