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
    public class MyIntArray
    {
        int [] a;
        public int LinearSearch(int x)
        {
            for(int i = 0; i<a.Length;i++)
            {
                if(a[i] == x){
                    return i;
                }
            }
            return -1;
        }

        public int BinarySearch(int[] a, int x)
        {
            int left = a[0];
            int right = a[a.Length - 1];
            int mid;

            while(left <= right)
            {
                mid = (left+right)/2;
                if(a[mid] == x)
                {
                    return mid;
                }
                else if (a[mid] > x)
                {
                    right = mid - 1;
                }
                else if (a[mid] < x)
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
    }
}
