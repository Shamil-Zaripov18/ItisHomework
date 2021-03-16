using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            try
            {
                result = SimpleMethod(10, 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            try
            {
                PrintMessage(null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            try
            {
                GetValue(7);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            try
            {
                Console.WriteLine(DoSomething("Привет"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static double SimpleMethod(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Нельзя делить на 0");
            }
            return x / y;
        }

        static void  PrintMessage(string msg)
        {
            if (msg is null)
            {
                throw new ArgumentNullException("Сообщение не может быть нулевым");
            }
            Console.WriteLine(msg);
        }
        static int GetValue(int index)
        {
            var array = new int[] { 2, 5, 8, 9, 0 };

            if (index > array.Length - 1 && index < 0)
            {
                throw new IndexOutOfRangeException("Выход за пределы массива");
                
            }
            return array[index];
        }
        static int DoSomething(object obj)
        {
            return (int)obj;
        }
    }
}
