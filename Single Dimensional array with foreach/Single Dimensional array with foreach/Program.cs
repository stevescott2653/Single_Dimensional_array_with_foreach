using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Dimensional_array_with_foreach
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 }; //creating and initializing array
            
            //Traversing Array
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
