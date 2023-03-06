using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz27_02
{
    class Num<T>
    {
        private T a;
        private T b;

        public Num(T a, T b)
        {
            this.a = a;
            this.b = b;
        }
        public void Swap()
        {
            T c = a;
            a = b;
            b = c;
        }
        public void Print()
        {
            Console.WriteLine($"a = {a}\nb = {b}");
        }
    }

    internal class Program
    {
        public static T Swap<T>(T a, T b) where T : IComparable<T>
        {
            T c = a;
            a = b;
            b = c;
            return default(T);
        }

        static void Main(string[] args)
        {
            Num<int> num = new Num<int>(1, 5);
            num.Swap();
            num.Print();


        }
    }
}