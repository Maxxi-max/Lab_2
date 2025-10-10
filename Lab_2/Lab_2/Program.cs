// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Lab_2;

namespace Lab_2
{
    public class Program
    {

            public static void Main()
            {
                ESCD e = new ESCD();
            Console.Write("Задайте диаметр отверстия: ");
            e.Diam = float.Parse(Console.ReadLine());
            Console.Write("Задайте диаметр вала: ");
            e.diam = float.Parse(Console.ReadLine());
            Console.Write("Задайте максимальное отклонение D: ");
            e.ES = float.Parse(Console.ReadLine());
            Console.Write("Задайте минимальное отклонение D: ");
            e.EI = float.Parse(Console.ReadLine());
            Console.Write("Задайте максимальное отклонение d: ");
            e.es = float.Parse(Console.ReadLine());
            Console.Write("Задайте минимальное отклонение d: ");
            e.ei = float.Parse(Console.ReadLine());
                e.PrintDmax();
                e.PrintDmin();
                e.Printdmax();
                e.Printdmin(); 
                e.PrintTD();
                e.Printtd();
                e.PrintPosad();
            }
        }
    }
