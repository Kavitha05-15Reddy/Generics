using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //Generic_Interface:
    public interface IClass
    {
        void MyMethod();
    }
    public class MyClass : IClass
    {
        public void MyMethod()
        {
            Console.WriteLine("Implementation of MyMethod");
        }
    }
    //Generic_List3 using Interface:
    public interface IContainer<T>
    {
        void Add(T item);
        void Remove(T item);
        void Insert(int index, T item);
        bool Contains(T item);
    }
    //Implementation
    public class ListContainer<T> : IContainer<T>
    {
        private List<T> items;
        public ListContainer()
        {
            items = new List<T>();
        }
        public void Add(T item)
        {
            items.Add(item);
        }
        public void Remove(T item)
        {
            items.Remove(item);
        }
        public void Insert(int index, T item)
        {
            items.Insert(index, item);
        }
        public bool Contains(T item)
        {
            return items.Contains(item);
        }
        public void PrintItem()
        {
            foreach (T item in items)
            {
                Console.Write(item + " ");
            }
        }
    }
}

