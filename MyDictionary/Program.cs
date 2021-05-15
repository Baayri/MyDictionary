using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "elma");
            myDictionary.Add(1, "armut");
            myDictionary.Add(1, "karpuz");
        }
    }
}
