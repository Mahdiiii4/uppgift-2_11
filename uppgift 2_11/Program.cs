using System;
namespace Uppgift_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt meter Elin hoppat?");
            int ett = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur långt meter Alma hoppat?");
            int två = int.Parse(Console.ReadLine());
            int rak = ett - två;
            Console.WriteLine("Elin har hoppat " +rak+ " mer meter än Alma");
        }
    }
}