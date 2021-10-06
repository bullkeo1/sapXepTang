using System;

namespace ThuatToan
{
    internal class Program
    {


        public static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int i, j, n, temp;

            Console.WriteLine("Sap xep mang thu tu trong C#");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Nhap kich co mang:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap {0} phan tu trong mang", n);
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan tu thu {0}", i + 1);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {

                for (j = i + 1; j < n; j++)
                {
                    if (arr1[j] - arr1[i] < 0)
                    {
                        temp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp;
                    }
                }
            }

            Console.WriteLine("Thu tu tang dan cua day so la :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}", arr1[i]);
            }

            Console.WriteLine("\n\n");
            Console.ReadKey();

        }
    }
}