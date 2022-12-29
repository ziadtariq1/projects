class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int n2 = int.Parse(Console.ReadLine());


        Console.WriteLine("Prime numbers from " + n1 + " to " + n2 + ": ");
        for (int i = n1; i <= n2; i++)
        {
            if (IsPrimeNumber(i))
            {
                Console.WriteLine(i);
            }
        }
    }


    static bool IsPrimeNumber(int n)
    {
        if (n == 1 || n == 0)
        {
            return false;
        }
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)

                return false;
        }
        return true;
    }
}
