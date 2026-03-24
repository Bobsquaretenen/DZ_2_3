using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.srp
{
    class Case3
    {
        class Order
        {
            public int OrderId;
            public List<string> Items = new List<string>();

            public Order(string item)
            {
                Items.Add(item);
            } 

        }
        class SendOrder
        {
            public SendOrder()
            {
                Console.WriteLine("Order confirmation email sent!");
            }
        }

        class PrinterOrder
        {
            public PrinterOrder(List<string> Items, int OrderId)
            {
                Console.WriteLine("Order #" + OrderId);
                foreach (var item in Items)
                {
                    Console.WriteLine(" - " + item);
                }
            }
        }

        class SaveToDatabase
        {
            public SaveToDatabase()
            {
                Console.WriteLine("Order saved to Database!");
            }
        }



        public class App
        {
            static void Main()
            {
                Order order = new Order("Laptop"); 

                PrinterOrder printer = new PrinterOrder(order.Items, order.OrderId);
                SaveToDatabase saver = new SaveToDatabase();
                SendOrder sender = new SendOrder(); 
            }
        }
    }
} 
