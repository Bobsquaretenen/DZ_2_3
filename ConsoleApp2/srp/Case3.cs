using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;//ghg

namespace ConsoleApp2.srp
{
    class Case3
    {
        class Order
        {
            public int orderId;
            public List<string> items = new List<string>();

            public Order(string item)
            {
                items.Add(item);
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
            public PrinterOrder(List<string> items, int orderId)
            {
                Console.WriteLine("Order #" + orderId);
                foreach (var item in items)
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

                PrinterOrder printer = new PrinterOrder(order.items, order.orderId);
                SaveToDatabase saver = new SaveToDatabase();
                SendOrder sender = new SendOrder(); 
            }
        }
    }
} 
