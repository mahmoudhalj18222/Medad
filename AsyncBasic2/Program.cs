
internal class Program
{
    private static void Main(string[] args)
    {
        Task<int> x = DoCalcution();
        Console.WriteLine($"the result of DoCalcution is : {x.Result}");
        Console.WriteLine("last row in main");
        Console.ReadLine();
    }

    private static async Task<int> DoCalcution()
    {
        Console.WriteLine("DoCalculation method has been called");

        await Task.Delay(5000);
        Console.WriteLine("Delay has finished");
        return 100 + 200;
    }
}