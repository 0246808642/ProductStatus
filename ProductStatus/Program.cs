using ProductStatus.Entities;
using System.Globalization;

namespace ProductStatus
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Commom, used or imported (c/u/i)? ");
                char In = char.Parse(Console.ReadLine());

                if (In == 'i' || In == 'I')
                {
                    Console.Write("Name: ");
                    string nome = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Custom fee: ");
                    double customFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(nome, price, customFee));
                }
                else if (In == 'u' || In == 'U')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, data));
                }
                else if (In == 'c' || In == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    list.Add(new Product (name, price));
                }

                else 
                {
                    Console.WriteLine("Digite as letras i/c/u");
                }

            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            
            foreach (Product product in list) {
                Console.WriteLine(product.PriceTag());
            }
           
        }
    }
}
