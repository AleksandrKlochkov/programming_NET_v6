using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming_NET_v6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool task = false;
            int numberTask = 0;


            do
            {
                task = false;
                Console.WriteLine("Выполнение задания по предмету 'Программирование под платформу .NET' Вариант-6");
                Console.WriteLine("Выберите номер задания:");
                Console.WriteLine("Задание 1 введите цифру 1");
                Console.WriteLine("Задание 2 введите цифру 2");
                Console.WriteLine("Задание 3 введите цифру 3");
                Console.WriteLine("Задание 4 введите цифру 4");
                Console.WriteLine("Задание 6 введите цифру 6");
                Console.WriteLine("Для выхода 0");
                if (!int.TryParse(Console.ReadLine(), out numberTask))
                {
                    Console.WriteLine("Ошибка! Введите корректный номер задания");
                    task = true;
                }
                else
                {
                    task = false;
                    switch (numberTask)
                    {
                        case 1:
                            bool one = false;
                            int a;
                            int b;
                            do
                            {
                                one = false;
                                Console.WriteLine("Задание 1");
                                Console.WriteLine("Написать C# программу, реализующую функцию согласно варианту задания. Исходные данные вводятся с клавиатуры.\r\nРеализовать функцию возведения в куб разности двух  целых чисел ");
                                Console.WriteLine("Введите число а: ");
                                string keyA = Console.ReadLine();
                                Console.WriteLine("Введите число b: ");
                                string keyB = Console.ReadLine();
                                if (!int.TryParse(keyA, out a) || !int.TryParse(keyB, out b))
                                {
                                    Console.WriteLine("Ошибка! Вы ввели не верные значения, попробуйте снова");
                                    one = true;
                                }
                                else {
                                    Task1 task1 = new Task1(a,b);
                                    task1.Exponentiation();
                                    Console.WriteLine("Нажмите любую клавишу для выхода в меню");
                                    Console.ReadKey();
                                    task = true;
                                }
                               
                            }
                            while (one == true);
                           
                            break;
                        case 2:
                            Console.WriteLine("Задание 2");
                            Console.WriteLine("Построить иерархию классов в соответствии с вариантом задания.\r\nДеталь, механизм, изделие, узел");
                            break;
                        case 3:
                            Console.WriteLine("Задание 3");
                            break;
                        case 4:
                            Console.WriteLine("Задание 4");
                            break;
                        case 5:
                            Console.WriteLine("Задание 5");
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }
                }

            }
            while (task == true);
            Console.ReadKey();
        }
    }
}
