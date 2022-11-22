using System;

namespace обработчик_исключения
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            try
            {
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                int result = getSumArr(num, num1, num2);
                Console.WriteLine(result);
            }

            catch (FormatException)
            {
                Console.WriteLine("Повторите попытку с номером");
            }

            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Повторите попытку с индексом в диапазоне массива");
            }

            finally
            {
                Console.WriteLine("Завершение программы");
            }
        }
        public static int getSumArr(int[] Arr, int a, int b)
        {
            return Arr[a] + Arr[b];
        }
    }
}
