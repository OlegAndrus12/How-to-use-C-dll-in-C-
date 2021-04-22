using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {   
        [DllImport("C:\\Users\\oleh.andrus\\source\\repos\\DLL\\Debug\\DLL.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern void bubleSort(int[] arr, int n);
        
        [DllImport("C:\\Users\\oleh.andrus\\source\\repos\\DLL\\Debug\\DLL.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern void quickSort(int[] arr, int n, int high);

        [DllImport("C:\\Users\\oleh.andrus\\source\\repos\\DLL\\Debug\\DLL.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern void shellSort(int[] arr, int n);

        [DllImport("C:\\Users\\oleh.andrus\\source\\repos\\DLL\\Debug\\DLL.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern void heapSort(int[] arr, int n);

        [DllImport("C:\\Users\\oleh.andrus\\source\\repos\\DLL\\Debug\\DLL.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern void insertionSort(int[] arr, int n);

        public static void printArr(int[]arr)
        {
            Console.WriteLine("Your array : ");
            foreach(var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static int[] enterArray()
        {
            Console.Write("Please enter array (separated by whitespace)>>> ");
            try
            {
                int [] arr = Console.ReadLine().Split().Select(x => Convert.ToInt32(x)).ToArray();
                foreach (var i in arr)
                {
                    Console.Write(i.ToString() + " ");
                }
                Console.WriteLine();
                return arr;
            }
            catch
            {
                Console.WriteLine("Invalid input, try again");
                enterArray();
            }
            return null;
        }

        static void Main(string[] args)
        {
            var arr = enterArray();
            bool menuIsActive = true;
            while(menuIsActive)
            {
                Console.WriteLine("**********************************************************");
                Console.WriteLine("Choose the option");
                Console.WriteLine("# 1 : Buble sort");
                Console.WriteLine("# 2 : Quick sort");
                Console.WriteLine("# 3 : Shell sort");
                Console.WriteLine("# 4 : Heap sort");
                Console.WriteLine("# 5 : Insertion sort");
                Console.WriteLine("# 6 : Use another array");
                Console.WriteLine("# 7 : Exit");

                Console.Write("Make a choice please >>> ");
                int choice;
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice > 8 && choice < 1)
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.WriteLine("Your choice is not correct! Try again");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        {
                            int[] arrCopy = new int[arr.Length];
                            Array.Copy(arr, arrCopy, arr.Length);
                            Stopwatch sw = new Stopwatch();
                            sw.Start();
                            bubleSort(arrCopy, arrCopy.Length);
                            sw.Stop();
                            Console.WriteLine("Before : ");
                            printArr(arr);
                            Console.WriteLine("After : ");
                            printArr(arrCopy);
                            Console.WriteLine("Elapsed time = {0} ms", sw.Elapsed.TotalMilliseconds);
                            break;
                        }
                    case 2:
                        {
                            int[] arrCopy = new int[arr.Length];
                            Array.Copy(arr, arrCopy, arr.Length);
                            Stopwatch sw = new Stopwatch();
                            sw.Start();
                            quickSort(arrCopy, 0, arrCopy.Length-1);
                            sw.Stop();
                            Console.WriteLine("Before : ");
                            printArr(arr);
                            Console.WriteLine("After : ");
                            printArr(arrCopy);
                            Console.WriteLine("Elapsed time = {0} ms", sw.Elapsed.TotalMilliseconds);
                            break;
                        }
                    case 3: 
                        {
                            int[] arrCopy = new int[arr.Length];
                            Array.Copy(arr, arrCopy, arr.Length);
                            Stopwatch sw = new Stopwatch();
                            sw.Start();
                            shellSort(arrCopy, arrCopy.Length);
                            sw.Stop();
                            Console.WriteLine("Before : ");
                            printArr(arr);
                            Console.WriteLine("After : ");
                            printArr(arrCopy);
                            Console.WriteLine("Elapsed time = {0} ms", sw.Elapsed.TotalMilliseconds);
                            break;
                        }
                    case 4:
                        {
                            int[] arrCopy = new int[arr.Length];
                            Array.Copy(arr, arrCopy, arr.Length);
                            Stopwatch sw = new Stopwatch();
                            sw.Start();
                            heapSort(arrCopy, arrCopy.Length);
                            sw.Stop();
                            Console.WriteLine("Before : ");
                            printArr(arr);
                            Console.WriteLine("After : ");
                            printArr(arrCopy);
                            Console.WriteLine("Elapsed time = {0} ms", sw.Elapsed.TotalMilliseconds);
                            break;
                        }
                    case 5:
                        {
                            int[] arrCopy = new int[arr.Length];
                            Array.Copy(arr, arrCopy, arr.Length);
                            Stopwatch sw = new Stopwatch();
                            sw.Start();
                            insertionSort(arrCopy, arrCopy.Length);
                            sw.Stop();
                            Console.WriteLine("Before : ");
                            printArr(arr);
                            Console.WriteLine("After : ");
                            printArr(arrCopy);
                            Console.WriteLine("Elapsed time = {0} ms", sw.Elapsed.TotalMilliseconds);
                            break;
                        }
                    case 6:
                        {
                            arr = enterArray();
                            break;
                        }
                    case 7:
                        {
                            menuIsActive = false;
                            break;
                        }
                }

            }
        }
    }
}
