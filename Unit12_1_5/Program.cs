using System;
using System.Collections.Generic;
using System.Threading;

namespace Unit12_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> Users = new List<User>()
            {
                new User {Login = "Anton_dom", Name = "Anton", IsPremium = false},
                new User {Login = "Ivan_dom", Name = "Ivan", IsPremium = true},
                new User {Login = "Dmitriy_dom", Name = "Dmitriy", IsPremium = false}
            };

            foreach (var user in Users)
            {
                if (!user.IsPremium) ShowAds();

                Console.WriteLine($"Приветствуем вас {user.Name}.");
            }

        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }

}
