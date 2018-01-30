using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp579
{
    class Program
    {
        public static List<int> list = new List<int>();

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("INPUT.TXT");
            StreamWriter sw = new StreamWriter("OUTPUT.TXT");
            
            int quantity = int.Parse(sr.ReadLine());
            
            String[] src = sr.ReadLine().Split(' ');

            sr.Close();

            foreach(String s in src)
            {
                list.Add(int.Parse(s));
            }

            int max = 0;
            int count = 0;

            String indexMax = "";
            String index = "";

            for (int mask = 0; mask < (1 << quantity); mask++)
            {//перебор масок			
                for (int j = 0; j < quantity; j++)
                {//перебор индексов массива
                    if ((mask & (1 << j)) != 0)
                    {//поиск индекса в маске
                        count += list[j];
                        index += (j +1)  + " ";
                        Console.Write(list[j] + " ");//вывод элемента
                    }
                }
                if(Math.Abs(count) > max)
                {
                    max = Math.Abs(count);
                    indexMax = index;
                }
                index = "";
                count = 0;
                Console.WriteLine();//перевод строки для вывод следующего подмножества
            }

            sw.WriteLine(indexMax.Split(' ').Length - 1);
            sw.WriteLine(indexMax);
            sw.Flush();
            sw.Close();
        }

    }
}
