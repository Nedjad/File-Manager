using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFileManager
{
    public class FileManagerUI
    {
        public void UI()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.CursorVisible = false;

            Console.SetCursorPosition(1, 1);
            Console.Write("┌");

            for (int i = 0; i < Console.WindowWidth - 4; i++)
            {
                Console.Write("─");
            }

            Console.Write("┐");

            for (int i = 0; i < Console.WindowHeight - 4; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth - 2, i + 2);
                Console.Write("│");
            }

            Console.SetCursorPosition(Console.WindowWidth - 2, Console.WindowHeight - 2);
            Console.Write("┘");

            for (int i = Console.WindowWidth - 3; i > 1; i--)
            {
                Console.SetCursorPosition(i, Console.WindowHeight - 2);
                Console.Write("─");
            }

            Console.SetCursorPosition(1, Console.WindowHeight - 2);
            Console.Write("└");

            for (int i = Console.WindowHeight - 3; i > 1; i--)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("│");
            }

            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, 1);
            Console.Write("┬");

            for (int i = 0; i < Console.WindowHeight - 4; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 1, i + 2);
                Console.Write("│");
            }

            Console.SetCursorPosition(1, 3);
            Console.Write("├");

            for (int i = 1; i < Console.WindowWidth - 2; i++)
            {
                if (i == Console.WindowWidth / 2 - 2)
                {
                    i++;
                }

                Console.Write("─");
            }

            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, 3);
            Console.Write("┼");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight - 2);
            Console.Write("┴");

            Console.SetCursorPosition(Console.WindowWidth - 2, 3);
            Console.Write("┤");

            for (int i = 0; i < Console.WindowWidth - 2; i++)
            {
                Console.SetCursorPosition(1 + i, 5);
                Console.Write("─");
            }

            Console.SetCursorPosition(1, 5);
            Console.Write("├");

            Console.SetCursorPosition(Console.WindowWidth - 2, 5);
            Console.Write("┤");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, 5);
            Console.Write("┼");

            Console.SetCursorPosition(Console.WindowWidth / 2 / 2 - 6, 4);
            Console.Write("│");

            Console.SetCursorPosition(Console.WindowWidth / 2 / 2 - 6, 3);
            Console.Write("┬");

            Console.SetCursorPosition(Console.WindowWidth / 2 / 2 - 6, 5);
            Console.Write("┴");

            Console.SetCursorPosition(3, 4);
            Console.Write("Название");

            Console.SetCursorPosition(Console.WindowWidth / 2 / 2 + 4, 4);
            Console.Write("│");

            Console.SetCursorPosition(Console.WindowWidth / 2 / 2 + 4, 3);
            Console.Write("┬");

            Console.SetCursorPosition(Console.WindowWidth / 2 / 2 + 4, 5);
            Console.Write("┴");

            Console.SetCursorPosition(Console.WindowWidth / 2 / 2 - 4, 4);
            Console.Write("Размер");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 9, 4);
            Console.Write("│");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 9, 3);
            Console.Write("┬");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 9, 5);
            Console.Write("┴");

            Console.SetCursorPosition(Console.WindowWidth / 2 / 2 + 6, 4);
            Console.Write("Дата изменения");

            Console.SetCursorPosition(Console.WindowWidth / 2 - "Тип".Length - 4, 4);
            Console.Write("Тип");

            Console.SetCursorPosition(Console.WindowWidth / 2 + 1, 4);
            Console.Write("Название");

            Console.SetCursorPosition(Console.WindowWidth / 2 + 22, 4);
            Console.Write("│");

            Console.SetCursorPosition(Console.WindowWidth / 2 + 22, 3);
            Console.Write("┬");

            Console.SetCursorPosition(Console.WindowWidth / 2 + 22, 5);
            Console.Write("┴");

            Console.SetCursorPosition(Console.WindowWidth / 2 + 32, 4);
            Console.Write("│");

            Console.SetCursorPosition(Console.WindowWidth / 2 + 32, 3);
            Console.Write("┬");

            Console.SetCursorPosition(Console.WindowWidth / 2 + 32, 5);
            Console.Write("┴");

            Console.SetCursorPosition(Console.WindowWidth / 2 + 24, 4);
            Console.Write("Размер");

            Console.SetCursorPosition(Console.WindowWidth / 2 + 50, 4);
            Console.Write("│");

            Console.SetCursorPosition(Console.WindowWidth / 2 + 50, 3);
            Console.Write("┬");

            Console.SetCursorPosition(Console.WindowWidth / 2 + 50, 5);
            Console.Write("┴");

            Console.SetCursorPosition(Console.WindowWidth / 2 + 34, 4);
            Console.Write("Дата изменения");

            Console.SetCursorPosition(Console.WindowWidth / 2 + 52, 4);
            Console.Write("Тип");

            Console.SetCursorPosition(Console.WindowWidth / 2 / 2 - 2, Console.WindowHeight - 2);
            Console.Write("┬");

            Console.SetCursorPosition(Console.WindowWidth / 2 / 2 - 2, Console.WindowHeight - 1);
            Console.Write("│");

            Console.SetCursorPosition(Console.WindowWidth / 2 / 2 - 2, Console.WindowHeight);
            Console.Write("└");

            for (int i = Console.WindowWidth / 2 / 2 - 1; i < Console.WindowWidth - Console.WindowWidth / 2 / 2; i++)
                Console.Write("─");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 15, Console.WindowHeight - 2);
            Console.Write("┬");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 15, Console.WindowHeight - 1);
            Console.Write("│");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 15, Console.WindowHeight);
            Console.Write("┴");

            Console.SetCursorPosition(Console.WindowWidth - Console.WindowWidth / 2 / 2, Console.WindowHeight - 2);
            Console.Write("┬");

            Console.SetCursorPosition(Console.WindowWidth - Console.WindowWidth / 2 / 2, Console.WindowHeight - 1);
            Console.Write("│");

            Console.SetCursorPosition(Console.WindowWidth - Console.WindowWidth / 2 / 2, Console.WindowHeight);
            Console.Write("┘");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight - 2);
            Console.Write("┼");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight - 1);
            Console.Write("│");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight);
            Console.Write("┴");

            Console.SetCursorPosition(Console.WindowWidth - Console.WindowWidth / 2 / 2 + 1 - 15, Console.WindowHeight - 2);
            Console.Write("┬");

            Console.SetCursorPosition(Console.WindowWidth - Console.WindowWidth / 2 / 2 + 1 - 15, Console.WindowHeight - 1);
            Console.Write("│");

            Console.SetCursorPosition(Console.WindowWidth - Console.WindowWidth / 2 / 2 + 1 - 15, Console.WindowHeight);
            Console.Write("┴");
        }
    }
}
