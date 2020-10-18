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
            Random random = new Random();

            return random.Next(rangeToPickFrom.Count());
        }

        public static T PickRandomEntry<T>(IList<T> rangeToPickFrom)
        {
            return rangeToPickFrom[PickRandomEntryIndex(rangeToPickFrom)];
        }
    }
}
