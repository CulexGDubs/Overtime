using System;

namespace overtime
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Program A = new Program();
            System.Console.WriteLine(A.OT(new double[]{9, 19, 30, 1.5}));
        }

        public string OT(double[] a)
        {
            double hours = a[1] - a[0];
            double overT = 0;
            if(a[1] > 17)
            {
                overT = (a[1] - 17) * (a[3] - 1) * a[2];
            }

            double pay = hours * a[2] + overT;
            return "$" + pay.ToString("N2");
        }
    }
}
