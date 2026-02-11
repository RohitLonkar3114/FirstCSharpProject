using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharpProject
{
    internal class Program
    {
        public void Add()
        {
            int a, b, c;
            a = 20;
            b = 10;
            c = a + b;
            Console.WriteLine("Addition = "+c);
        }
        public void Mul()
        {
            int a, b, c;
            a = 20;
            b = 10;
            c = a * b;
            Console.WriteLine("Multiplication = "+c);
        }
        static void Main(string[] args)
        {
            Program p=new Program();
            p.Add();
            p.Mul();
            Console.ReadLine();
        }
    }
}
