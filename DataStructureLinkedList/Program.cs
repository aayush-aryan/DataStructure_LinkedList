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
            linkedLists.AppendNode(56);
            linkedLists.AppendNode(30);
            linkedLists.AppendNode(70);
            Console.WriteLine("Delete Last element");
            linkedLists.DeleteNodeAtLast();
            linkedLists.Display();
            Console.WriteLine("\n-------------------------------");
            //UC-7
            Node node1 = new Node(56);
            Node node2 = new Node(30);
            Node node3 = new Node(70);
            node1.next = node2;
            node2.next = node3;
            linkedLists.Head = node1;
            Console.WriteLine("Search For Node value 30");
            linkedLists.Display();
            if (linkedLists.Search(30))
            {
                Console.WriteLine("\nNode with value 30 is available in Linked list");
            }
            Console.WriteLine("\n-------------------------------");
           // Uc-8
            //Ability to insert 40 after 30 to the Linked List sequence of 56->30->70
            Console.WriteLine("Add Node After Node value 30 ");
            linkedLists.AppendNode(56);
            linkedLists.AppendNode(30);
            linkedLists.AppendNode(70);
            linkedLists.InsertNode(40, 30);
            linkedLists.Display();
            //UC_9
            //Ability to delete 40 from the Linked List sequence of 56->30->40->70 and show the size of LinkedList is 3
            //UC-9
            Console.WriteLine("Add Node After Node value 30 ");
            linkedLists.AppendNode(56);
            linkedLists.AppendNode(30);
            linkedLists.AppendNode(40);
            linkedLists.AppendNode(70);
            Console.WriteLine("Before deleting:");
            linkedLists.Display();
            linkedLists.deleteNode(40);
            Console.WriteLine("\nAfter deleting:");
            linkedLists.Display();
            Console.WriteLine("\nSize of LinkedList is " + linkedLists.getCount());
            Console.WriteLine("\n-------------------------------");
            //UC-10
            //Ability to create Ordered Linked List in ascending order of data entered in following sequence 56, 30, 40,and 70
            */
            //UC10
            linkedLists.AppendNode(56);
            linkedLists.AppendNode(30);
            linkedLists.AppendNode(40);
            linkedLists.AppendNode(70);
            linkedLists.sort();
            Console.Write("sorted ");
            linkedLists.Display();
            Console.WriteLine("\n-------------------------------");
        }
    }
}
