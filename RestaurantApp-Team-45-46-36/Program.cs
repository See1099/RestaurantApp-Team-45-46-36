using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//เอาไว้ใน Namespace
class Restaurant
{
    public string Name { get; set; }
    public string Type { get; set; }
    public double Rating { get; set; }
}

internal class Program
{
    static List<Restaurant> restaurants = new List<Restaurant>
    {
        new Restaurant { Name = "Mcdonal", Type = "Fast Food", Rating = 4.2 },
        new Restaurant { Name = "MK", Type = "Suki", Rating = 4.7 },
        new Restaurant { Name = "Fuji", Type = "Japanese", Rating = 4.8 }
    };

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n===== Restaurant Menu =====");
            Console.WriteLine("1. Add Restaurant");
            Console.WriteLine("2. Show Good Rating");
            Console.WriteLine("3. Show Summary");
            Console.WriteLine("0. Exit");
            Console.Write("Select Menu: ");

            string menu = Console.ReadLine();

            switch (menu)
            {
                case "1":
                    AddRestaurant();
                    break;
                case "2":
                    ShowGoodRating();
                    break;
                case "3":
                    ShowSummary();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid Menu");
                    break;
            }
        }
    }

    // คน A รับผิดชอบ
    static void AddRestaurant()
    {
        Console.WriteLine("\n--- Add Restaurant ---");

        // รับชื่อร้าน
        Console.Write("Name: ");
        string name = Console.ReadLine()?.Trim();
        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Name cannot be empty.");
            return;
        }

        // กันชื่อซ้ำ (ไม่สนตัวพิมพ์เล็ก/ใหญ่)
        if (restaurants.Any(r => r.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine("This restaurant already exists.");
            return;
        }

        // รับประเภทร้าน
        Console.Write("Type: ");
        string type = Console.ReadLine()?.Trim();
        if (string.IsNullOrEmpty(type))
        {
            Console.WriteLine("Type cannot be empty.");
            return;
        }

        // รับเรตติ้ง (0 - 5)
        Console.Write("Rating (0-5): ");
        if (!double.TryParse(Console.ReadLine(), out double rating) || rating < 0 || rating > 5)
        {
            Console.WriteLine("Invalid rating. Please enter a number between 0 and 5.");
            return;
        }

        restaurants.Add(new Restaurant
        {
            Name = name,
            Type = type,
            Rating = rating
        });

        Console.WriteLine($"Added '{name}' successfully.");
    }

    // คน B รับผิดชอบ
    static void ShowGoodRating()
    {
        Console.WriteLine("Not completed");
    }

    // คน C รับผิดชอบ
    static void ShowSummary()
    {
        Console.WriteLine("Not completed");
    }
}
