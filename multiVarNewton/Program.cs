using System;

namespace multiVarNewton
{
    class Program
    {
        static double[] gradient(double[] x)
        {
            double[] result = new double[2];
            result[0] = 4 + 2 * x[0] - 4 * Math.Pow(x[0], 3) - 2 * x[1];
            result[1] = 2 - 2 * x[0] - 2 * x[1];
            return result;
        }

        static double[,] inverse_H(double[] x)
        {
            double[,] result = new double[2, 2];
            result[0, 0] = 1 / (4 - 12 * Math.Pow(x[0], 2));
            result[0, 1] = 1 / (12 * Math.Pow(x[0], 2) - 4);
            result[1, 0] = 1 / (12 * Math.Pow(x[0], 2) - 4);
            result[1, 1] = (1 - 6 * Math.Pow(x[0], 2)) / (12 * Math.Pow(x[0], 2) - 4);
            return result;
        }
        
        static void Main(string[] args)
        {
            double epsilon = 0.001;

            double[] x = new double[2];
            Console.Write("Enter the first element of initial point: ");
            x[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second element of initial point: ");
            x[1] = Convert.ToDouble(Console.ReadLine());

            //if we select initial point (0,0) or (-1,1) iterations stucks a loop
            //e.g. tangent line of (a,b) intersects (c,d) and tangent line of (c,d) intersects again (a,b)

            double[,] inverse_h = new double[2, 2];
            
            double[] gra = new double[2];
            
            int count = 0;

            do
            {
                gra = gradient(x);
                inverse_h = inverse_H(x);

                x[0] = x[0] - (inverse_h[0, 0] * gra[0] + inverse_h[0, 1] * gra[1]);
                x[1] = x[1] - (inverse_h[1, 0] * gra[0] + inverse_h[1, 1] * gra[1]);
                
                count++;
                Console.WriteLine("\nineration[" + count + "]\nx = (" + x[0] + ";" + x[1] + ")");
                gra = gradient(x);
            }
            while (Math.Sqrt(Math.Pow(gra[0], 2) + Math.Pow(gra[1], 2)) > epsilon);
            
            Console.ReadKey();
        }
    }
}
