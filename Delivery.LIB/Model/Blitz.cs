using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.LIB.Model
{
    public enum Tarif { doorToDoor, postOfficeToDoor, DoorToPostOffice }

    public class Blitz : CourierWaybill
    {
        public Blitz()
        {
            Sender = new Client();
            Recipient = new Client();
        }
        public Tarif TypeTarif { get; set; }
        public override void GetInfo()
        {
            Console.WriteLine("Тип тарифа: {0}", TypeTarif);
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
