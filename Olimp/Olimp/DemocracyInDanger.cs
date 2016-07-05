using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimp
{
    public class DemocracyInDanger
    {
        static void Main1()
        {
            string[] tokens = //new[] {"3","5", "7", "5" };
                   Console.In.ReadToEnd().Split(
                       new char[] { ' ', '\t', '\n', '\r' },
                       StringSplitOptions.RemoveEmptyEntries);
            int numbers = int.Parse(tokens[0]);
            int count = numbers/2+1;
            int result = 0;
            int[] array = new int[tokens.Length-1];
            for (int i = 1; i < tokens.Length; i++)
            {
                array[i - 1] = int.Parse(tokens[i]);
            }

            Array.Sort(array);
            for (int i = 0; i < count; i++)
            {
                result += array[i]/2 + 1;
            }

            Console.Write(result);


           // Console.ReadKey();
        }
    }
}
