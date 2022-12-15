using System;
using System.Linq;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int num)
        {
            int n = 1;
            while(num > 0)
            {
                n = num * n;
                num--;
            }
            return n;
        }

        public static string FormatSeparators(params string[] items)
        {            
            string[] resultArr;

            int len = items.Length - 1;

            string lastVal = items[len];

            var arrayList = items.ToList();

            arrayList.RemoveAt(len)	;

            resultArr = arrayList.ToArray();

            string resultStr = String.Format("{0} and {1}", string.Join(",", resultArr), lastVal);

            return resultStr;		
        }
    }
}
