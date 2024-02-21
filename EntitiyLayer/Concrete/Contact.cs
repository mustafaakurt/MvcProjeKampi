using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Contact
    {
        public int ContactID { get; set; }
        public String UserName { get; set; }
        public String UserMail { get; set; }
        public String Subject { get; set; }
        public String Message { get; set; }
    }
}
