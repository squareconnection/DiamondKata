using System.Text.RegularExpressions;
using DiamondKata.Services;

namespace DiamondKata
{
    class Program
    {
        static void Main(string[] args)
        {
            var diamondKataService = new DiamondKataService();
            Console.WriteLine("Input a letter to build your Diamond Kata");
            var input = Console.ReadKey().KeyChar;
            if (Regex.IsMatch(input.ToString(), @"^[a-zA-Z]+$"))
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