using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp557
{
    class Program
    {
        public static int m = 0;
        public static int n = 0;

        public static int x = 0;
        public static int y = 0;

        public static int param = 0;

        public static int[,] A;
        public static int[,] B;
        public static int[,] C;

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("INPUT.TXT");

            String src = sr.ReadLine();

            m = int.Parse(src.Split(' ')[0]);
            n = int.Parse(src.Split(' ')[1]);

            src = sr.ReadLine();

            x = int.Parse(src.Split(' ')[0]);
            y = int.Parse(src.Split(' ')[1]);

            param = int.Parse(sr.ReadLine());

            A = new int[n,n];
            B = new int[n,n];
            C = new int[n,n];

            InitializeMatrixCZero();

            src = sr.ReadLine();
            String[] s = new String[n];

            for(int i = 0; i < n; i++)
            {
                s = sr.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    A[i, j] =int.Parse(s[j]);
                }
            }

            src = sr.ReadLine();

            for (int i = 0; i < n; i++)
            {
                s = sr.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    B[i, j] = int.Parse(s[j]);
                }
            }

            TrevelMatrix();

            m -= 2;

            for(int k = 0; k < m; k++)
            {
                src = sr.ReadLine();

                for (int i = 0; i < n; i++)
                {
                    s = sr.ReadLine().Split(' ');
                    for (int j = 0; j < n; j++)
                    {
                        B[i, j] = int.Parse(s[j]);
                    }
                }
                TrevelMatrix();
            }

            sr.Close();

            StreamWriter wr = new StreamWriter("OUTPUT.TXT");
            Console.WriteLine(x);
            Console.WriteLine(y);
            wr.WriteLine(A[x - 1, y - 1]);
            wr.Close();
        }

        public static void InitializeMatrixCZero()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    C[i, j] = 0;
                }
            }
        }

        public static void MatrixAEquateC()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = C[i, j];
                }
            }
        }

        public static void TrevelMatrix()
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    for(int k = 0; k < n; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                    if(C[i,j] >= param)
                    {
                        C[i, j] %= param;
                    }
                }
            }

            MatrixAEquateC();
            InitializeMatrixCZero();
        }
    }
}
