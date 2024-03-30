using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Arrays
    {
        public void PrintArray<T>(T[] array)
        {
            Console.WriteLine($"Array of {typeof(T)}:");
            foreach( T item in array )
            {
                Console.WriteLine(item);
            }    
        }
    }
}
