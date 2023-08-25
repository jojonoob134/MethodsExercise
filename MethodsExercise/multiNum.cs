using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MethodsExercise
{
    internal class multiNum
    {
        public static int BegNum(params int[] Numbers) 
        {
            int sum = 0;
            foreach (int Number in Numbers)
            {
                sum += Number;
            }
            Console.WriteLine(sum);
            return sum;
        }
    }
}
