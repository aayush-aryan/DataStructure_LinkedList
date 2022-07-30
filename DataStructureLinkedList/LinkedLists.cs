using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureLinkedList
{
    class LinkedLists
    {
        public Node Head;
        public Node Tail;

        public LinkedLists()
        {
            Head = null;
            Tail = null;
        }
        /// <summary>
        /// method for addNode
        /// </summary>
        /// <param name="value"></param>
        public void AddNode(int value)
        {
            Node node = new Node(value);
            //Checking wheather the list is empty then creates node as head
            if (Head == null & Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                ////If node than add new node as head 
                node.next = Head;
                Head = node;
            }
            Console.WriteLine($" Added {value} at start of the linkedlist");
        }
        /// <summary>
        /// method for AppendNode
        /// </summary>
        /// <param name="value"></param>
        public void AppendNode(int value)
        {
            Node node = new Node(value);
            //Check wheather the list is empty then creates node as head
            if (Head == null & Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Node temp = Head;
                ////If node than add new node as head 
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine($"Added {value} at start of the linkedlist");
        }
        /// <summary>
        /// added serach method to check node data
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Search(int value)
        {
            //Temp variable is head now
            Node temp = Head;
            //Check until temp location will null
            while (temp != null)
            {
                //If temp node data is equal to value to be searched
                if (temp.data == value)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }
        /// <summary>
        /// metod for inserting data b/w nodes
        /// </summary>
        /// <param name="value"></param>
        /// <param name="Previousvalue"></param>
        public void InsertNode(int value, int Previousvalue)
        {
            Node newNode = new Node(value);
            if (Head == null & Tail == null)
            {
                Head = newNode;
            }
            else
            {
                Node temp = Head;
                //Checking until temp variable data equal to the previous value of value to be added
                while (temp.data != Previousvalue)
                {
                    temp = temp.next;
                }
                newNode.next = temp.next;
                temp.next = newNode;
            }
        }
        /// <summary>
        /// method for deleting first element 
        /// </summary>
        public void DeleteNodeAtFirst()
        {
            if (Head == null & Tail == null)
            {
                Console.WriteLine("Nothing to delete list is empty");
            }
            Node temp = Head;
            //Change head to next node to delete the previous node
            Head = Head.next;

            Console.WriteLine("Removed from linkedlist :" + temp.data);
        }
        /// <summary>
        /// method for deleting lastNodeElements
        /// </summary>
        public void DeleteNodeAtLast()
        {

            if (Head == null & Tail == null)
            {
                Console.WriteLine("Nothing to delete list is empty");

            }

            Node temp = Head;
            //Check until the temp next nodes's next loction is null
            while (temp.next.next != null)
            {

                temp = temp.next;
            }
            //After getting this node change its location to null
            temp.next = null;
        }
        /// <summary>
        /// method for counting linkedList
        /// </summary>
        /// <returns></returns>
        public int getCount()
        {
            Node temp = Head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;

        }
        /// <summary>
        ///method for deleting nodeValue;
        /// </summary>
        /// <param name="value"></param>
        public void deleteNode(int value)
        {
            // Store head node
            Node temp = Head, prev = null;

            // If head node itself holds the key to be deleted
            if (temp != null && temp.data == value)
            {
                // Changed head
                Head = temp.next;
                return;
            }

            // Search for the key to be deleted, keep track of  previous node as we need to change temp.next
            while (temp != null && temp.data != value)
            {
                prev = temp;
                temp = temp.next;
            }

            // If key was not present in linked list
            if (temp == null)
                return;

            // Unlink the node from linked list
            prev.next = temp.next;
        }
        /// <summary>
        /// method for sorting linkedListInAscendingOrder;
        /// </summary>
        public void sort()
        {
            Node index, j;
            int temp;
            for (index = this.Head; index.next != null; index = index.next)
            {
                for (j = index.next; j != null; j = j.next)
                {
                    if (index.data > j.data)
                    {
                        temp = index.data;
                        index.data = j.data;
                        j.data = temp;
                    }
                }
            }
        }
        /// <summary>
        /// method for display linkedList
        /// </summary>  
        internal void Display()
        {
            Node temp = Head;
            if (temp == null)
                Console.WriteLine("Linked list is empty");
            else
                Console.WriteLine("Linked List:");
            while (temp != null)
            {
                Console.Write(temp.data);
                if (temp.next != null)
                    Console.Write(" -> ");
                temp = temp.next;
            }
        }
    }
}
