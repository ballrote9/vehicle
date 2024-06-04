using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sweets_console;

namespace Sweets_gui
{
    internal static class Data_store
    {

            public static List<Sweets> sweets_items = new List<Sweets>();
            public static List<CandiesSweets> candies_items = new List<CandiesSweets>();    
            public static List<ChocolatesSweets> chocolates_items = new List<ChocolatesSweets>();

            public static string Type;
            public static int Ind;
    }
}
