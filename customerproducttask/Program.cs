using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customerproducttask
{
    class Program
    {
        private static CustomerContext customerContext = new CustomerContext();
        //add customers

        public static void AddCustomer()
        {
            Customer c = new Customer();

            Console.WriteLine("Enter Cname:");
            c.Cname = Console.ReadLine();

            Console.WriteLine("Enter mobile number:");
            c.MobileNo = long.Parse(Console.ReadLine());

            Console.WriteLine("Add Products:");
            c.ProductDetails = GetProductsList();

            customerContext.customers.Add(c);
            customerContext.SaveChanges();

        }

        //add products and return list

        public static List<Product> GetProductsList()
        {
            List<Product> list = new List<Product>();
            int choice = 0;
          
            do
            {

                Product p = new Product();
                Console.WriteLine("PName:");
                p.PName = Console.ReadLine();

                Console.Write("\tQuantity:");
                p.Quantity = int.Parse(Console.ReadLine());

                Console.Write("\tPrice:");
                p.Price = double.Parse(Console.ReadLine());

                list.Add(p);
                Console.WriteLine("Press 1");

                choice = int.Parse(Console.ReadLine());

            } while (choice == 1);
            return list;
            
        }

        static void Main(string[] args)
        {
            AddCustomer();
            Console.ReadLine();

        }
    }
}
