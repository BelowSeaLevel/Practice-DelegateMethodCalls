using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateMethodCalls
{
    class Program
    {

        delegate void UseDelegateToCallMethods(string a);
        delegate void LetsTryToCalculate(int a, int b);
        delegate void LetsTryStringAndInt(string a, int b);

        static void Main()
        {
            UseDelegateToCallMethods callMethods;

            callMethods = SayHello;
            callMethods("Hello");
            callMethods = SayGoodBye;
            callMethods("Goodbye");

            LetsTryToCalculate callCalculate;
            callCalculate = AddTwo;
            callCalculate += Multiply;
            callCalculate(5, 8);

            LetsTryStringAndInt stringAndInt;
            stringAndInt = StringAndInt;
            stringAndInt("Hey", 88);


            Console.ReadKey();

        }


        static void SayHello(string a)
        {
            Console.WriteLine(a);
        }


        static void SayGoodBye(string a)
        {
            Console.WriteLine("Goodbye");
        }

        static void AddTwo(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        static void StringAndInt(string a, int b)
        {
            Console.WriteLine($"{a} = a string, and {b} = a int");
        }
    }
}
