using System;

namespace DelegateLab
{
    delegate void Del();
    class ArraySecond
    {
        int elementsAmount, arraysAmount;
        int[][] Array;

        public void Create()
        {
            Console.WriteLine("Введите кол-во элементов в массиве");
            elementsAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во массивов");
            arraysAmount = Convert.ToInt32(Console.ReadLine());
            Array = new int[arraysAmount][];
            for (int i = 0; i < arraysAmount; i++)
            {
                Array[i] = new int[elementsAmount];
                for (int j = 0; j < Array[i].Length; j++)
                {
                    Array[i][j] = 0;
                }
            }
        }

        public void KeyboardInput()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < Array[i].Length; j++)
                {
                    Console.WriteLine($"Введите элемент {j} в массив {i}");
                    Array[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void RandomInput()
        {
            Random rand = new Random();
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < Array[i].Length; j++)
                {
                    
                    Array[i][j] = rand.Next()%10;
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("Массив: ");
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < Array[i].Length; j++)
                {
                    Console.Write(Array[i][j] + " ");
                }
                Console.Write("\n");
            }
        }

        public void Sort()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                RadixSort(Array[i], Array[i].Length);
            }
        }

        public int[] RadixSort(int[] array, int size)
        {
            var maxVal = GetMaxVal(array, size);
            for (int exponent = 1; maxVal / exponent > 0; exponent *= 10)
                CountingSort(array, size, exponent);
            return array;
        }

        public static int GetMaxVal(int[] array, int size)
        {
            var maxVal = array[0];
            for (int i = 1; i < size; i++)
                if (array[i] > maxVal)
                    maxVal = array[i];
            return maxVal;
        }

        public static void CountingSort(int[] array, int size, int exponent)
        {
            var outputArr = new int[size];
            var occurences = new int[10];
            for (int i = 0; i < 10; i++)
                occurences[i] = 0;
            for (int i = 0; i < size; i++)
                occurences[(array[i] / exponent) % 10]++;
            for (int i = 1; i < 10; i++)
                occurences[i] += occurences[i - 1];
            for (int i = size - 1; i >= 0; i--)
            {
                outputArr[occurences[(array[i] / exponent) % 10] - 1] = array[i];
                occurences[(array[i] / exponent) % 10]--;
            }
            for (int i = 0; i < size; i++)
                array[i] = outputArr[i];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArraySecond arr = new ArraySecond();
            Del a = arr.Create;
            Console.WriteLine("1 - Ручной ввод, 2 - Случайный ввод");
            string choice = Console.ReadLine();
            switch(int.Parse(choice))
            {
                case 1:
                    a += arr.KeyboardInput;
                    break;
                case 2:
                    a += arr.RandomInput;
                    break;
                default:
                    Console.WriteLine("Ввод отменён");
                    return;
            }

            a += arr.Display;
            a += arr.Sort;
            a += arr.Display;
            a.Invoke();
        }
    }
}
