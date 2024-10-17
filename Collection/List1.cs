using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class List1
    {
        public static void Main(String[] args)
        {
            List<int> li = new List<int>();
            li.Add(1);
            li.Add(2);
            li.Add(3);
            li.Add(4);
            li.Add(6);
            li.Add(8);
            li.Add(5);
            li.Add(7);
            li.Remove(3);
            li.RemoveAt(2);
            li.RemoveRange(0,2);
            foreach (var a in li)
            { 
                Console.Write(a+" ");
            }
            Console.WriteLine();
            li.Sort();
            foreach (var a in li)
            {
                Console.Write(" "+a);
            }
            Console.WriteLine();

        }
    }
}
