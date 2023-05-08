using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    //Dictionary : Dictionary is a generic collection that consist of element.
    //As Key Value Pair.
    //It is not Sorted Order.
    public class DictionaryExample
    {
        Dictionary <string,string> dictionary = new Dictionary<string, string>();
        public void DictMethod()
        {
            dictionary.Add("1","Sagar");
            dictionary.Add("2","Shahu");
            dictionary.Add("3","Shreya Maam");
            dictionary.Add("4","Krishna");
            Console.WriteLine(dictionary["3"]);
            Console.WriteLine(dictionary["4"]);
            //  Console.WriteLine(dictionary["Sagar"]);
            // Console.WriteLine(dictionary["Shahu"]);
            //Modify By using Key.
            dictionary["2"] = "Pankaj";
            //Print the Dictionary.
          foreach(KeyValuePair<string,string> key in dictionary) 
          {
                Console.WriteLine("{0} : {1}",key.Key,key.Value);
          }

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Arivu");
            dict.Add(2, "Surya");
            dict[3] = "ABCD";
            //Remove the value.
            dict.Remove(3);
            foreach(KeyValuePair<int,string> kv in dict)
            {
                Console.WriteLine("{0} : {1}", kv.Key, kv.Value);
            }
            if (dict.ContainsKey(2))
            {
                dict[2] = "Abhishek";
            }
            foreach (KeyValuePair<int, string> kv in dict)
            {
                Console.WriteLine("{0} : {1}", kv.Key, kv.Value);
            }
            //Clear method is use to clear the dictionary.
            dict.Clear();
            foreach (KeyValuePair<int, string> kv in dict)
            {
                Console.WriteLine("{0} : {1}", kv.Key, kv.Value);
            }



        }
    }
}
