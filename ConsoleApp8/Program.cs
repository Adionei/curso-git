using System;
using System.Collections.Generic;

namespace ConsoleApp8 {
    class Program {
        static void Main(string[] args) {
            List<string> list = new List<string> {"primeiro", "segundo", "terceirodd"};
            
            Console.WriteLine(list[1]);
            string pos1 = list.Find(x => x.Length == 10);
            Console.WriteLine(pos1);
           
        }
    }
}
