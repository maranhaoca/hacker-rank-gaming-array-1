using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
        /*
         * Complete the 'gamingArray' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static string gamingArray(List<int> arr)
        {
            int count = 0;
            var sortArr = arr.OrderByDescending(x => x).ToList();


            for (int i = 0; i < sortArr.Count; i++)
            {
                if (arr.Contains(sortArr[i]))
                {
                    int maxIndex = arr.IndexOf(sortArr[i]);
                    arr.RemoveRange(maxIndex, (arr.Count - maxIndex));
                    count++;
                }
                if (arr.Count == 0)
                {
                    break;
                }
            }

            return (count % 2 == 0) ? "ANDY" : "BOB";
        }
    }
}