namespace MonteCarlo;

class Helper
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

    public static bool InCircle(double[] point)
    {
        if (Math.Sqrt(Math.Pow(point[0],2) + Math.Pow(point[1],2)) <= 1)
        {
            return true;
        }
        return false;
    }
    
    //Helper für MonteCarlo;
}

class MonteCarlo
{
    //Monte Carlo hier;
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}