using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.LIB.Model
{
   public  class Client
    {
       
        public string FIO { get; set; }
        public string Number { get; set; }
        public Address ClientAddress { get; set; } = new Address();
    }
}
