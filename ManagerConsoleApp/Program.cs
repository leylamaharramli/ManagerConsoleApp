using ManagerConsoleApp.Models;

namespace ManagerConsoleApp;

public class Program
{
    static void Main()
    {

        Manager<Product> productManager = new();
        while (true)
        {
            try
            {
                Console.WriteLine("1. Add new product\r\n2. Remove product.\r\n3. Update product.\r\n4. Find product with ID.\r\n5. Show all products.");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter product name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter product price:");
                        float price = float.Parse(Console.ReadLine());
                        Product product = new(name, price);
                        productManager.Add(product);
                        break;

                    case "2":
                        Console.WriteLine("Enter ID:");
                        int id = int.Parse(Console.ReadLine());
                        productManager.Remove(id);
                        break;

                    case "3":
                        Console.WriteLine("Enter product name:");
                        string name1 = Console.ReadLine();
                        Console.WriteLine("Enter product price:");
                        float price1 = float.Parse(Console.ReadLine());
                        Product product1 = new(name1, price1);
                        productManager.Update(product1);
                        break;

                    case "4":
                        Console.WriteLine("Enter ID:");
                        int id1 = int.Parse(Console.ReadLine());
                        productManager.GetByID(id1);
                        break;

                    case "5":
                        productManager.GetAll();
                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
