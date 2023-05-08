using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{//dictionary : dictionary is generic collection that consist of element.
    //as key value pair.
    //it is not sorted order.
    public class DictionaryProblem
    {
        Dictionary<String, String> dict = new Dictionary<string, string>();
        public void DictionaryMethod()
        {
            dict.Add("1", "sunny");
            dict.Add("2", "hara");
            dict.Add("3", "hari");
            dict.Add("4", "siri");
            Console.WriteLine(dict["3"]);
            Console.WriteLine(dict["4"]);
            //update
            dict["2"] = "sara";
            //remove
            dict.Remove("3");
            foreach (KeyValuePair<String, String> key in dict)
            {
                Console.WriteLine("{0} : {1}", key.Key, key.Value);
            }



            Console.WriteLine("------");
            Dictionary<int, String> dic = new Dictionary<int, String>();
            dic.Add(1, "sweety");
            dic.Add(2, "sony");
            dic[3] = "sunny";
            foreach (KeyValuePair<int, String> kala in dic)
            {
                Console.WriteLine("{0} : {1}", kala.Key, kala.Value);
            }
            if (dict.ContainsKey("2"))
            {
                dict["2"] = "shiva";
            }
            foreach (KeyValuePair<int, String> kala in dic)
            {
                Console.WriteLine("{0} : {1}", kala.Key, kala.Value);
            }
            dict.Clear();

            foreach (KeyValuePair<int, String> kala in dic)
            {
                Console.WriteLine("{0} : {1}", kala.Key, kala.Value);
            }
        }
    }
}
