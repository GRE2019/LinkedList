using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace ConsoleList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Añade al inicio:");
            Node list = new Node();
            LinkedListOperation linkedListOperation = new LinkedListOperation();

            list = linkedListOperation.createStart("Hola", list, null);
            list = linkedListOperation.createStart("Querido", list, null);
            list = linkedListOperation.createStart("Mundo", list, null);


            linkedListOperation.printList(list);

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
