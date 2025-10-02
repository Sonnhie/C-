class Task6
{
    static void Main(string[] args)
    {
        //Ask the user for two numbers
        Console.WriteLine("Please Enter the first number:");
        int input1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please Enter the second number");
        int input2 = Convert.ToInt32(Console.ReadLine());
        int result = input1 + input2;
        //Display the sum of two numbers
        Console.WriteLine("--------------------------------");
        Console.WriteLine("The sum of two numbers is " + result);
    }
}