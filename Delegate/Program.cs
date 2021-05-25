using System;


namespace Delegate
{
    class Program
    {
        public delegate double Calculation(double r);
        static void Main()
        {
            double dsd = 4;
            Calculation D = GetCircle;
            Calculation S = GetCircleArea;
            Calculation V = GetBallVolume;
            Console.WriteLine("D = " + D(dsd) + "\n" + "S = " + S(dsd) + "\n" + "V = " + V(dsd));

        }

        static double GetCircle(double zae)
        {
            return 2 * Math.PI * zae;
        }

        static double GetCircleArea(double zae)
        {
            return Math.PI * zae * zae;
        }

        static double GetBallVolume(double zae)
        {
            return (4 / 3) * Math.PI * zae * zae * zae;
        }
    }
}