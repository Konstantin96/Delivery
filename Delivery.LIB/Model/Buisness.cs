using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.LIB.Model
{
    public enum TypeOfPostalParcel { document, package, specificPackage }
    public class Buisness : CourierWaybill
    {
        public Buisness()
        {
            Sender = new Client();
            Recipient = new Client();
        }
        public  TypeOfPostalParcel typeDoc { get; set; }
        public override void GetInfo()
        {
            Console.WriteLine("Тип посылки: {0}", typeDoc );
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
