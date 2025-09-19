using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amzon_Domain
{
    public class AmazonTask
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime CloseDate { get; set; }

        public int EmployeeId { get; set; }

        public Employee employee { get; set; }

        public List<Category> categories { get; set; } = new List<Category>();
    }
}
