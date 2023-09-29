using System;
namespace uppgift_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar vill du hyra bilen?");
            string dagar = Console.ReadLine();
            int dgr = int.Parse(dagar);
            Console.WriteLine("Hur många kilometer ska du köra?");
            string kilometer = Console.ReadLine();
            int klm = int.Parse(kilometer);
            int kostnaden = ((dgr - 1) * 500) + klm + 300;
            Console.WriteLine("Det kostar " + kostnaden);
        }
    }
}