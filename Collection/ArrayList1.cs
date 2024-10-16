/*
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class ArrayLists
    {
        static void Main(String[] args)
        { 
            ArrayList list = new ArrayList();
            list.Add("zossjj");
            list.Add("Prathmesh");
            list.Add("Tushar");
            
            string secondElement = (string)list[1];
            var firstElement = list[0];
           
            Console.WriteLine($"First element is : {firstElement} and second element is: {secondElement} \n");
            
            list[0] = "Akash";
            

            foreach (var i in list)
            {
            Console.WriteLine(i);
            }
            Console.WriteLine();
            var arraylist = new ArrayList() {
            "Akash",
            102,
            "Pune"
            };
            //foreach (var a in arraylist)
            //{
            //    Console.WriteLine(a);
            //}
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(arraylist[i]);
            }
            Console.WriteLine();

            ArrayList list2 = new ArrayList() {
            101,"Om","Pune",422012
            };

            list2.Insert(1, "Yash");
            foreach (var i in list2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            list.InsertRange(1, list2);
            foreach (var b in list)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine();

            var list3 = new ArrayList() {
            45,"Rohit","Mumbai","Batsman",45,"Mumbai",123
            };
            list3.Remove(45);
            list3.RemoveAt(1);
            list3.RemoveRange(4, 1);
            foreach (var i in list3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            bool isPresent= list3.Contains("Rohit");
            Console.WriteLine(isPresent);
            Console.WriteLine();

            ArrayList cloneArray = (ArrayList)list3.Clone();
            foreach (var i in cloneArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine();

            //coping arraylist in array using CopyTO()method.

            object[] arr = new object[list3.Count];
            list3.CopyTo(arr);
            foreach (var i in arr) { 
                Console.WriteLine(i);
            }

        }
    }
}
*/