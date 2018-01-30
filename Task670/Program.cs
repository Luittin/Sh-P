using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp670
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("INPUT.TXT");

            int N = int.Parse(sr.ReadLine());
            sr.Close();

            int i = 1;

            int rect = 0;

            bool fal = true;

            while(N > 0)
            {
                char[] s = i.ToString().ToCharArray();
                if(s.Length > 1)
                {
                    for(int j = 0; j < s.Length - 1; j++)
                    {
                        for(int k = j + 1; k < s.Length; k++)
                        {
                            if(s[j] == s[k])
                            {
                                fal = false;
                                break;
                            }
                        }
                        if (fal == false)
                        {
                            break;
                        }
                    }
                    if(fal == true)
                    {
                        rect = i;
                        N--;
                    }
                }
                else
                {
                    rect = i;
                    N--;
                }
                i++;                
                fal = true;
            }

            StreamWriter sw = new StreamWriter("OUTPUT.TXT");
            sw.WriteLine(rect);
            sw.Close();
        }
    }
}
