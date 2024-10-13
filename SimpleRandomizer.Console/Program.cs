using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleRandomizer;

namespace SimpleRandomizer.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your list of values separated by comma and then press Enter.");
            var listString = Console.ReadLine();
            var list = listString.Split(',').ToList();

            var randomIndex = Randomizer.PickRandomEntryIndex(list);
            var randomEntryFromIndex = list[randomIndex];

            Console.WriteLine("Random index: {0}, entry from the random index: {1}", randomIndex + 1, randomEntryFromIndex);

            Console.ReadLine();

            var directRandomEntry = Randomizer.PickRandomEntry(list);

            Console.WriteLine("Random entry picked directly: {0}", directRandomEntry);
            Console.ReadLine();
        }
    }
}
