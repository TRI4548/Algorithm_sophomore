using System;

namespace Algorithm_sophomore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Ban muon random so lon nhat la bao nhieu?: ");
            int max = int.Parse(Console.ReadLine());
            Console.Write("Ban muon so phan tu trong mang la bao nhieu?: ");
            int len = int.Parse(Console.ReadLine());
            MyIntArray a = new MyIntArray(len);
            a.RandomArray(max);
            Array.Sort(a.Mang);
            a.OutputArray();
            if (a.FindContent(n) == -1)
            {
                Console.WriteLine("\nKhong tim thay gia tri can tim!");
            }
            else
            {
                Console.WriteLine($"\nTim thay {n} o vi tri i = {a.FindContent(n)}");
            }
            Console.WriteLine($"So lan thuc hien so sanh tuan tu la: {a.CountLinearSearchSteps(n)}");
            Console.WriteLine($"So lan thuc hien so sanh nhi phan la: {a.CountBinarySearchSteps(n)}");
        }
    }
    class MyIntArray
    {
        private int[] array;
        public int[] Mang
        {
            get => this.array;
            set { this.array = value; }
        }

        public MyIntArray(int n = 8)
        {
            Mang = new int[n];
        }

        public int this[int i]
        {
            get => array[i];
            set => array[i] = value;
        }
        public void Input()
        {
            string[] tk = Console.ReadLine().Split();
            for(int i = 0; i<array.Length;i++)
            {
                array[i] = int.Parse(tk[i]);
            }
        }

        public void RandomArray(int max)
        {
            for (int i = 0; i < Mang.Length; i++)
            {
                Random x = new Random();
                Mang[i] = x.Next(max);
            }
        }
        public void OutputArray()
        {
            Console.WriteLine("KET QUA MANG:");
            for (int i = 0; i < Mang.Length; i++)
            {
                Console.Write(Mang[i] + " ");
            }
        }
        public int FindContent(int x)
        {
            for (int i = 0; i < Mang.Length; i++)
            {
                if (Mang[i] == x)
                {
                    return i + 1;
                }
            }
            return -1;
        }
        public int CountLinearSearchSteps(int number_being_find)
        {
            for (int i = 0; i < Mang.Length; i++)
            {
                if (Mang[i] == number_being_find)
                {
                    return i + 1;
                }
            }
            return Mang.Length;
        }
        public int CountBinarySearchSteps(int number_being_find)
        {
            int left = 0;
            int right = Mang.Length - 1;
            int mid;
            int found = 0;
            while (left <= right)
            {
                mid = (left + right) / 2;
                found++;
                if (Mang[mid] == number_being_find)
                {
                    break;
                }
                else if (number_being_find < Mang[mid])
                {
                    right = mid - 1;
                }
                else if (number_being_find > Mang[mid])
                {
                    left = mid + 1;
                }
            }
            return found;
        }
    }
}
