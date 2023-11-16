using System.Collections.Generic;

namespace DictionaryGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Dictionary<String,int> Cars = new Dictionary<String,int>();
            //Cars.Add("BMW",1);

            //Console.WriteLine(Cars[key:("BMW")]);
            //Console.WriteLine("----------------------------------------");


            MyDictionary<String,int> myDictionary = new MyDictionary<String,int>();
            myDictionary.Add("Audi",2);
            Console.WriteLine(myDictionary.Length);

            for (int i = 0; i < myDictionary.Length; i++)
            {
                Console.WriteLine("Key : " + myDictionary._Keys[i] +" AND " + "Value : " + myDictionary._Values[i]  );

            }

            



















        }
    }
}