using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            Getso(ref a, ref b);
            Console.WriteLine("a={0}\nb={1}", a, b);
            Console.ReadLine();

            DateTime value = new DateTime(2014, 11, 20);
            Console.WriteLine(value);
            Console.WriteLine(value == DateTime.Today);
            //khaibaokieudate time
            string simpleTime = "20/1/2000";
            DateTime Time = DateTime.Parse(simpleTime);
            Console.WriteLine(Time);
            Console.ReadLine();
            const int MAX = 10;
            int n,m;
            int [,]h = new int[MAX, MAX];
            NhapMang(h, out n);
            xuatmang(h, n);
            Console.WriteLine("\nCac phan tu cheo chinh :");
            incc(h, n);
            Console.WriteLine("\n cac so nguyen to :");
            Xuatsnt(h, n);
            Console.Read();
          
        }
        static void NhapMang(int[,]a,out int n)
        {
            Console.Write("Nhap n=:");
            n = int.Parse(Console.ReadLine());
            for ( int i =0;i<n;i++)
                for ( int j = 0; j < n; j++)
                {
                    Console.Write("Nhap a=[{0},{1}]=", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
        }
        static void xuatmang(int[,]a,int n)
        {
            for ( int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
                        }
        }
        static int ktnt(int n)
        {
            if (n < 2)
                return 0;
            else
            {
                for (int i = 2; i < n / 2; i++)
                    if (n % i == 0)
                        return 0;
                return 1;
            }
        }
        static void Xuatsnt(int[,] a, int n)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (ktnt(a[i,j])==1)
                        Console.Write(a[i, j] + "\t");
        }
        static void incc(int[,] a, int n)
        {
            for(int i =0;i<n;i++)
                for(int j =0;j<n;j++)
                    if(i==j)
                        Console.Write(a[i, j] + "\t");
        }
    

        public static void Getso ( ref int x, ref int y)
        {
            x = 5;
            y = 10;
        }
       
    }
}
