//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Collection
//{
//    public class Node
//    {
//        public int data;
//        public Node next;
//        public Node(int data)
//        {
//            this.data = data;
//            this.next = null;
//        }
//    }
//    public class Queue
//    {
//        Node front, rear;

//       public Queue()
//        {
//            front = rear = null;
//        }

//        public Boolean isEmpty()
//        { 
//            return front == null && rear == null;
//        }
//        public void enque(int value)
//        {
//            Node newNode = new Node(value);

//            if (rear == null)
//            { 
//                front = rear = newNode;
//                return;
//            }
//            rear.next = newNode;
//            rear = newNode;
//        }
//        public void dequeue()
//        {
//            if (isEmpty())
//            {
//                Console.WriteLine("Queue is UnderFlow");
//                return;
//            }
//            Node temp = front;
//            front = front.next;
//            if (front == null)
//            {
//                rear = null;
//            }
//        }
//        public int getFront()
//        {
//            if (isEmpty())
//            {
//                Console.WriteLine("Queue is Empty");
//                return -1;
//            }
//            return front.data;
//        }
//        public int getRear()
//        {
//            if (isEmpty())
//            {
//                Console.WriteLine("Queue is Empty");
//                return -1;
//            }
//            return rear.data;
//        }
//    }
//    public class QueueLinkedList
//    {
//        public static void Main(String[] args)
//        {
//            Queue q = new Queue();
//            q.enque(11);
//            q.enque(12);
//            q.enque(13);
//            Console.WriteLine("front is: "+q.getFront());
//            Console.WriteLine("Rear is: "+q.getRear());
//            q.dequeue();
//            q.dequeue();
//            Console.WriteLine("front is: " + q.getFront());
//            Console.WriteLine("Rear is: " + q.getRear());
//        }
//    }
//}
