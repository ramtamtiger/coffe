using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()

        {
            string Nmlk = "N";



            Console.WriteLine("здравствуйте, вы желаете кофе с молоком ? введите Y/N ");

            string Nomlk = Console.ReadLine();

            if (Nomlk == Nmlk)
            {
                Console.WriteLine("выберите: американо - 1, эспрессо - 2");
                string number = Console.ReadLine();

                if (number == "1")
                {
                    Console.WriteLine("вы выбрали американо, внесите 90 рублей");

                }

                else if (number == "2")
                {
                    Console.WriteLine("вы выбрали эспрессо, внесите 60 рублей");

                }

                else
                {
                    Console.WriteLine("вы выбрали ошиблись.");

                }
            }

            else if (Nomlk == "Y")
            {
                Console.WriteLine("выберите кофейный напиток : капучино - 1, латте - 2, раф - 3");
                string coffeType = Console.ReadLine();

                int cost = 0;

                switch (coffeType)
                {
                    case "1":
                        cost += 100;
                        break;
                    case "2":
                        cost += 20;
                        goto case "1";
                    case "3":
                        cost += 40;
                        goto case "1";

                    default:
                        Console.WriteLine("не верный номер. повторите ввод,пожалуйста.");
                        break;
                }
                if (cost != 0)
                {
                    Console.WriteLine("внесите {0} рублей.", cost);
                    Console.WriteLine("спасибо.");
                }
                else
                {
                    Console.WriteLine("повторите выбор пожалуйста");
                }

                Console.ReadKey();
            }
            else
                {
                    Console.WriteLine("неверная буква или регистр");
                }
            }
        }
    }

