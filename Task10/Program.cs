class Task10
{
    static void Main(string[] args)
    {
        Console.WriteLine("Check if number is Even or Odd number.");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Input a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("----------------------------------------");
        if (EvenorOdd(n))
        {
            Console.WriteLine($"The input number {n} is Even number.");
        }
        else
        {
            Console.WriteLine($"The input number {n} is Odd number.");
        }
    }

    public static bool EvenorOdd(int n)
    {
        return (n % 2) == 0;
    }
}