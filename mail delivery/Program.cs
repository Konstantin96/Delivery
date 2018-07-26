using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.LIB.Model;
using Delivery.LIB;

namespace mail_delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMenu();
            int answer = Int32.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    {
                        string msg = "";
                        var test = GetUserInfoForCreationExpressDelivery();
                        if (!ServiceDataBase.CreateWaybill(test, out msg))
                        {
                            Console.WriteLine(msg);
                        }

                    }
                    break;
                case 2:
                    {
                        //ServiceDataBase.CreateWaybill(GetUserInfoForCreationBuisnessDelivery);
                    }
                    break;
                case 3:
                    {
                        //  ServiceDataBase.CreateWaybill(GetUserInfoForCreationBlitzDelivery);
                    }
                    break;
                default:
                    break;
            }
        }
        static public void PrintMenu()
        {
            Console.WriteLine("Здравствуйте! Пожалуйста, выберите тип отправки поссылки");
            Console.WriteLine("1.Экспресс\n2.Бизнес\n3.Блиц");
        }
        static public Express GetUserInfoForCreationExpressDelivery()
        {
            Express waybill = new Express();
            Console.WriteLine("Вводите данные отправителя!");
            Console.Write("ФИО: ");
            waybill.Sender.FIO = Console.ReadLine();
            Console.Write("номер телефона: ");
            waybill.Sender.Number = Console.ReadLine();
            Console.WriteLine("Адрес");
            Console.Write("Страна: ");
            waybill.Sender.ClientAddress.Country = Console.ReadLine();
            Console.Write("Город: ");
            waybill.Sender.ClientAddress.City = Console.ReadLine();
            Console.Write("Улица, дом, кв: ");
            waybill.Sender.ClientAddress.StreetHouseFlat = Console.ReadLine();


            //foreach (var item in waybill
            //{
            //}           
            
            //Console.Clear();

            //Console.WriteLine("Вводите данные получателя!");
            //Console.Write("ФИО: ");
            //waybill.Recipient.FIO = Console.ReadLine();
            //Console.Write("номер телефона: ");
            //waybill.Recipient.Number = Console.ReadLine();
            //Console.Write("номер телефона: ");
            //waybill.Recipient.Number = Console.ReadLine();
            //Console.WriteLine("Адрес");
            //Console.Write("Страна: ");
            //waybill.Recipient.ClientAddress.Country = Console.ReadLine();
            //Console.Write("Город: ");
            //waybill.Recipient.ClientAddress.City = Console.ReadLine();
            //Console.Write("Улица, дом, кв: ");
            //waybill.Recipient.ClientAddress.StreetHouseFlat = Console.ReadLine();

            return waybill;
        }
    }
}
