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
            var result = diamondKataService.Execute(input);

            Console.WriteLine();
            Console.WriteLine(result);
        }
    }
}