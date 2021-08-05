using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary1 = new MyDictionary<int, string>();
            myDictionary1.Add(1, "Mervenur");

            MyDictionary<int, string> myDictionary2 = new MyDictionary<int, string>();
            myDictionary2.Add(2, "Ayşenur:)");
        } 
    }
}
