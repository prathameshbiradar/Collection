//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Collection
//{
//    public class Dictionary1
//    {
//        public static void Main(String[] args)
//        {
//            Dictionary<int, String> dict = new Dictionary<int, String>();

//            dict.Add(1, "A");
//            dict.Add(2, "B");
//            dict.Add(3, "C");
//            dict.Add(4, "D");
//            dict.Add(5, "E");

//            for (int i = 0; i < dict.Count; i++)
//            {
//                Console.WriteLine("{0} and {1}", dict.Keys.ElementAt(i), dict[dict.Keys.ElementAt(i)]);
//            }
//            Console.WriteLine("Element is {0}", dict[1]);

//            foreach (KeyValuePair<int, String> el1 in dict)
//            {
//                Console.WriteLine("{0} and {1}", el1.Key, el1.Value);
//            }

//            Dictionary<String, String> dict2 = new Dictionary<String, String>()
//            {
//                { "a","Rohit"},
//                { "b","Virat"},
//                { "c","Dhoni"},
//                { "d","Sachin"}
//            };
//            foreach (KeyValuePair<String, String> el1 in dict2)
//            {
//                Console.WriteLine("{0} and {1}", el1.Key, el1.Value);
//            }
//            dict.Remove(3);
//            dict2.Remove("c");
//            foreach (KeyValuePair<int, String> el1 in dict)
//            {
//                Console.WriteLine("{0} and {1}", el1.Key, el1.Value);

//            }
//            foreach (KeyValuePair<String, String> el1 in dict2)
//            {
//                Console.WriteLine("{0} and {1}", el1.Key, el1.Value);
//            }

//        }
//    }
//}
