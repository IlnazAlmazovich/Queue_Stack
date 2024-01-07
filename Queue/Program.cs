using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создание пустой очереди
            // в скобках можно указать размерность очереди, например 24
            Queue<string> name = new Queue<string>();

            //так же в очередь можно передать данные из другой коллекции
            List<string> list = new List<string>() { "Димон", "Маша", "Серёга", "Полина"};
            Queue<string> queue = new Queue<string>(list);//передаём данные из коллекции list в очередь queue
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($" Количество значений в очереди: {queue.Count}");

            Console.WriteLine();

            //Добавление элемента в очередь
            name.Enqueue("Ильназ");
            name.Enqueue("Алмаз");
            name.Enqueue("Вован");
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //получаем элемент
            string name1 = name.Peek();
            Console.WriteLine(name1);

            Console.WriteLine();

            if (name.Count > 0)
            {
                name.Dequeue();
            }
            Console.WriteLine("Удаление:");
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
