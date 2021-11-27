using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> alilinkedlist = new LinkedList<string>();

            alilinkedlist.AddFirst("mohamed");
            alilinkedlist.AddFirst("ali");
            alilinkedlist.AddLast("shahat");
            alilinkedlist.AddLast("mohamed");

            Console.WriteLine("The linked List Before Removing:  ");

            foreach (var item in alilinkedlist)
            {
                Console.WriteLine(item);
            }

            alilinkedlist.Remove("mohamed");
            alilinkedlist.RemoveLast();
            alilinkedlist.RemoveFirst();

            Console.WriteLine();
            Console.WriteLine("The linked List After Removing: ");

            foreach (var item in alilinkedlist)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
