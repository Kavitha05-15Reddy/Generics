using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    //Generic_List1:
    public class GenericList<T>
    {
        private List<T> _list;
        public GenericList()
        {
            _list = new List<T>();
        }
        public void AddElement(T element)
        {
            _list.Add(element);
        }
        public void PrintList()
        {
            foreach (T item in _list)
            {
                Console.Write(item + " ");
            }
        }
    }
    //Generic_List2:
    public class ListPrinter<T>
    {
        private List<T> _list;
        public ListPrinter(List<T> list)
        {
            _list = list;
        }
        public void PrintList()
        {
            foreach (T item in _list)
            {
                Console.Write(item + " ");
            }
        }
    }
}
