using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создание стека
            Stack<string> name = new Stack<string>();   //также в скобках можно указать размерность стека

            //так же как и в очереди в стек можно добавть  элементы используя List
            List<string> list = new List<string>() { "Ванёк","Серёга","Вован","Димон"}; //создаём лист с именами
            Stack<string> stack = new Stack<string>(list);//заполняем стек имена из листа
            foreach(string s in stack)//перебираем стек
            {
                Console.WriteLine(s);//выводим на консоль
            }
            Console.WriteLine();


            //добавление в коллекцию
            stack.Push("Маша");
            foreach(string s in stack)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();


            //Получение элемента из стека
          
            string el = stack.Peek();
            Console.WriteLine(el);
            Console.WriteLine();

            //удаление элемента из стека
            string delete = stack.Pop();//удаляем первый элемент
            foreach (var item in stack)
            {
                Console.WriteLine(item); //выводим оставшийся список
            }
            Console.WriteLine();
            Console.WriteLine($"Удалённый элемент из стека: {delete}");
            //для удаления например третьего элемента в стеке, как и в очереди необходимо удалить все элементы перед ним!!!
            Console.ReadKey();
        }
    }
}
