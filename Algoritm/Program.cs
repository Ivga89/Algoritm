using System.Security.Cryptography.X509Certificates;

namespace Algoritm
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<User> users = new List<User>();
            User user1 = new User("vasya", "Vasiliy", true);
            User user2 = new User("zzz00", "Grisha", false);
            User user3 = new User("lililiX", "Kristina", false);
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);

            foreach(User user in users)
            {
                Console.WriteLine($"Hello {user.Name}");
                if (user.IsPremium == false)
                {
                    ShowAds();
                }
                Console.WriteLine();
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