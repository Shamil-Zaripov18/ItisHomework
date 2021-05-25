using System;

namespace AnonimusMethod
{
    class Program
    {
        delegate int MyDelegate2();
        delegate double MyDelegate1(MyDelegate2[] a);
        static void Main()
        {
            int Numberonthismoment = 6;

            MyDelegate1 Del;

            Del = delegate(MyDelegate2[] a) 
            {
                double sam = 0;

                foreach (var i in a)
                {
                    sam += i.Invoke();
                }

                return sam / a.Length;
            };

            var array = new MyDelegate2[Numberonthismoment];

            for (int i = 0; i < Numberonthismoment; i++)
            {
                array[i] = AddNumber;
            }

            Console.WriteLine(Del.Invoke(array));
        }

        static int AddNumber()
        {
            return new Random().Next(1, 100);
        }

    }
}
