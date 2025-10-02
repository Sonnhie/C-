class Task8
{
    static void Main(string[] args)
    {
        int n = 100;

        Console.WriteLine("String to Int Conversion");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Enter a number: ");
        string? snum = Console.ReadLine();
        Console.WriteLine("---------------------------------");
        int num = ConvertString(snum);
        Console.WriteLine($"The sum of {n} and {snum} is equal to: " + (n + num));
    }

    public static int ConvertString(string? input)
    {
        Int32.TryParse(input, out int numValue);
        return numValue;
    }
}