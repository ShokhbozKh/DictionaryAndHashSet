using System.Collections.Generic;


namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();//key qiymatlari takror yozilsa olinmaydi

            //
            keyValuePairs.Add(1, "shohboz");
            keyValuePairs.Add(2,"shoxrux");
            keyValuePairs.Add(3, "jaga");
            keyValuePairs.Add(3, "jaga");// kompilyatsiyada xato beradi


            foreach(KeyValuePair<int,string> i in keyValuePairs)
            {
                Console.WriteLine(i.Key +" " + i.Value);
            }

            HashSet<string> keys = new HashSet<string>();//Faqat bir marta takrorlanganlarni oladi qayta yozilganlar olinmaydi
            keys.Add("1");
            keys.Add("2");
            keys.Add("2");
            keys.Add("3");
            keys.Add("4");
            foreach(string key in keys)
            {
                Console.WriteLine(key);
            }




        }
       
    }    
}