using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Иван", "Петр", "Мария", "Екатерина", "Алексей" };
            Queue<string> queue = new Queue<string>();

            
            Random random = new Random();

            // Заполнение очереди рандомными именами из массива
            for (int i = 0; i < 2; i++)
            {
                int index = random.Next(names.Length); // Генерация случайного индекса
                queue.Enqueue(names[index]); // Добавление случайного имени в очередь
            }

            // Вывод элементов очереди
            foreach (var name in queue)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
