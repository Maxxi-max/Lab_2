// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System.Reflection;

namespace Lab_1
{
    class Program
    {
        static void PrintDir(string dirName)
        {

            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Подкатологи:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
            else { Console.WriteLine("Директории не существует"); }
        }
        static void DeleteFile(string pathD)
        {
            FileInfo fileInf = new FileInfo(pathD);
            if (fileInf.Exists)
            {
                fileInf.Delete();
                Console.WriteLine("Файл удалён");
            }
            else
            {
                Console.WriteLine("Файл не найден");
            }
        }
        static void DeleteDir(string dirNameD)
        {
            if (Directory.Exists(dirNameD))
            {
                Directory.Delete(dirNameD, true);
                Console.WriteLine("Директория удалена");
            }
            else
            {
                Console.WriteLine("Директория не найдена");
            }
        }
        static void CopyDir(string dirNameC, string newDirC, bool recursive)
        {
            var dir = new DirectoryInfo(dirNameC);
            // Подумать
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Исходная папка не найдена: {dir.FullName}");
            DirectoryInfo[] dirs = dir.GetDirectories();
            Directory.CreateDirectory(newDirC);
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(newDirC, file.Name);
                file.CopyTo(targetFilePath);
            }
            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(newDirC, subDir.Name);
                    CopyDir(subDir.FullName, newDestinationDir, true);
                }
            }
            Console.WriteLine("Копирование успешно");
        }
        // Подумать
        static void CopyFile(string pathC, string newpathC, bool overwriting)
        {
            FileInfo fileInf = new FileInfo(pathC);
            if (fileInf.Exists)
            {
                fileInf.CopyTo(newpathC, overwriting);
                if (overwriting)
                {
                    Console.WriteLine("Файл перезаписан");
                }
                else
                {
                    Console.WriteLine("Файл уже существует");
                }
            }
            else
            {
                Console.WriteLine("Файла не существует");
            }
        }
        static void MoveFile(string pathM, string newpathM)
        {
            FileInfo fileInf = new FileInfo(pathM);
            if (fileInf.Exists)
            {
                fileInf.MoveTo(newpathM);
                Console.WriteLine("Файл перемещен");
            }
            else
            {
                Console.WriteLine("Файл не перемещен");
            }
        }
        static void MoveDir(string dirNameM, string newDirM)
        {
            DirectoryInfo dirInf = new DirectoryInfo(dirNameM);
            if (dirInf.Exists && !Directory.Exists(newDirM))
            {
                dirInf.MoveTo(newDirM);
                Console.WriteLine("Директория перемещена");
            }
            else
            {
                Console.WriteLine("Директория не перемещена");
            }
        }
        static void Search(string searchDir, string fileName)
        {
            foreach (string findedFile in Directory.EnumerateFiles(searchDir, fileName, SearchOption.AllDirectories))
            {
                FileInfo FI;
                try
                {
                    FI = new FileInfo(findedFile);
                    Console.WriteLine(FI.Name + " " + FI.FullName + " " + FI.Length + "_байт" + " Создан:" + FI.CreationTime);
                }
                catch
                {
                    continue;
                }
            }
        }
        static void Main()
        {
            Console.WriteLine("Введите совершаемую операцию: Read, Search, Copy F, Copy D, Move F, Move D, Delete F, Delete D");
            string op = Console.ReadLine();
            switch (op)
            {
                case "Read":
                    Console.WriteLine("Введите путь директории");
                    string dirName = Console.ReadLine();
                    PrintDir(dirName);
                    return;
                case "Search":
                    Console.WriteLine("Введите путь директории");
                    string searchDir = Console.ReadLine();
                    Console.WriteLine("Введите имя файла");
                    string fileName = Console.ReadLine();
                    Search(searchDir, fileName);
                    break;
                case "Copy F":
                    Console.WriteLine("Введите путь исходного файла");
                    string pathC = Console.ReadLine();
                    Console.WriteLine("Введите путь нового файла");
                    string newpathC = Console.ReadLine();
                    bool overwriting = true;
                    CopyFile(pathC, newpathC, overwriting);
                    break;
                case "Copy D":
                    Console.WriteLine("Введите путь исходной директории");
                    string dirNameC = Console.ReadLine();
                    Console.WriteLine("Введите путь новой директории");
                    string newDirC = Console.ReadLine();
                    bool recursive = true;
                    CopyDir(dirNameC, newDirC, recursive);
                    break;
                case "Move F":
                    Console.WriteLine("Введите путь исходного файла");
                    string pathM = Console.ReadLine();
                    Console.WriteLine("Введите путь нового файла");
                    string newpathM = Console.ReadLine();
                    MoveFile(pathM, newpathM);
                    break;
                case "Move D":
                    Console.WriteLine("Введите путь исходной директории");
                    string dirNameM = Console.ReadLine();
                    Console.WriteLine("Введите путь новой директории");
                    string newDirM = Console.ReadLine();
                    MoveDir(dirNameM, newDirM);
                    break;
                case "Delete F":
                    Console.WriteLine("Введите путь исходного файла");
                    string pathD = Console.ReadLine();
                    DeleteFile(pathD);
                    break;
                case "Delete D":
                    Console.WriteLine("Введите путь исходной директории");
                    string dirNameD = Console.ReadLine();
                    DeleteDir(dirNameD);
                    break;
            }
        }

    }
}
