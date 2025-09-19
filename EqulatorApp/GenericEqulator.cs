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
        public static T IncreaseByOne<T>(T number)
        {
            try
            {
                int numberAsIn = (int)Convert.ChangeType(number, typeof(int));
                numberAsIn += 1;
                return (T)Convert.ChangeType(numberAsIn, typeof(T));
            }
            catch (Exception)
            {

                return default(T);
            }
            

        }
    }
}
