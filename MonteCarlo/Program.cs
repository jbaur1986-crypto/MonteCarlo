namespace MonteCarlo;

public delegate bool AreaTest(double[] point);

public class Helper
{
    private static Random zufall = new Random();
    
    public static double[] RandomPoint
    {
        get
        {
            double[] point = new double[2];
            point[0] = zufall.NextDouble();
            point[1] = zufall.NextDouble();
            return point;
        }
    }

    public static bool InQuarterCircle(double[] point)
    {
        if (Math.Sqrt(Math.Pow(point[0],2) + Math.Pow(point[1],2)) <= 1)
        {
            return true;
        }
        return false;
    }

    public static bool InTriangle(double[] point)
    {
        if (point[1] <= -point[0] + 1)
        {
            return true;
        }

        return false;
    }

    public static bool UnderParabola(double[] point)
    {
        if (point[1] <= Math.Pow(point[0],2))
        {
            return true;
        }

        return false;
    }
    
    //Helper für MonteCarlo;
}

public class MonteCarloMethod
{
    //Monte Carlo hier;
    public static double MonteCarlo(int repetition, AreaTest test)
    {
        int count = 0;
        for (int i = 0; i < repetition; i++)
        {
            if (test(Helper.RandomPoint))
            {
                count += 1;
            }
        }
        return (double)count / repetition;
    }
    
}

class Program
{
    static void Main(string[] args)
    {
        AreaTest test1 = Helper.InQuarterCircle;

        Console.WriteLine($"{MonteCarloMethod.MonteCarlo(1000000, test1)*4}");
        
        AreaTest test2 = Helper.InTriangle;

        Console.WriteLine($"{MonteCarloMethod.MonteCarlo(1000000, test2)}");
        
        AreaTest test3 = Helper.UnderParabola;

        Console.WriteLine($"{MonteCarloMethod.MonteCarlo(1000000, test3)}");
    }
}