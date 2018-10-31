using System;
/* Implement an algorithm to find the kth to the last element of a singly linked list
 * */
namespace LinkedList5
{
    public class Node<T>
    {
        public Node<T> next;
        public T data;

        public Node()
        {
            next = null;
        }
        public Node(T value)
        {
            data = value;
            next = null;
        }
    }

    public class MyLL<T>
    {
        Node<T> head;

        public MyLL()
        {
            head = null;
        }

        public void AddHead(T value)
        {
            Node<T> node = new Node<T>(value);
            node.next = head;
            head = node;
        }

        public void PrintAllNodes()
        {
            Node<T> cur = head;
            while (cur.next != null)
            {
                Console.WriteLine(cur.data);
                cur = cur.next;
            }
            Console.WriteLine(cur.data);
            Console.WriteLine();
        }

        public Node<T> FindElement(int val)
        {
            if (val <= 0) return null;
            
            Node<T> first = head, second = head;
            int i = 0;
            while (i < (val-1) && second != null)
            {
                second = second.next;
                i++;
            }
            if (second == null)
                return null;
            while (second.next != null)
            {
                first = first.next;
                second = second.next;
            }
            return first;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyLL<char> list = new MyLL<char>();

            list.AddHead('3');
            list.AddHead('1');
            list.AddHead('4');
            list.AddHead('3');
            list.AddHead('2');
            list.AddHead('2');
            list.AddHead('8');

            list.PrintAllNodes();

            Node<char> node = new Node<char>();
            node = list.FindElement(1);
            if (node != null)
                Console.WriteLine(node.data);
            else
                Console.WriteLine("The kth element is not listed correctly");


        }
    }

