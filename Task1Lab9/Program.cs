using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int a, b;
                string c;
                //Приветствие
                Console.WriteLine("Вас приветствует Куль-Куль (1лвл)");
                try
                {
                    //Ввод значений
                    Console.Write("Введите целое число х=");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите целое число y=");
                    b = Convert.ToInt32(Console.ReadLine());
                }
                //Валидация
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка! {0}", ex.Message);
                    Console.ReadLine();
                    continue;
                }

                //Ввод операции
                Console.Write("Введите код операции: \n\t + сложение \n\t - вычитание\n\t * умножение\n\t / частное\n");
                c = Console.ReadLine();

                //Валидация
                if (c != "+" || c != "-" || c != "*" || c != "/")
                {
                    Console.WriteLine("Неверно введён знак операции!");
                }
                else
                {
                    //Ветвление кода в зависимости от введёного знака
                    switch (c)
                    {
                        case "+":
                            Console.WriteLine("Сумма чисел {0} и {1} равна {2}", a, b, a + b);
                            break;
                        case "-":
                            Console.WriteLine("Разность чисел {0} и {1} равна {2}", a, b, a - b);
                            break;
                        case "*":
                            Console.WriteLine("Произведение чисел {0} и {1} равно {2}", a, b, a * b);
                            break;
                        case "/":
                            //Валидация
                            try
                            {
                                Console.WriteLine("Частное чисел {0} и {1} равно {2}", a, b, a / b);
                            }
                            catch (DivideByZeroException) when (a == b && b == 0)
                            {
                                Console.WriteLine("Нуль на нуль будет нуль");
                            }
                            catch (DivideByZeroException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                    }
                    Console.ReadLine();
                }
            }

        }
    }
}
