using System.Text.RegularExpressions;
using DiamondKata.Contracts;
using DiamondKata.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DiamondKata
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
            .AddSingleton<IDiamondKataService, DiamondKataService>()
            .BuildServiceProvider();

            var diamondKataService = serviceProvider.GetService<IDiamondKataService>();
            Console.WriteLine("Input a letter to build your Diamond Kata");
            var input = Console.ReadKey().KeyChar;
            if (Regex.IsMatch(input.ToString(), @"^[a-zA-Z]+$") && diamondKataService!=null)
            {
                var result = diamondKataService.Execute(input);

                Console.WriteLine();
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Only letters A through Z are allowed");
            }
        }
    }
}