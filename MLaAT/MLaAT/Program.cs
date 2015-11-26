using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLaAT
{
    class Program
    {
        class Node
        {
            public int[] Operation { get; set; }
            public Node[] Vars { get; set; }
        }

        static void Main(string[] args)
        {
            do_one_batch();
        }

        static void do_one_batch()
        {
            string a = "((A + (B + C) + (D + E) + F) + G) + H";
                //Console.ReadLine();
            a = a.ToUpper();
            a = проверка_скобок(a);
            int z = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '(')
                {
                    z++;
                }
            }

            
            //for(int k = z; k >= 0; k--)
            //{
                обход(a, -1);
           // }

                Console.ReadKey();
        }

        static string проверка_скобок(string a)
        {
            int z = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '(')
                {
                    z++;
                }
                if (a[i] == ')')
                {
                    z--;
                }
            }
            if (z > 0)
            {
                for(int i = 0; i < z; i++)
                {
                    a = a + ')';
                }
            }
            if (z < 0)
            {
                for (int i = z; i < 0; i++)
                {
                    a = '(' + a;
                }
            }
            Console.WriteLine(a);
            return a;
        }

        static string обход(string a, int k)
        {
            string b = "", c = "";
            int tmp = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '(')
                {
                    tmp++;
                }
                if (tmp == k + 1)
                {
                    b += a[i];
                }
                if (tmp == k)
                {
                    c += a[i];
                }
                if (a[i] == ')')
                {
                    tmp--;
                }
                if (tmp == k)
                {
                }
            }
            if (b.Length > 0)
            {
                Console.WriteLine("Глубина: " + (k + 1));
                Console.WriteLine(b);
                обход(a, k + 1);
            }
            //Console.WriteLine(c);
            return b;
        }
    }
}
