using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqulatorApp
{
    public class Equlater
    {
        public static bool AreEqual(int x, int y)
            { return x.Equals(y); }

        public static bool AreEqual(double x, double y)
        { return x.Equals(y); }

        public static bool AreEqual(string x, string y)
        { return x.Equals(y); }
    }
}
