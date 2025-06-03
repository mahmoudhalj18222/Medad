using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Amzon_Domain
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<AmazonTask> tasks { get; set; } = new List<AmazonTask>();
    }
}
