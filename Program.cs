using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task one");
            TaskOne();
            Console.WriteLine("Task two");
            TaskTwo();
            Console.ReadLine();
        }

        public static void TaskOne()
        {
            Console.WriteLine(@"CanConstruct('a','b'))->" + CanConstruct("a", "b"));
            Console.WriteLine(@"CanConstruct('aa','bb'))->" + CanConstruct("aa", "bb"));
            Console.WriteLine(@"CanConstruct('aa','aab'))->" + CanConstruct("aa", "aab"));
        }

        public static void TaskTwo()
        {
            int[] array = { 0, 1, 0, 3, 12 };
            ArrayToString(array);
            Console.Write("-> ");
            ArrayToString(FilterZerosToEnd(array));
            Console.WriteLine();

        }
        public static void ArrayToString(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        /// <summary>
        /// This algorithm is only good for short strings for longer string is better use efficient algorithms like Rabin–Karp algorithm.
        /// </summary>
        /// <param name="substring"></param>
        /// <param name="all"></param>
        /// <returns></returns>
        public static bool CanConstruct(string substring, string all)
        {
            return all.Contains(substring);
        }
        public static int[] FilterZerosToEnd(int[] array)
        {
            var count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    array[count++] = array[i];
                }
            }
            while (count < array.Length)
            {
                array[count++] = 0;
            }
            return array;
        }

    }
}
