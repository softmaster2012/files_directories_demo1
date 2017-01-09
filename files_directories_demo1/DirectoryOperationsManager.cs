using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace files_directories_demo1
{
    class DirectoryOperationsManager
    {
        public void CreateDirectory()
        {
            Console.Write("  Введите путь для создания директории: ");
            string path = Console.ReadLine();
            if (Directory.Exists(path))
                throw new Exception("такая директория уже существует!");
            Directory.CreateDirectory(path);
            Console.WriteLine("  Директория {0} - успешно создана", 
                Path.GetFullPath(path));
        }

        public void DeleteDirectory()
        {
            Console.Write("  Введите путь для удаления директории: ");
            string path = Console.ReadLine();
            if (!Directory.Exists(path))
                throw new Exception("такой директории не существует!");
            Directory.Delete(path);
            Console.WriteLine("  Директория {0} - успешно удалена",
                Path.GetFullPath(path));
        }

        public void DirectoryScan()
        {
            Console.Write("  Введите путь для сканирования директории: ");
            string path = Console.ReadLine();

            DirectoryInfo di = new DirectoryInfo(path);
            if (!di.Exists)
                throw new Exception("такой директории не существует!");

            DirectoryInfo[] dirs = di.GetDirectories();
            FileInfo[] files = di.GetFiles();

            Console.WriteLine("  Найденные директории и файлы:");
            foreach (DirectoryInfo dir in dirs)
                Console.WriteLine("{0, 30}{1, 25}", dir.Name,
                    dir.CreationTime);
            foreach (FileInfo file in files)
                Console.WriteLine("{0, 30}{1, 25}{2, 10} bytes", file.Name,
                    file.CreationTime, file.Length);

            Console.WriteLine();
        }
    }
}
