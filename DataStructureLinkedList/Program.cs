using System;

namespace DataStructureLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To LinkedList Section1 ! ");
            LinkedLists linkedLists = new LinkedLists();
            Node node1 = new Node(56);
            Node node2 = new Node(30);
            Node node3 = new Node(70);
            node1.next = node2;
            node2.next = node3;
            linkedLists.Head = node1;
            linkedLists.Display();


        }
    }
}
