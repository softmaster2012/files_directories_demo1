using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace files_directories_demo1
{
    class FileOperationsManager
    {
        public void CreateFile()
        {
            Console.Write("  Введите путь для создания файла: ");
            string path = Console.ReadLine();
            if (File.Exists(path))
                throw new Exception("такой файл уже существует!");
            File.Create(path);
            Console.WriteLine("  Файл {0} - успешно создан",
                Path.GetFullPath(path));
        }

        public void DeleteFile()
        {
            Console.Write("  Введите путь для удаления файла: ");
            string path = Console.ReadLine();
            if (!File.Exists(path))
                throw new Exception("такого файла не существует!");
            File.Delete(path);
            Console.WriteLine("  Файл {0} - успешно удален",
                Path.GetFullPath(path));
        }
    }
}
