using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListOperation
    {
        public Node createStart(Object item, Node start, Node end)
        {
            Node node = new Node();

            node.item = item;
            node.next = start;
            start = node;

            return node;
        }

        public Node CreateEnd(Object item, Node list)
        {
            if (list != null)
            {
                list = new Node();

                list.item = item;
                list.next = null;

                return list;
            }
            else
            {
                Node start = new Node();

                start.item = item;

                Node current = list;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = list;

                return current;
            }
        }

        public void printList(Node list)
        {
            Node node = new Node();

            node = list;

            while (node != null)
            {
                Console.WriteLine(node.item);

                if (node.next.next != null)
                {
                    node = node.next;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
