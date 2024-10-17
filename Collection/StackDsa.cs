
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Collection
//{
//    public class Stack
//    {
//        static int MAX = 100;
//        int top;
//        int[] a = new int[MAX];

//        public Stack()
//        {
//            top = -1;
//        }
//        public Boolean isEmpty()
//        {

//            return (top < 0);
//        }
//        public Boolean push(int x)
//        {

//            if (top >= (MAX - 1))
//            {
//                Console.WriteLine("Stack overflow");
//                return false;
//            }
//            else
//            {
//                a[++top] = x;
//                Console.WriteLine(x + " is pushed into stack");
//                return true;
//            }
//        }
//        public int pop()
//        {

//            if (top < 0)
//            {
//                Console.WriteLine("Stack is UnderFlow");
//                return top;
//            }
//            else {
//                int x = a[top--];
//                return x;
//            }
//        }
//        public int peek()
//        {
//            if (top < 0)
//            {
//                Console.WriteLine("Stack is underflow");
//                return 0;
//            }
//            else
//            {
//                 int x = a[top];
//                return x;
//            }
//        }
//        public void print()
//        {
//            for (int i = top; i > -1; i--)
//            { 
//                Console.WriteLine(a[i]+" ");
//            }
//        }
//        public Boolean isFull()
//        {
//            if (top == MAX - 1)
//            { 
//                return true;
//            }
//            return false;
//        }
//    }
//    internal class StackDsa
//    {
//        static void Main(String[] args)
//        {
//            Stack st1 = new Stack();
//            st1.push(10);
//            st1.push(20);
//            st1.push(30);
//            st1.print();
//            Console.WriteLine(st1.isEmpty());
//            Console.WriteLine(st1.isFull());
//            Console.WriteLine(st1.pop());
//            st1.print();
//            Console.WriteLine(st1.peek());
//            st1.print();


//        }
//    }
//}
//*/