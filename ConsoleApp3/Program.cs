using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Администрирование кафе";
            int[] table = { 5, 3, 5, 1, 4, 2 };
            bool isOpen = true;

            while (isOpen)
            {
                Console.SetCursorPosition(7, 11);
                Console.WriteLine("Столы");
                for (int i = 0; i < table.Length; i++)
                {
                    Console.WriteLine($"|{(i + 1)} - свободно {table[i]} мест|");
                }

                Console.SetCursorPosition(25, 12);
                Console.WriteLine("1 - Забронированить");

                Console.SetCursorPosition(25, 13);
                Console.WriteLine("2 - Освободить место");

                Console.SetCursorPosition(25, 14);
                Console.WriteLine("3 - Выйти");

                Console.SetCursorPosition(15, 0);
                Console.WriteLine("|Администрирование кафе|");

                Console.Write("\nВведите номер команды: ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.Write("\nВведите стол: ");
                        int userTable = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (table.Length < userTable || userTable < 0)
                        {
                            Console.Write("Некорректное число"); Console.ReadKey(); Console.Clear();
                            break;
                        }

                        Console.Write("\nВведите количество мест для брони: ");
                        int userPlase = Convert.ToInt32(Console.ReadLine());

                        if (table[userTable] < userPlase || userPlase < 0)
                        {
                            Console.Write("Недостаточно мест"); Console.ReadKey(); Console.Clear();
                            break;
                        }

                        table[userTable] -= userPlase; Console.Clear();
                        break;

                    case 2:
                        Console.Write("\nВведите стол: ");
                        userTable = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (table.Length < userTable || userTable < 0)
                        {
                            Console.Write("Некорректное число"); Console.ReadKey(); Console.Clear();
                            break;
                        }

                        Console.Write("\nВведите количество освободившихся мест: ");
                        userPlase = Convert.ToInt32(Console.ReadLine());

                        if (table[userTable] < userPlase || userPlase < 0)
                        {
                            Console.Write("Некорректное число"); Console.ReadKey(); Console.Clear();
                            break;
                        }

                        table[userTable] += userPlase; Console.Clear();
                        break;

                    case 3:
                        isOpen = false;
                        break;
                    default:
                        Console.Write("\nНеизвестная команда"); Console.ReadKey(); Console.Clear();
                        break;
                }
            }
        }
    }
}
