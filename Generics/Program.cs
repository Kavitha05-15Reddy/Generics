using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic_List1
            GenericList<int> intList1 = new GenericList<int>();
            intList1.AddElement(1);
            intList1.AddElement(2);
            intList1.AddElement(3);
            Console.Write("Int List:");
            intList1.PrintList();

            GenericList<string> stringtList1 = new GenericList<string>();
            stringtList1.AddElement("apple");
            stringtList1.AddElement("banaana");
            stringtList1.AddElement("orange");
            Console.Write("\nString List:");
            stringtList1.PrintList();

            //Generic_List2
            List<int> intList2 = new List<int>() { 1, 2, 3, 4, 5 };
            ListPrinter<int> intPrinter = new ListPrinter<int>(intList2);
            Console.Write("\nInt List:");
            intPrinter.PrintList();
            List<string> stringList1 = new List<string>() { "apple","banana","orange","sapota" };
            ListPrinter<string> stringPrinter = new ListPrinter<string>(stringList1);
            Console.Write("\nString List:");
            stringPrinter.PrintList();

            //Generic_List3
            ListContainer<int> intList = new ListContainer<int>();
            intList.Add(10);
            intList.Add(20);
            intList.Add(30);
            intList.Insert(0, 40);
            Console.Write("\nInt List before remove:");
            intList.PrintItem();
            intList.Remove(20);
            Console.Write("\nInt List after remove:");
            intList.PrintItem();
            Console.WriteLine("\n" + intList.Contains(20));
            
        }
    }
}
