using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqulatorApp
{
    public class GenericClass <T>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public T Item { get; set; }
    }
}
