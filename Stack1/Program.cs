using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Заполнить стек случайными числами. Вывести порядковый номер каждого элемента и вывести значение каждого элемента.
            Random rnd = new Random();
            Stack<int> s = new Stack<int>();
            for (int i = 0; i < 5; i++)
            {
                int a = rnd.Next(0,10);
                s.Push(a);
            }

            int c = 1;
            foreach (int i in s)
            {
                Console.WriteLine($"Элемент под номером {c} = {i}");
                c++;
            }
            Console.ReadKey();

        }

    }
}
