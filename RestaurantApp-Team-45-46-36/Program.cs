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
        new Restaurant { Name = "ครัวคุณแม่", Rating = 4.9 },
        new Restaurant { Name = "ซูชิโตเกียว", Rating = 4.8 },
        new Restaurant { Name = "ส้มตำนัว", Rating = 4.7 },
        new Restaurant{ Name = "ข้าวมันไก่เจ๊หน่อย", Rating = 4.6 },
        new Restaurant{ Name = "ก๋วยเตี๋ยวเรือ", Rating = 4.5 },
        new Restaurant{ Name = "สเต๊กลุงหนวด", Rating = 4.5 },
        new Restaurant { Name = "ฟาสต์ฟู้ดมุมถนน", Rating = 3.8 }
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
    static void ShowAllRestaurant()
    {
        for (int i = 0; i < restaurants.Count; i++)
        {
            Console.WriteLine(restaurants[i].Name);
        }
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
