using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.LIB.Model
{
    public class Express : CourierWaybill
    {

        public Express()
        {
            Sender = new Client();
            Recipient = new Client();
        }

     
    }
}
