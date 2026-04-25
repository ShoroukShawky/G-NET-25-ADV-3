using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV03
{
    internal static class ConsoleHelper
    {
        public static void PrintList<T>(string listName, List<T> items)
        {
            Console.WriteLine($"{listName} : [{string.Join(", ", items)}]");

        }

        public static void PrintHashSet<T>(string setName, HashSet<T> items)
        {
            Console.WriteLine($"{setName} : [{string.Join(", ", items)}]");

        }

        public static void PrintCollection<T>(string colName, IEnumerable<T> items)
        {
            Console.WriteLine($"{colName} : [{string.Join(", ", items)}]");

        }
    }
}