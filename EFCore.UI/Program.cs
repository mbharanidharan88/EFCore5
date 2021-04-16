using System;
using System.Linq;
using System.Threading.Tasks;
using EFCore.Data;
using EFCore.Domain;

namespace EFCore.UI
{
    class Program
    {
        private static SamuraiContext _context = new SamuraiContext();
        static async Task Main(string[] args)
        {
            await _context.Database.EnsureCreatedAsync();

            GetSamurais("Before Add:");
            AddSamurai();
            GetSamurais("After Add:");

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        private static void AddSamurai()
        {
            var samurai = new Samurai { Name = "Bharani" };
            _context.Samurais.Add(samurai);
            _context.SaveChanges();
        }

        private static void GetSamurais(string text)
        {
            var samurais = _context.Samurais.ToList();
            Console.WriteLine($"{text}: Samurai count is {samurais.Count}");

            foreach (var samurai in samurais)
            {
                Console.WriteLine(samurai.Name);
            }
        }
    }
}
