using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _01.Helloworld
{
    class Program
    {

        static int add(int a, int b)
        {
            int ret = a + b;
            Program.Print(ret);
            return ret;
        } //1

        static void Print(int value)
        {
            WriteLine(value);
        } //1
        static void Main(string[] args)
        {

            /* sbyte a = -10;
             byte b = 40;

             WriteLine($"a={a}, b = {b}");

             short c = -30000;
             ushort d = 60000;

             WriteLine($"c={c}, d={d}");
             int e = -1000_0000;
             uint f = 3_0000_0000;

             WriteLine($"e ={e}, f={f}");

             long g = -5000_0000_0000;
             ulong h = 200_0000_0000_0000;

             WriteLine($"g = {g}, h={h}");*/

            /*uint a = uint.MaxValue;
            WriteLine(a);
            a = a + 1;
            WriteLine(a);*/

            /*float a = 3.1415_9265_3589_7932_3846f;
            WriteLine(a);*/

            /* int a = 123;
             Object b = (object)a;
             int c = (int)b;

             WriteLine(a);
             WriteLine(b);
             WriteLine(c);

             double x = 3.1414213;
             object y = x;
             object z = (double)y;

             WriteLine(x);
             WriteLine(y);
             WriteLine(z);*/

            /*sbyte a = 127;
            WriteLine(a);
            int b = (int)a;
            WriteLine(b);

            int x = 128;
            WriteLine(x);

            sbyte y = (sbyte)x;
            WriteLine(y);*/

            /*float a = 0.9f;
            int b = (int)a;
            WriteLine(b);

            float c = 1.6f; //무조건 버림
            int d = (int)c;
            WriteLine(d);*/

            /*int a = 123;
            string b = a.ToString();
            WriteLine(b);

            float c = 3.14f;
            string d = c.ToString();
            WriteLine(d);

            string e = "123456";
            int f = Convert.ToInt32(e);
            WriteLine(f);

            string g = "1.2345";
            float h = float.Parse(g);
            WriteLine(h);*/


            int ret = Program.add(10, 20);
            WriteLine(ret); //1
            

        }
    }
}
