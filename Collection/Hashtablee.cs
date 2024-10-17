//using System;
//using System.Collections;
//using System.Linq;
//using System.Security.Cryptography;
//using System.Text;
//using System.Threading.Tasks;

//namespace Collection
//{
//    public class Hashtablee
//    {
//        public static void Main(String[] args)
//        {
//            Hashtable ht = new Hashtable();

//            ht.Add(1, "Aniket");
//            ht.Add(2, 111);
//            ht.Add(3, 4);

//            ht.Remove(2);

//            foreach (DictionaryEntry e1 in ht)
//            {
//                Console.WriteLine("Key and value is: {0} and {1}", e1.Key, e1.Value);
//            }
//            Console.WriteLine("The total elements in the hashtable are:{0} " + ht.Count);
//            //ht.Clear();
//            //Console.WriteLine("The total elements in the hashtable are:{0} " + ht.Count);

//            Console.WriteLine(ht.Contains(1));
//            Console.WriteLine("Is hash table contains key : {0}", ht.Contains(2));
//            Console.WriteLine(ht.ContainsKey(1));
//            Console.WriteLine(ht.ContainsValue("Pune"));


//            if (ht.ContainsKey(3))
//            {
//                ht[3] = "Pranav";
//            }
//            String name = (String)(ht[3]);
//            foreach (DictionaryEntry e1 in ht)
//            {
//                Console.WriteLine("Key and value is: {0} and {1}", e1.Key, e1.Value);
//            }


//            String name1 = (String)ht[1];
//            Console.WriteLine(name1);
//            ht[1] = "Rohit";
//            foreach (DictionaryEntry e1 in ht)
//            {
//                Console.WriteLine("Key and value is: {0} and {1}", e1.Key, e1.Value);
//            }



//            //Hashtable ht1 = new Hashtable() {
//            //    {"a",111 },
//            //    { "b",112},
//            //    { "c",113 },
//            //    { "d",null}
//            //};
//            //foreach (var e1 in ht1.Keys)
//            //{
//            //    Console.WriteLine("{0} and {1}", e1, ht1[e1]);
//            //}


//        }


//    }
//}
