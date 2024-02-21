using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Category
    {
        public int CategoryID { get; set; }
        public String CategoryName { get; set; }
        public String CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }

        public ICollection<Heading> Headings { get; set; }
    }
}
