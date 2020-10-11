using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRandomizer
{
    public class Randomizer
    {
        public static int PickRandomEntryIndex<T>(IList<T> rangeToPickFrom)
        {
            var list = rangeToPickFrom.ToDictionary(x => rangeToPickFrom.IndexOf(x));

            Random random = new Random();

            return random.Next(list.Count());
        }

        public static T PickRandomEntry<T>(IList<T> rangeToPickFrom)
        {
            var list = rangeToPickFrom.ToDictionary(x => rangeToPickFrom.IndexOf(x));

            Random random = new Random();

            return list[random.Next(list.Count)];
        }
    }
}
