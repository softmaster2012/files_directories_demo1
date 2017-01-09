using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace files_directories_demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu();
            DirectoryOperationsManager m1 = new DirectoryOperationsManager();
            FileOperationsManager m2 = new FileOperationsManager();

            do
            {
                try
                {
                    m.Start();
                    switch (m.Choice)
                    {
                        case 1:
                            m1.CreateDirectory();
                            break;
                        case 2:
                            m1.DeleteDirectory();
                            break;
                        case 3:
                            m2.CreateFile();
                            break;
                        case 4:
                            m2.DeleteFile();
                            break;
                        case 5:
                            m1.DirectoryScan();
                            break;
                        case 7:
                            goto end;
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine("\n> Runtime error: {0}", err.Message);
                }
            }
            while (m.AllowContinue());

            end:
            m.Finish();                        
        }
    }
}
