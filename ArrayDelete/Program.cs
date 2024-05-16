using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDelete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeleteElement();
            Console.WriteLine("\n");
            DeletePosition();
            Console.WriteLine("\n");
            DeleteIndex();
            Console.WriteLine("\n");
            MergeArray();
            Console.WriteLine("\n");
        }


        public static void DeleteElement()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine("Array: [{0}]", string.Join(", ", a));

            int ele = 4;
            int index = -1;

            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == ele)
                {
                    index = i;
                }
            }

            Console.WriteLine("After delete element {0}", ele);
            if (index != -1)
            {
                for(int i = index; i < a.Length-1; i++)
                {
                    a[i] = a[i+1];
                }

                for(int i = 0; i < a.Length-1; i++)
                {
                    Console.Write(a[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("Element not found");
            }
        }


        public static void DeletePosition()
        {
            int[] a = new int[] { 2, 3, 4, 5, 6, 7, 1 };

            Console.WriteLine("Array: [{0}]", string.Join(", ", a));

            int pos = 4;

            Console.WriteLine("After delete 4 position element");

            for (int i = pos-1; i < a.Length-1; i++)
            {
                a[i] = a[i + 1];
            }

            for(int i = 0; i < a.Length-1; i++)
            {
                Console.Write(a[i] + " ");
            }
        }

        public static void DeleteIndex()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine("Array: [{0}]", string.Join(", ", a));

            int index = 2;

            Console.WriteLine("After delete 2 index element");

            for(int i = index; i < a.Length-1; i++)
            {
                a[i] = a[i+1];
            }

            for(int i = 0; i < a.Length-1; i++)
            {
                Console.Write(a[i] + " ");
            }
        }


        public static void MergeArray()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            int[] b = new int[] { 10, 20, 30, 40, 50 };
            int[] c = new int[a.Length + b.Length];

            Console.WriteLine("Array1: [{0}]", string.Join(", ", a));

            Console.WriteLine("Array2: [{0}]", string.Join(", ", b));

            Console.WriteLine("After merge array");

            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }

            for(int i = 0; i < b.Length; i++)
            {
                c[a.Length+i] = b[i];
            }

            for(int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");
            }
        }
    }
}
