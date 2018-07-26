using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using Delivery.LIB.Model;

namespace Delivery.LIB
{
    public class ServiceDataBase
    {
        /// <summary>
        /// создание базы данных
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool CreateWaybill(CourierWaybill waybill, out string message)
        {
            try
            {
                using (var db = new LiteDatabase(@"myDelivery.db"))
                {
                    LiteCollection<CourierWaybill> waybills = db.GetCollection<CourierWaybill>("Waybill");
                    waybills.Insert(waybill);
                }
                message = "";
                return true;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Gray;
                message = ex.Message;
                return false;
            }
        }

    }
}
