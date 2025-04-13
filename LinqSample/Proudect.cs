using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample
{
    public class Proudect
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int price { get; set; }

        public string Location { get; set; }
        public List<string> colors { get; set; }
    }
}
