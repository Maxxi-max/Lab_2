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
            Size otv = new Size("отверстие", 12, 0.04, 0.02);
            Size val = new Size("вал", 12, 0.01, 0.00);
            Connection con = new Connection(otv, val);
            //Console.Write("Задайте диаметр отверстия: ");
            //s.Nominal = float.Parse(Console.ReadLine());
            //Console.Write("Задайте максимальное отклонение d: ");
            //s.ess = float.Parse(Console.ReadLine());
            //Console.Write("Задайте минимальное отклонение d: ");
            //s.eii = float.Parse(Console.ReadLine());
            Console.WriteLine($"Максимальный диаметр: {otv.Dmax()}");
            Console.WriteLine($"Максимальный диаметр: {otv.Dmax()}");
            Console.WriteLine($"Минимальный диаметр: {otv.Dmin()}");
            Console.WriteLine($"Допуск: {otv.TD()}");
            Console.WriteLine($"Максимальный диаметр: {val.Dmax()}");
            Console.WriteLine($"Максимальный диаметр: {val.Dmax()}");
            Console.WriteLine($"Минимальный диаметр: {val.Dmin()}");
            Console.WriteLine($"Допуск: {val.TD()}");
            con.GetInfo();
            Console.WriteLine($"Вероятность появления зазора: {con.ProbabilitySmax()}");
            Console.WriteLine($"Вероятность появления натяга: {con.ProbabilityNmax()}");
        }
    }
}
