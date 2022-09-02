using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_02._09._2022_ {
    class Program {
        static void PrintRed(string text) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }


        static void PrintBlue(string text) {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void PrintGreen(string text) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void MainMethod(int zzz, Action<string> delPrint) {
            zzz *= zzz;
            delPrint(zzz.ToString());
        }
        static void Main(string[] args) {
            MainMethod(2, PrintRed);
            MainMethod(2, PrintBlue);
            MainMethod(2, PrintGreen);

            SuperClass<int, int> a = new SuperClass<int, int>();
            SuperClass<string, List<int>> b = new SuperClass<string, List<int>>();

            Console.WriteLine();
        }
    } 
}