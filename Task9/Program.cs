class Task9
{
    static void Main(string[] args)
    {
        Console.WriteLine("Check the input number if positive or negative integer");
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("Please input a number");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("-------------------------------------------------------");
        if (CheckNumber(n))
        {
            Console.WriteLine($"The input number {n} is positive number.");
        }
        else
        {
            Console.WriteLine($"The input number {n} is negative number.");
        }
    }

    public static bool CheckNumber(int n)
    {
        return (n > 0);
    }
}