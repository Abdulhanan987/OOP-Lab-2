using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagementSystem.NewFolder1;
namespace ProductManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            int x = 0;
            Products[] products=new Products[100];
            while(true)
            {    Console.Clear();
                Console.WriteLine("Product Management System: ");
                Console.WriteLine("1.Add Products: ");
                Console.WriteLine("2.Show Products: ");
                Console.WriteLine("3.Total Store Worth: ");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.Clear();
                    products[x] = addProducts();
                    x++;
                    Console.WriteLine("Press any key to continue: ......");
                    Console.ReadKey();
                }
                else if (option == 2)
                {
                    Console.Clear();

                    ShowProducts(products, x);
                    Console.WriteLine("Press any key to continue: ......");
                    Console.ReadKey();
                }
                else if (option == 3)
                {
                    Console.Clear();
                    float sum = TotalPrice(products, x);
                    Console.WriteLine("The total net worth is: " + sum);
                    Console.WriteLine("Press any key to continue: ......");
                    Console.ReadKey();
                }
                else
                    break;
            }
           
           
        }
        static Products addProducts()
        {
            Console.Write("Enter the name of product: ");
            string name = Console.ReadLine();
            Console.Write("Enter the ID of product: ");
            int ID = int.Parse(Console.ReadLine());
            Console.Write("Enter the price of product: ");
            float price = float.Parse(Console.ReadLine());
            Console.Write("Enter the category of product: ");
            string category = Console.ReadLine();
            Console.Write("Enter the country of product: ");
            string country = Console.ReadLine();
            Console.Write("Enter the brand Name of product: ");
            string brandName = Console.ReadLine();
            Products products = new Products(name,country,price,ID,brandName,category);
            return products;
        }
        static void ShowProducts(Products[]products,int count)
        {
            for (int i=0; i < count; i++)
            {
                Console.WriteLine("Name: " + products[i].Name);
                Console.WriteLine("ID: "+ products[i].ID);
                Console.WriteLine("Price: " + products[i].price);
                Console.WriteLine("Category: " + products[i].Category);
                Console.WriteLine("Country: " + products[i].Country);
                Console.WriteLine("Brand Name: " + products[i].brandName);
            }
        }
        static float TotalPrice(Products[] products,int count)
        {
            float total = 0;
            for(int i=0; i < count;i++)
            {
                total = total + (products[i].price);
            }
            return total;
        }

    }
}
