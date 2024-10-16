/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        { 
            this.data = data;
            this.next = null;
        }
    }
    public class LinkedList1
    {
        public static void traverseLinkedList(Node head)
        { 
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data+" ");
                current = current.next;
            }
            Console.WriteLine();
        
        }
        public Boolean searchLinkedList(Node head, int target)
        {
            while (head != null)
            {
                if (head.data == target)
                {
                    return true;
                }
                head = head.next;

            }
            return false;
        }
        public int lengthLinkedList(Node head)
        {
            int length = 0;
            Node current = head;
            while (current != null)
            {
                length++;
                current = current.next;
                
            }
            return length;
        }
        public static Node InsertAtBeagining(Node head,int value)
        {
            Node newNode = new Node(value);

            newNode.next = head;
            head = newNode;
            return head;

        }
        public static Node InsertAtLast(Node head, int value)
        { 
            Node newnode = new Node(value);
            if (head == null)
            { 
                return newnode;
            }
            Node current = head;
            while (current.next != null)
            { 
                current = current.next;
            }
            current.next = newnode;
            return head;
        }
        public static Node insertPos(Node head, int pos, int value)
        {

            if (pos < 1) {
                Console.WriteLine("Invalid Position");
                return head;    
            }
            if (pos == 1)
            {
                Node tem = new Node(value);
                tem.next = head;
                return tem;
            }

            Node prev = head;
            int count = 1;
            while (count < pos-1 && prev !=null)
            {
                prev = prev.next;
                count++;

            }
            if (prev == null)
            {
                Console.WriteLine("Invalid Position");
                return head;
            }
            Node temp = new Node(value);
            temp.next = prev.next;
            prev.next = temp;
            return head;
        }
        public static Node DeleteAtFirstPosition(Node head)
        {
            if (head == null)
            {
                return null;
            }
            Node temp = head;
            head = head.next;
            return head;
        }
        public static Node DeleteAtLastPosition(Node head)
        {
            if (head == null)
            { 
                return null;
            }
            if (head.next == null)
            {
                head = null;
                return null;
            }
            Node second_last = head;
            while (second_last.next.next != null) { 
                second_last= second_last.next;
            }
            second_last.next = null;
            return head;
        }
        public static void deleteAtposition(Node head, int posi)
        {

            if (head == null || posi < 1) {
                return;
            }
            if (posi == 1) {
                Node tem = head;
                head = head.next;
                tem = null;
                return;
            }
            Node current = head;
            int count = 1;
            while (count < posi - 1 && current.next != null)
            {
                current = current.next;
                count++;
            }
            Node temp = current.next;
            current.next = current.next.next;
            temp = null;
        
        }
        
        static void Main(String[]args)
        {
            Node head = null; // Initialize the head of the linked list

            // Insert elements at the beginning
            
            head = LinkedList1.InsertAtBeagining(head, 10);
            head = LinkedList1.InsertAtBeagining(head, 20);
            head = LinkedList1.InsertAtBeagining(head, 30);
         

            Console.WriteLine("Linked List after inserting at beginning:");
            LinkedList1.traverseLinkedList(head);

            head = LinkedList1.InsertAtLast(head, 40);
            LinkedList1.traverseLinkedList(head);

        }
        
        


    }
}
*/