

namespace Asyinc_Basic
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Application started");
            FirstCall();
            Console.WriteLine("After Calling the firstcall");
            Console.ReadLine();
        }

        private static async Task FirstCall()
        {
            int x = await ScaendCall();
            Console.WriteLine($"Calling first call is finished. result is {x}");
        }

        private static Task<int> ScaendCall()
        {
           return Task.Run(() =>
            {
                Task.Delay(5000).Wait();
                return 100;
            });
            }
    }
}