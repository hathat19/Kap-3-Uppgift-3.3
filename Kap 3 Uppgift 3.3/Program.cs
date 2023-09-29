using System;
namespace Uppgift3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du hyra bilen? Svara med ett heltal.");
            int hours = int.Parse(Console.ReadLine());

            //Är sum över 950? I så fall så stannar den på 950.
            int sum = (hours*80) > 950 ? 950 : (hours*80);

            //Timme eller timmar
            string timme = hours == 1 ? "timme" : "timmar";

            Console.WriteLine($"Det kostar {sum} kronor att hyra bilen i {hours} {timme}.");
            Console.ReadKey();
        }
    }
}