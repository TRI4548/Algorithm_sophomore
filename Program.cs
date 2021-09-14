using System;

namespace Algorithm_sophomore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Cac uoc cua n la: ");
            for(int i = 1;i<=n/2;i++)
            {
                if(n%i == 0){
                    Console.Write(i + " ");
                }
            }
            Console.Write(n);
        }
    }
}
