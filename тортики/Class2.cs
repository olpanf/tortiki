using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PractosNumber5
{
    internal class SubClass
    {
        static string[] form = new string[5] { "  Круг - 300;", "  Квадрат- 200;", "  Треуголькик - 300;", "  Ромб - 500;", "  Звезда- 700;" };
        static string[] size = new string[5] { "  Малый - 300;", "  Средний - 600;", "  Большой- 900;", "  Подарочный - 1200;", "  Свадебный - 2400;" };
        static string[] taste = new string[5] { "  Клубничный - 500;", "  Малиновый - 500;", "  Шоколадный - 300;", "  Ореховый - 150;", "  Сметанный - 50;" };
        static string[] quantity = new string[5] { "  Один - 100;", "  Два - 200;", "  Три - 300;", "  Четыре - 400;", "  Пять - 500;" };
        static string[] glaze = new string[5] { "  Шоколад - 200;", "  Крем - 200;", "  Бизе - 400;", "  Драже - 200;", "  Ягоды - 300;" };
        static string[] decor = new string[5] { "  Праздничный - 500;", "  Глазурный - 300;", "  Сироп - 300;", "  Карамель - 200;", "  Шоколад - 200;" };
        private static int cost;
        private static string text;
        public static int x = 0;
        public static string y = "";
        private static DateTime date;

        public static int DO(int menu, int position, int x, string y, int maxposition, int minposition, ConsoleKey key, DateTime date)
        {
            maxposition = 9;
            minposition = 3;
            bool check = true;
            do
            {
                switch (menu)
                {
                    case 1:
                        Program.Menu(x, y);
                        break;
                    case 2:
                        Console.Clear();
                        SubMenu(menu, key, position, maxposition, minposition);
                        break;
                    case 3:
                        Console.Clear();
                        SubMenu(menu, key, position, maxposition, minposition);
                        break;
                    case 4:
                        Console.Clear();
                        SubMenu(menu, key, position, maxposition, minposition);
                        break;
                    case 5:
                        Console.Clear();
                        SubMenu(menu, key, position, maxposition, minposition);
                        break;
                    case 6:
                        Console.Clear();
                        SubMenu(menu, key, position, maxposition, minposition);
                        break;
                    case 7:
                        Console.Clear();
                        SubMenu(menu, key, position, maxposition, minposition);
                        break;
                }
                Program.WriteCursor(position);
                key = Console.ReadKey().Key;
                position = Program.CursorPosition(position, maxposition, minposition, key);
                if (key == ConsoleKey.Backspace)
                {
                    Console.Clear();
                }
                switch (menu)
                {
                    case 1:
                        switch (key)
                        {
                            case ConsoleKey.Enter:
                                switch (position)
                                {
                                    case 3:
                                        position = 0;
                                        minposition = 0;
                                        maxposition = 4;
                                        menu = 2;
                                        break;
                                    case 4:
                                        position = 0;
                                        minposition = 0;
                                        maxposition = 4;
                                        menu = 3;
                                        break;
                                    case 5:
                                        position = 0;
                                        minposition = 0;
                                        maxposition = 4;
                                        menu = 4;
                                        break;
                                    case 6:
                                        position = 0;
                                        minposition = 0;
                                        maxposition = 4;
                                        menu = 5;
                                        break;
                                    case 7:
                                        position = 0;
                                        minposition = 0;
                                        maxposition = 4;
                                        menu = 6;
                                        break;
                                    case 8:
                                        position = 0;
                                        minposition = 0;
                                        maxposition = 4;
                                        menu = 7;
                                        break;
                                    case 9:
                                        date = DateTime.Now;
                                        Console.Clear();
                                        Console.WriteLine("Спасибо что выбрали нас!!!");
                                        File.AppendAllText("C:\\Users\\JolyGenious\\source\\repos\\PractosNumber5\\PractosNumber5\\История_заказов.txt", $"Время заказа {date}\r\n Цена: {x}\r\n Состав заказа: {y}\r\n");
                                        x = 0;
                                        y = "";
                                        SubClass.x = 0;
                                        SubClass.y = "";
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                Console.Clear();
                                check = false;
                                Environment.Exit(0);
                                break;
                        }
                        break;
                }
            } while (check);
            return menu;
        }
        private static void SubMenu(int menu, ConsoleKey key, int position, int maxposition, int minposition)
        {
            cost = 0;
            text = "";
            bool check = true;
            do
            {
                switch (menu)
                {
                    case 2:
                        Console.WriteLine(form[0]);
                        Console.WriteLine(form[1]);
                        Console.WriteLine(form[2]);
                        Console.WriteLine(form[3]);
                        Console.WriteLine(form[4]);
                        Program.WriteCursor(position);
                        key = Console.ReadKey().Key;
                        position = Program.CursorPosition(position, maxposition, minposition, key);
                        switch (key)
                        {
                            case ConsoleKey.Enter:
                                switch (position)
                                {
                                    case 0:
                                        text = form[0];
                                        cost = 300;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 1:
                                        text = form[1];
                                        cost = 200;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 2:
                                        text = form[2];
                                        cost = 300;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 3:
                                        text = form[3];
                                        cost = 500;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 4:
                                        text = form[4];
                                        cost = 700;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                position = 3;
                                Console.Clear();
                                menu = 1;
                                DO(menu, position, x, y, maxposition, minposition, key, date);
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine(size[0]);
                        Console.WriteLine(size[1]);
                        Console.WriteLine(size[2]);
                        Console.WriteLine(size[3]);
                        Console.WriteLine(size[4]);
                        Program.WriteCursor(position);
                        key = Console.ReadKey().Key;
                        position = Program.CursorPosition(position, maxposition, minposition, key);
                        switch (key)
                        {
                            case ConsoleKey.Enter:
                                switch (position)
                                {
                                    case 0:
                                        text = size[0];
                                        cost = 300;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 1:
                                        text = size[1];
                                        cost = 600;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 2:
                                        text = size[2];
                                        cost = 900;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 3:
                                        text = size[3];
                                        cost = 1200;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 4:
                                        text = size[4];
                                        cost = 2400;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                position = 4;
                                Console.Clear();
                                menu = 1;
                                DO(menu, position, x, y, maxposition, minposition, key, date);
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine(taste[0]);
                        Console.WriteLine(taste[1]);
                        Console.WriteLine(taste[2]);
                        Console.WriteLine(taste[3]);
                        Console.WriteLine(taste[4]);
                        Program.WriteCursor(position);
                        key = Console.ReadKey().Key;
                        position = Program.CursorPosition(position, maxposition, minposition, key);
                        switch (key)
                        {
                            case ConsoleKey.Enter:
                                switch (position)
                                {
                                    case 0:
                                        text = taste[0];
                                        cost = 500;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 1:
                                        text = taste[1];
                                        cost = 500;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 2:
                                        text = taste[2];
                                        cost = 300;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 3:
                                        text = taste[3];
                                        cost = 150;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 4:
                                        text = taste[4];
                                        cost = 50;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                position = 5;
                                Console.Clear();
                                menu = 1;
                                DO(menu, position, x, y, maxposition, minposition, key, date);
                                break;
                        }
                        break;
                    case 5:
                        Console.WriteLine(quantity[0]);
                        Console.WriteLine(quantity[1]);
                        Console.WriteLine(quantity[2]);
                        Console.WriteLine(quantity[3]);
                        Console.WriteLine(quantity[4]);
                        Program.WriteCursor(position);
                        key = Console.ReadKey().Key;
                        position = Program.CursorPosition(position, maxposition, minposition, key);
                        switch (key)
                        {
                            case ConsoleKey.Enter:
                                switch (position)
                                {
                                    case 0:
                                        text = quantity[0];
                                        cost = 100;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 1:
                                        text = quantity[1];
                                        cost = 200;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 2:
                                        text = quantity[2];
                                        cost = 300;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 3:
                                        text = quantity[3];
                                        cost = 400;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 4:
                                        text = quantity[4];
                                        cost = 500;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                position = 6;
                                Console.Clear();
                                menu = 1;
                                DO(menu, position, x, y, maxposition, minposition, key, date);
                                break;
                        }
                        break;
                    case 6:
                        Console.WriteLine(glaze[0]);
                        Console.WriteLine(glaze[1]);
                        Console.WriteLine(glaze[2]);
                        Console.WriteLine(glaze[3]);
                        Console.WriteLine(glaze[4]);
                        Program.WriteCursor(position);
                        key = Console.ReadKey().Key;
                        position = Program.CursorPosition(position, maxposition, minposition, key);
                        switch (key)
                        {
                            case ConsoleKey.Enter:
                                switch (position)
                                {
                                    case 0:
                                        text = glaze[0];
                                        cost = 200;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 1:
                                        text = glaze[1];
                                        cost = 200;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 2:
                                        text = glaze[2];
                                        cost = 400;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 3:
                                        text = glaze[3];
                                        cost = 200;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 4:
                                        text = glaze[4];
                                        cost = 300;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                position = 7;
                                Console.Clear();
                                menu = 1;
                                DO(menu, position, x, y, maxposition, minposition, key, date);
                                break;
                        }
                        break;
                    case 7:
                        Console.WriteLine(decor[0]);
                        Console.WriteLine(decor[1]);
                        Console.WriteLine(decor[2]);
                        Console.WriteLine(decor[3]);
                        Console.WriteLine(decor[4]);
                        Program.WriteCursor(position);
                        key = Console.ReadKey().Key;
                        position = Program.CursorPosition(position, maxposition, minposition, key);
                        switch (key)
                        {
                            case ConsoleKey.Enter:
                                switch (position)
                                {
                                    case 0:
                                        text = decor[0];
                                        cost = 500;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 1:
                                        text = decor[1];
                                        cost = 300;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 2:
                                        text = decor[2];
                                        cost = 300;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 3:
                                        text = decor[3];
                                        cost = 200;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 4:
                                        text = decor[4];
                                        cost = 200;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                position = 8;
                                Console.Clear();
                                menu = 1;
                                DO(menu, position, x, y, maxposition, minposition, key, date);
                                break;
                        }
                        break;
                }
            } while (check);
        }
        private static int Cost()
        {
            x = x + cost;
            return x;
        }
        private static string Text()
        {
            y = y + text;
            return y;
        }
        private static void Returned(int menu, int position, int maxposition, int minposition, ConsoleKey key, DateTime date)
        {
            Cost();
            Text();
            position = 3;
            Console.Clear();
            menu = 1;
            DO(menu, position, x, y, maxposition, minposition, key, date);
        }

    }
}

