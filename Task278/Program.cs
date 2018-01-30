using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("INPUT.TXT");
            StreamWriter wr = new StreamWriter("OUTPUT.TXT");

            String s = sr.ReadLine();
            String t = sr.ReadLine();

            int count = 0;

            int j = 0, i = 0;

            if (s.Length > t.Length) wr.Write("NO");
            else
            {
                for(; i < s.Length; i++)
                {
                    for(; j < t.Length; j++)
                    {
                        if (s[i] == t[j])
                        {
                            count++;
                            break;
                        }
                    }
                    if (j == t.Length - 1)
                    {
                        break;
                    }
                }
                if(count == s.Length)
                {
                    wr.Write("YES");
                }
                else
                {
                    wr.Write("NO");
                }
            }
            sr.Close();
            wr.Close();
        }
    }
}
