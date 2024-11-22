﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KörHenger
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. példány
            Kör k1 = new Kör();
            k1.SetSugar(15);
            k1.SetTerület();
            k1.SetKerület();

            // kiír(k1);

            // 2. példány
            Kör k2 = new Kör(58);
            k2.SetKerület();
            k2.SetTerület();

            // kiír(k2);

            // 1. henger
            Henger h1 = new Henger(15, 34);
            kiírHenger(h1);

            Console.ReadKey();
        }

        private static void kiír(Kör k)
        {
            Console.WriteLine($"A {k.GetSugár()} sugarú kör kerülete: {k.GetKerület()}, területe: {k.GetTerület()}.");
        }

        private static void kiírHenger(Henger k)
        {
            Console.WriteLine($"A {k.GetSugár()} sugarú henger kerülete: {k.GetKerület()}, területe: {k.GetTerület()}, térfogata: {k.GetTérfogat()}.");
        }

    }
}