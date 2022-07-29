﻿using System;
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
