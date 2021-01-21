using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
           
            MyDictionary<int, string> myDictionary = new MyDictionary.MyDictionary<int, string>();
            myDictionary.Add(10, "Buket");
            myDictionary.Add(15, "Ceylin");
            myDictionary.Add(20, "Bertan");
            myDictionary.Add(25, "Gülsevim");
            myDictionary.Add(30, "Bülent");

            myDictionary.ListAllValue();
            Console.WriteLine("********");
            myDictionary.ListValueByKey(20);
            myDictionary.ListValueByKey(10);
        }
    }
}
