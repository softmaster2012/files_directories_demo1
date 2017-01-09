using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace files_directories_demo1
{
    class Menu
    {
        int choice;
        string answer;

        public int Choice
        {
            get { return choice; }
        }

        public void Start()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t =======================================");
            Console.WriteLine("\t  Консольный менеджер файловых операций");
            Console.WriteLine("\t =======================================");
            Console.WriteLine("\t     1 - Создание каталога");
            Console.WriteLine("\t     2 - Удаление каталога");
            Console.WriteLine("\t     3 - Создание файла");
            Console.WriteLine("\t     4 - Удаление файла");
            Console.WriteLine("\t     5 - Сканирование каталога");
            Console.WriteLine("\t     7 - Выход из программы");
            Console.WriteLine("\t =======================================");
            Console.WriteLine();

            Console.Write("\n> Выберите нужное действие: ");
            choice = Convert.ToInt32(Console.ReadLine());
        }
        
        public bool AllowContinue()
        {
            Console.Write("\n> Еще (y/n)? - ");
            answer = Console.ReadLine();
            return (answer == "y");
        }

        public void Finish()
        {
            Console.WriteLine("\n\nРабота программы завершена");
        }
    }
}
