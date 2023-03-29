using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace pract13._1
{
    class Program
    {
        static int proverka()
        {
            int z = int.Parse(Console.ReadLine());
            while (true)
            {
                if (z > 0&&char.IsDigit(Convert.ToChar(z)))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Введи число больше 0");
                    z = int.Parse(Console.ReadLine());
                }
            }
            return z;
        }
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(4.5);
            list.Add(18);
            list.AddRange(new string[] { "Студент", "Петров" });
            //foreach (object e in list)
            //{
            //    Console.WriteLine(e);
            //}
            list.RemoveAt(0);
            list.Reverse();
            //Console.WriteLine(list[1]);
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            ////}
            //Console.ReadKey();


            //while (true)
            //{
            //    try
            //    {
                    ArrayList newlist = new ArrayList();
                    Console.WriteLine("Введи к-во элемнтов в списке");
            int N = proverka();
                    for (int i = 0; i < N; i++)
                    {
                        Console.WriteLine($"Введи {i + 1} элемент");
                        newlist.Add(Console.ReadLine());
                    }
                    Console.WriteLine("С какого элемента вставить новый лист");
                    int index = int.Parse(Console.ReadLine());
                    proverka();
                    list.InsertRange(index - 1, newlist);
                    foreach (object e in list)
                    {
                        Console.WriteLine(e);
                    }
                    Console.WriteLine("Введи сколько удалить элемнтов");
                    int K = proverka();
                    int n = (N / 2) - 1;
                    for (int i = 0; i < K; i++)
                    {
                        list.RemoveAt(n);
                    }
                    Console.WriteLine("Список с удаленными элементами");
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(list[i]);
                        //if (list.Count == i)
                        //    break;
                    }
        //        }
        //        catch
        //        {
        //            Console.WriteLine("Введи число");
        //        }
        //}
        Console.ReadKey();
        }
    }
}
