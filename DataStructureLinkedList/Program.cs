using System;

namespace DataStructureLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To LinkedList Section1 ! ");
            LinkedLists linkedLists = new LinkedLists();
            //UC1
            /*
            Node node1 = new Node(56);
            Node node2 = new Node(30);
            Node node3 = new Node(70);
            node1.next = node2;
            node2.next = node3;  
            linkedLists.Head = node1;
            linkedLists.Display();
            Console.WriteLine("\n-------------------------------");
            //Uc2
            linkedLists.AddNode(70);
            linkedLists.AddNode(30);
            linkedLists.AddNode(56);
            linkedLists.Display();
            Console.WriteLine("\n-------------------------------");
            //UC-3
            linkedLists.AppendNode(56);
            linkedLists.AppendNode(30);
            linkedLists.AppendNode(70);
            linkedLists.Display();
            Console.WriteLine("\n-------------------------------");
            //UC-4
            linkedLists.AppendNode(56);
            linkedLists.AppendNode(70);
            linkedLists.InsertNode(30, 56);
            linkedLists.Display();
            Console.WriteLine("\n-------------------------------");
            //UC-5
            linkedLists.AppendNode(56);
            linkedLists.AppendNode(30);
            linkedLists.AppendNode(70);
            Console.WriteLine("Delete First element");
            linkedLists.DeleteNodeAtFirst();
            linkedLists.Display();
            Console.WriteLine("\n-------------------------------");
            //UC-6
            //Ability to delete the last element in the LinkedList of sequence 56->30->70 - Write popLast method
            //- Note there is new tail
            //- Final Sequence: 56->30
            */

            //UC-6
            linkedLists.AppendNode(56);
            linkedLists.AppendNode(30);
            linkedLists.AppendNode(70);
            Console.WriteLine("Delete Last element");
            linkedLists.DeleteNodeAtLast();
            linkedLists.Display();
            Console.WriteLine("\n-------------------------------");

        }
    }
}
