using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача. Дана очередь имён удалить из списка третий элемент и вывести удалённый элемент на консоль
            Queue<string> names = new Queue<string>();
            names.Enqueue("Алина");
            names.Enqueue("Даня");
            names.Enqueue("Маша");
            names.Enqueue("Дима");
            names.Enqueue("Ирина");

            // Удаление третьего элемента
            names.Dequeue();
            names.Dequeue();
            string nameDelete = names.Dequeue();

            // Вывод элементов после удаления
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"Удалённое имя: {nameDelete}");
            Console.ReadKey();
            //очередь устроена так что мы не можем удалить какой-то элемент по середине очереди
            //не удалив элементы до него
        }
    }
}
