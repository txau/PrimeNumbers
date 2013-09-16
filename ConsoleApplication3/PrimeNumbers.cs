using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    public class PrimeNumbers
    {
        static void Main(string[] args)
        {


        }

        public static List<int> generate(int number)
        {
            List<int> result = new List<int>();
            decomposeNumber(number, result);

            return result;
        }

        private static void decomposeNumber(int number, List<int> result)
        {
            for (int factor = 2; factor <= number; factor++)
            {
                var isExactDivision = (number % factor) == 0;
                if (isExactDivision)
                {
                    result.Add(factor);
                    var divisionResult = number / factor;
                    decomposeNumber(divisionResult, result);
                    break;
                }
            }
        }
    }
}
