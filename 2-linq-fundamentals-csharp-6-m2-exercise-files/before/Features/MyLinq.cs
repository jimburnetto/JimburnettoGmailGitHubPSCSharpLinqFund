using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.Linq
{
    public static class MyLinq
    {
        /// <summary>
        /// Test extension of Count to demonstrate how to use an extension similar to linq
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sequence"></param>
        /// <returns> count </returns>
        public static int Count<T>(this IEnumerable<T> sequence)
        {
            int count = 0;

            foreach (var item in sequence)
            {
                count += 1;
            }
            return count;
        }
    }
}
