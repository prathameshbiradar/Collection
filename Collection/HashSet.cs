//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Collection
//{
//    public class HashSet
//    {
//        public static void Main(String[] args)
//        {
//            HashSet<String> hs = new HashSet<String>();

//            hs.Add("Rohit");
//            hs.Add("Virat");
//            hs.Add("Aniket");
//            hs.Add("Sanket");
//            hs.Add("Aniket");

//            //Console.WriteLine(hs.Contains("Rohit"));
            
//            foreach (String s in hs)
//            {
//                Console.WriteLine(s + " ");
//            }
//            Console.WriteLine();

//            hs.Remove("Aniket");
//            foreach (var s in hs)
//            {
//                Console.WriteLine(s + " ");
//            }
//            Console.WriteLine();
//            Console.WriteLine("The length of the Hash set is: " + hs.Count);
//            Console.WriteLine();
//            //hs.Clear();
//            //Console.WriteLine("The length of the Hash set is: " + hs.Count);
//            //Console.WriteLine();

//            HashSet<String> hs1 = new HashSet<String>() { "10", "20", "30", "40", "Rohit" };
//            //hs.UnionWith(hs1);
//            //foreach (var s in hs)
//            //{
//            //    Console.WriteLine(s + " ");
//            //}
//            //Console.WriteLine();

//            //hs.IntersectWith(hs1);
//            //foreach (var s in hs)
//            //{
//            //    Console.WriteLine(s + " ");
//            //}

//            hs.ExceptWith(hs1);
//            foreach (var s in hs)
//            {
//                Console.WriteLine(s + " ");
//            }
//        }
//    }
//}
