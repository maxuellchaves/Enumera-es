using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enumerações.Entities;
using Enumerações.Entities.Enums;

namespace Enumerações
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

           
            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus OS;
            Enum.TryParse("Delivered", true, out OS);



            Console.WriteLine(OS);
            Console.WriteLine(txt);
        }
    }
}
