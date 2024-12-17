using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Выберите задание: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание 1");
                            Console.WriteLine("Введите первое число: ");

                            int a, b, result1 = 0;
                            while (!int.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Введите корректное число!");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Введите первое число: ");
                            }

                            Console.WriteLine("Введите второе число: ");
                            while (!int.TryParse(Console.ReadLine(), out b))
                            {
                                Console.WriteLine("Введите корректное число!");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Введите первое число: ");
                            }

                            Console.WriteLine("Введите операцию (+, -, *, /)");
                            char operation = (char)Console.Read();
                            switch (operation)
                            {
                                case '+':
                                    result1 = a + b;
                                    Console.WriteLine($"Результат оепрации равен {result1}.");
                                    break;
                                case '-':
                                    result1 = a - b;
                                    Console.WriteLine($"Результат оепрации равен {result1}.");
                                    break;
                                case '*':
                                    result1 = a * b;
                                    Console.WriteLine($"Результат оепрации равен {result1}.");
                                    break;
                                case '/':
                                    result1 = a / b;
                                    Console.WriteLine($"Результат оепрации равен {result1}.");
                                    break;
                                default:
                                    Console.WriteLine("неверная операция");
                                    break;
                                
                            }

                            

                            Thread.Sleep(5000);
                        }
                        
                        break;

                    case "2":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание 2");
                            Console.WriteLine("Введите номер дня недели: ");


                            string name = "";
                            

                            switch (Console.ReadLine())
                            {
                                case "1":
                                    name = "понедельник";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "2":
                                    name = "вторник";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "3":
                                    name = "среда";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "4":
                                    name = "четверг";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "5":
                                    name = "пятница";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "6":
                                    name = "суббота";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "7":
                                    name = "воскресенье";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                default:
                                    Console.WriteLine("неверный номер");
                                    break;
                            }

                            

                            Thread.Sleep(5000);

                        }

                        break;      
                    case "3":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание 3");
                            Console.WriteLine("Введите количество денег в рублях: ");

                            double a,result1 = 0;
                            while (!double.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Введите корректное число!");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Введите количество денег в рублях: ");
                            }

                            Console.WriteLine("Выберите номер валюты для перевода (доллар - 1, евро - 2, тенге - 3 )");
                             char val = (char)Console.Read();

                            switch (val)
                            {
                                case '1':
                                    result1 = a / 100;
                                    Console.WriteLine($" {a} рублей в этой валюте будет {result1}.");
                                    break;
                                case '2':
                                    result1 = a / 101;
                                    Console.WriteLine($" {a} рублей в этой валюте будет {result1}.");
                                    break;
                                case '3':
                                    result1 = a / 0.2;
                                    Console.WriteLine($" {a} рублей в этой валюте будет {result1}.");
                                    break;
                                default :
                                    Console.WriteLine("неверный номер");
                                    break;
                            }

                            Thread.Sleep(5000);
                        }
                        break;
                    case "4":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание 4");
                            Console.WriteLine("Ведите цифру месяца: ");

                            
                            
                            string name = "";
                        

                            switch (Console.ReadLine())
                            {
                                case "1":
                                    name = "январь - зима";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "2":
                                    name = "февраль - зима";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "3":
                                    name = "март - весна";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "4":
                                    name = "апрель - весна";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "5":
                                    name = "май - весна";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "6":
                                    name = "июнь - лето";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "7":
                                    name = "июль - лето";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "8":
                                    name = "август - лето";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "9":
                                    name = "сентябрь - осень";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "10":
                                    name = "октябрь - осень";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "11":
                                    name = "ноябрь - осень";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "12":
                                    name = "декабрь - зима";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                default:
                                    Console.WriteLine("неверная цифра месяца");
                                    break;
                            }

                            Thread.Sleep(5000);
                        }
                        break;
                    case "5":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание 5");
                            Console.WriteLine("Ведите оценку: ");

                            string name = "";


                            switch (Console.ReadLine())
                            {
                                case "A":
                                    name = "5";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "B":
                                    name = "4";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "C":
                                    name = "3";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "D":
                                    name = "2";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "F":
                                    name = "1";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                default:
                                    Console.WriteLine("неверная оценка");
                                    break;
                            }

                            Thread.Sleep(5000);
                        }
                        break;
                    case "6":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание 6");
                            Console.WriteLine("Выберите напиток(чай, кофе, сок, вода): ");

                            string price = "";


                            switch (Console.ReadLine())
                            {
                                case "чай":
                                    price = "35";
                                    Console.WriteLine($"Этот напиток стоит {price} рублей.");
                                    break;
                                case "кофе":
                                    price = "50";
                                    Console.WriteLine($"Этот напиток стоит {price} рублей.");
                                    break;
                                case "сок":
                                    price = "45";
                                    Console.WriteLine($"Этот напиток стоит {price} рублей.");
                                    break;
                                case "вода":
                                    price = "15";
                                    Console.WriteLine($"Этот напиток стоит {price} рублей.");
                                    break;
                                default:
                                    Console.WriteLine("неверный напиток");
                                    break;
                            }

                            Thread.Sleep(5000);
                        }
                        break;
                    case "7":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание 7");
                            Console.WriteLine("Введите номер фигуры: ");

                            char a = (char)Console.Read();

                            string result1 = "";


                            switch (a)
                            {
                                case '1':
                                    result1 = "S = π * r2";
                                    Console.WriteLine($"Формула площади фигуры {result1}.");
                                    break;
                                case '2':
                                    result1 = "S = a ∙ a = a²";
                                    Console.WriteLine($"Формула площади фигуры {result1}.");
                                    break;
                                case '3':
                                    result1 = "S = a * h / 2";
                                    Console.WriteLine($"Формула площади фигуры {result1}.");
                                    break;
                                default:
                                    Console.WriteLine("неверный номер");
                                    break;

                            }

                            Thread.Sleep(5000);
                        }
                        break;
                    case "8":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание 8");
                            Console.WriteLine("Я ничего не сделал: ");
                          
                            Thread.Sleep(5000);
                        }
                        break;
                    case "9":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание 9");
                            Console.WriteLine("Ведите оценку: ");

                            string name = "";


                            switch (Console.ReadLine())
                            {
                                case "5":
                                    name = "очень хорошо";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "4":
                                    name = "хорошо";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "3":
                                    name = "удовлетворительно";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "2":
                                    name = "плохо";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                case "1":
                                    name = "очень плохо";
                                    Console.WriteLine($"Это {name}.");
                                    break;
                                default:
                                    Console.WriteLine("неверная оценка");
                                    break;
                            }

                            Thread.Sleep(5000);
                        }
                        break;
                    case "10":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание 10");
                            Console.WriteLine("Выбериет курс(1 - Программирование, 2 - Дизайн, 3 - Маркетинг, 4 - Менеджмент : ");

                            string name = "";


                            switch (Console.ReadLine())
                            {
                                case "4":
                                    name = "Менеджмент — это систематический подход к управлению бизнесом, который охватывает планирование, организацию, мотивацию и контроль ресурсов для достижения конкретных бизнес-целей.";
                                    Console.WriteLine($"{name}.");
                                    break;
                                case "3":
                                    name = "Маркетинг — это комплекс мер по продвижению товаров или услуг и получению прибыли от их продажи, простыми словами — это умение продать товар или услугу с выгодой и для бизнеса, и для целевой аудитории.";
                                    Console.WriteLine($"{name}.");
                                    break;
                                case "2":
                                    name = "Дизайн - рафический дизайнер занимается позиционированием бренда через визуальные образы. Он создает фирменный стиль, логотипы, шрифты, рекламные баннеры и заставки, занимается оформлением рассылок и постов";
                                    Console.WriteLine($"{name}.");
                                    break;
                                case "1":
                                    name = "Программирование - это по сути процесс создания компьютерных программ на особом языке, превращающий алгоритмы и структуры данных в некоторую инструкцию, которую может выполнить компьютер.";
                                    Console.WriteLine($"{name}.");
                                    break;
                                default:
                                    Console.WriteLine("неверная оценка");
                                    break;
                            }

                            Thread.Sleep(5000);
                        }
                        break;
                    case "11":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание 11");
                            Console.WriteLine("Введите год: ");

                            int a;
                            while (!int.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Введите корректный год!");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Введите год: ");
                            }

                            if (a % 4 == 0 && (a % 100 != 0 || a % 400 == 0))
                            {
                                Console.WriteLine($"Год {a} високосный");
                            }
                             else
                            {
                                Console.WriteLine($"Год {a} не високосный");
                            }

                            Thread.Sleep(5000);
                        }

                        break;
                    case "12":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание 12");
                            Console.WriteLine("Введите длинну стороны 1: ");

                            int a, b, c;
                            while (!int.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Введите корректную длинну!");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Введите длинну стороны 1: ");
                            }

                            Console.WriteLine("Введите длинну стороны 2: ");

                            while (!int.TryParse(Console.ReadLine(), out b))
                            {
                                Console.WriteLine("Введите корректную длинну!");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Введите длинну стороны 2: ");
                            }

                            Console.WriteLine("Введите длинну стороны 3: ");

                            while (!int.TryParse(Console.ReadLine(), out c))
                            {
                                Console.WriteLine("Введите корректную длинну!");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Введите длинну стороны 3: ");
                            }

                            if ((a + b) > c && (a + c) > b && (c + b) > a)
                            {
                                Console.WriteLine("Треугольник можно построить");
                            }    
                            if ((a + b) > c && (a + c) > b && (c + b) > a && a == b || a == c || c == b)
                            {
                                Console.WriteLine("Tакже треугольник равнобедренный");
                            }
                            else
                            {
                                Console.WriteLine("Треугольник невозможно построить");
                            }
                            Thread.Sleep(5000);
                        }
                        break;
                    case "13":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание 13");
                            Console.WriteLine("Введите количество баллов: ");

                            int a;
                            while (!int.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Введите корректное количество баллов!");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Введите количество баллов: ");
                            }


                            if (a >= 90 && a <= 100)
                            {
                                Console.WriteLine("Ваша оценка A");
                            }
                            if (a >= 80 && a <= 89)
                            {
                                Console.WriteLine("Ваша оценка B");
                            }
                            if (a >= 70 && a <= 79)
                            {
                                Console.WriteLine("Ваша оценка C");
                            }
                            if (a >= 60 && a <= 69)
                            {
                                Console.WriteLine("Ваша оценка D");
                            }
                            if (a >= 0 && a <= 59)
                            {
                                Console.WriteLine("Ваша оценка F");
                            }    
                            else
                            {
                                Console.WriteLine("Ваш балл не корректный");
                            }
                                

                            Thread.Sleep(5000);
                        }
                        break;
                    case "14":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание 14");
                            Console.WriteLine("Введите первое число: ");

                            int a, b, result = 0;
                            while (!int.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Введите корректное число");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Введите первое число: ");
                            }

                            Console.WriteLine("Введите второе число: ");

                            while (!int.TryParse(Console.ReadLine(), out b))
                            {
                                Console.WriteLine("Введите корректное число");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Введите второе число: ");
                            }

                            Console.WriteLine("Введите символ действия");

                            char simb = (char)Console.Read();

                            if (simb == '+')
                            {
                                result = a + b;
                                Console.WriteLine($"Результат операции равен {result}.");
                            }                             
                            if (simb == '-')
                            {
                                result = a - b;
                                Console.WriteLine($"Результат операции равен {result}.");

                            }
                            if (simb == '/')
                            {
                                result = a / b;
                                Console.WriteLine($"Результат операции равен {result}.");
                            }                               
                            if (simb == '*')
                            {
                                result = a * b;
                                Console.WriteLine($"Результат операции равен {result}.");
                            }
                            else
                            {
                                Console.WriteLine("Некорректная операция");
                            }                        
                            Thread.Sleep(5000);
                        }
                        break;
                    case "15":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание 15");
                            Console.WriteLine("Введите число: ");

                            int a;
                            while (!int.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Введите корректное число");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Введите число: ");
                            }

                            if (a > 0)
                            {
                                Console.WriteLine($"Число {a} положительное");
                            }
                            if (a < 0)
                            {
                                Console.WriteLine($"Число {a} отрицательное");
                            }
                            if (a == 0)
                            {
                                Console.WriteLine($"Число {a} на удивление равно нулю");
                            }

                            Thread.Sleep(5000);
                        }
                        break;
                    case "16":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание 16");
                            Console.WriteLine("Введите первое число: ");

                            int a, b, c;
                            while (!int.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Введите корректно число");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Введите первое число: ");
                            }

                            Console.WriteLine("Введите второе число : ");

                            while (!int.TryParse(Console.ReadLine(), out b))
                            {
                                Console.WriteLine("Введите корректное число!");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Введите второе число : ");
                            }

                            Console.WriteLine("Введиет третье число: ");

                            while (!int.TryParse(Console.ReadLine(), out c))
                            {
                                Console.WriteLine("Введите корректное число");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Введиет третье число: ");
                            }

                            if (a < b && a > c)
                            {
                                Console.WriteLine($"Большее число {b}, а меньшее число {c}");
                            }
                            if (a < c && a > b)
                            {
                                Console.WriteLine($"Большее число {c}, а меньшее число {b}");
                            }
                            if (b < a && b > c)
                            {
                                Console.WriteLine($"Большее число {a}, а меньшее число {c}");
                            }
                            if (b < c && b > a)
                            {
                                Console.WriteLine($"Большее число {c}, а меньшее число {a}");
                            }
                            if (c < a && c > b)
                            {
                                Console.WriteLine($"Большее число {a}, а меньшее число {b}");
                            }
                            if (c < b && c > a)
                            {
                                Console.WriteLine($"Большее число {b}, а меньшее число {a}");
                            }
                            else
                            {
                                Console.WriteLine("Ошибка операции");
                            }

                            Thread.Sleep(5000);
                        }
                        break;
                    case "17":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание 17");
                            Console.WriteLine("Введите который сейчас час: ");

                            int a;
                            while (!int.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Введите корректное время!");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Введите который сейчас час: ");
                            }


                            if (a >= 6 && a <= 12)
                            {
                                Console.WriteLine("Сейчас утро");
                            }
                            if (a >= 12 && a <= 18)
                            {
                                Console.WriteLine("Сейчас день");
                            }
                            if (a >= 18 && a <= 24)
                            {
                                Console.WriteLine("Сейчас вечер");
                            }
                            if (a >= 0 && a <= 6)
                            {
                                Console.WriteLine("Сейчас ночь");
                            }                          
                            else
                            {
                                Console.WriteLine("Некорректное время");
                            }



                            Thread.Sleep(5000);
                        }
                        break;
                    case "18":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание 18");
                            Console.WriteLine("Введите число ");

                            int a;                         
                            while (!int.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Введите корректное число!");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Введите число: ");
                            }

                            if (a % 2 == 0 && a > 2)
                            {
                                Console.WriteLine($"Число {a} сложное");
                            }
                            else
                            {
                                Console.WriteLine($"Число {a} простое");
                            }

                            Thread.Sleep(5000);
                        }
                        break;
                    case "19":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание 19");
                            Console.WriteLine("Введите угол в градусах: ");

                            int a;
                            while (!int.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Введите корректное значение!");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Введите угол в градусах: ");
                            }


                            if (a == 90)
                            {
                                Console.WriteLine("Это прямой угол");
                            }
                            if (a > 90 && a <= 180)
                            {
                                Console.WriteLine("Это тупой угол");
                            }
                            if (a > 180 && a < 360)
                            {
                                Console.WriteLine("Это развернутый угол");
                            }
                            if (a > 0 && a < 90)
                            {
                                Console.WriteLine("Это острый угол");
                            }
                            if (a < 0 || a > 360)
                            {
                                Console.WriteLine("Некорректное значение градусов ");
                            }




                            Thread.Sleep(5000);
                        }
                        break;
                    case "20":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание 20");
                            Console.WriteLine("Введите первую строку: ");

                            string a = Console.ReadLine();

                            Console.WriteLine("Введите вторую строку: ");

                            string b = Console.ReadLine();


                            if(a.Equals(b))
                            {
                                Console.WriteLine($"Строки {a} и {b} одинаковы");
                            }
                            else
                            {
                                Console.WriteLine($"Строки {a} и {b} не одинаковы");
                            }

                            Thread.Sleep(5000);
                        }
                        break;
                }
     }   }   }
}
