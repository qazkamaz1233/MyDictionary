﻿using System;

namespace examen.Menus
{
    public static class ConsoleReadHelper
    {
        public static int ReadInt(string message, int from, int to)
        {
            while (true)
            {
                Console.Write(message);

                if (!int.TryParse(Console.ReadLine(), out var value))
                {
                    Console.WriteLine("Введено некорректное число, повторите ввод");
                    continue;
                }

                if (from > value || value > to)
                {
                    Console.WriteLine($"Введенное число должно быть в диапазоне от {from} до {to}, повторите ввод");
                    continue;
                }

                return value;
            }
        }
    }
}
