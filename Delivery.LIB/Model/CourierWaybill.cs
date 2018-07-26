using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.LIB.Model
{
    public abstract class CourierWaybill
    {
        public int CourierWaybillId { get; set; }
        public Client Sender { get; set; } 
        public Client Recipient { get; set; }
        public virtual void GetInfo()
        {
            Console.WriteLine("ФИО(отправитель): {0} {1}\nАдрес: {2}, {3}, {4}",
                Sender.FIO, Sender.Number,
                Sender.ClientAddress.Country, Sender.ClientAddress.City, Sender.ClientAddress.StreetHouseFlat);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("ФИО(получатель): {0} {1}\nАдрес: {2}, {3}, {4}",
                           Recipient.FIO, Recipient.Number,
                           Recipient.ClientAddress.Country, Recipient.ClientAddress.City, Recipient.ClientAddress.StreetHouseFlat);
            Console.WriteLine("---------------------------------------");
        }
    }
}
