using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;


namespace Lesson1_Task1
{
    internal class Program
    {
        static bool timeOver = false;

        static void Main(string[] args)
        {

            Thread timeQuiz = new Thread(() =>
            {
                for (int i = 10; i >= 0; i--)
                {
                    int left = Console.WindowWidth - 25;
                    int top = 0;

                    lock (Console.Out) 
                    {
                        Console.SetCursorPosition(left < 0 ? 0 : left, top);
                        Console.Write($"Qalan vaxt: {i} saniyə     "); 
                    }

                    Thread.Sleep(1000);
                }
                timeOver = true;
                Console.Clear();
                Console.WriteLine("Vaxt bitdi! Score-a baxmaq üçün entere basın ");
            });
            timeQuiz.Start();
            int score = 0;
            if (!timeOver)
            {
                Console.WriteLine("````````````````````Suallar``````````````````````````````");
                Console.WriteLine("1. Hansı cavab int.Parse(\"abc\") əmri icra olunduqda baş verir?");
                Console.WriteLine("A) 0 qaytarır\r\nB) Runtime xətası baş verir\r\nC) \"abc\" string-ini integer-ə çevirir\r\nD) Compile-time error");
                Console.WriteLine("Cavab daxil edin");
                String ans1 = Console.ReadLine();
                if (!timeOver)
                {
                    if (ans1.ToLower() == "b")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Dogru Cavab");
                        Console.ForegroundColor = ConsoleColor.White;
                        score += 1;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Yansli cavab");
                        Console.ForegroundColor = ConsoleColor.White;
                    }


                }
            }
            else { Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Score:{score}");  
            }

            if (!timeOver)
            {
                Console.WriteLine("````````````````````Suallar``````````````````````````````");
                Console.WriteLine("2. Hansı cavab int.Parse(\"abc\") əmri icra olunduqda baş verir?");
                Console.WriteLine("A) 0 qaytarır\r\nB) Runtime xətası baş verir\r\nC) \"abc\" string-ini integer-ə çevirir\r\nD) Compile-time error");
                Console.WriteLine("Cavab daxil edin");
                String ans2 = Console.ReadLine();
                if (!timeOver)
                {
                    if (ans2.ToLower() == "b")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Dogru Cavab");
                        Console.ForegroundColor = ConsoleColor.White;
                        score += 1;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Yansli cavab");
                        Console.ForegroundColor = ConsoleColor.White;
                    }


                }
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Score:{score}");
            }
            if (!timeOver)
            {
                Console.WriteLine("````````````````````Suallar``````````````````````````````");
                Console.WriteLine("3. Hansı cavab int.Parse(\"abc\") əmri icra olunduqda baş verir?");
                Console.WriteLine("A) 0 qaytarır\r\nB) Runtime xətası baş verir\r\nC) \"abc\" string-ini integer-ə çevirir\r\nD) Compile-time error");
                Console.WriteLine("Cavab daxil edin");
                String ans3 = Console.ReadLine();
                if (!timeOver)
                {
                    if (ans3.ToLower() == "b")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Dogru Cavab");
                        Console.ForegroundColor = ConsoleColor.White;
                        score += 1;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Yansli cavab");
                        Console.ForegroundColor = ConsoleColor.White;
                    }


                }
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Score:{score}");
            }
            if (!timeOver)
            {
                Console.WriteLine("````````````````````Suallar``````````````````````````````");
                Console.WriteLine("4. Hansı cavab int.Parse(\"abc\") əmri icra olunduqda baş verir?");
                Console.WriteLine("A) 0 qaytarır\r\nB) Runtime xətası baş verir\r\nC) \"abc\" string-ini integer-ə çevirir\r\nD) Compile-time error");
                Console.WriteLine("Cavab daxil edin");
                String ans4 = Console.ReadLine();
                if (!timeOver)
                {
                    if (ans4.ToLower() == "b")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Dogru Cavab");
                        Console.ForegroundColor = ConsoleColor.White;
                        score += 1;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Yansli cavab");
                        Console.ForegroundColor = ConsoleColor.White;
                    }


                }
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Score:{score}");
            }
            if (!timeOver)
            {
                Console.WriteLine("````````````````````Suallar``````````````````````````````");
                Console.WriteLine("5. Hansı cavab int.Parse(\"abc\") əmri icra olunduqda baş verir?");
                Console.WriteLine("A) 0 qaytarır\r\nB) Runtime xətası baş verir\r\nC) \"abc\" string-ini integer-ə çevirir\r\nD) Compile-time error");
                Console.WriteLine("Cavab daxil edin");
                String ans5 = Console.ReadLine();
                if (!timeOver)
                {
                    if (ans5.ToLower() == "b")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Dogru Cavab");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Score üçün enetere basın");
                        score += 1;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Yansli cavab");
                        Console.ForegroundColor = ConsoleColor.White;

                        
                    }
                    
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Score:{score}");
                    Console.ForegroundColor = ConsoleColor.White;


                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Score:{score}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
            }
        }
    }
}






