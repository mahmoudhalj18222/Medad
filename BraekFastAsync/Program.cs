
namespace BraekFastAsync
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            Coffe coffe = Prepared();
            Console.WriteLine("Coffe is ready!");

            Task<Egg> egg = FryEggsAsync(5);
            

            Task<Toast> toast = PreparedToastAsync(2);
            //Console.WriteLine("Toast is ready!");

            var breakfastTask = new List<Task> { egg, toast };

            while (breakfastTask.Any()) { 
            Task finished = await Task.WhenAny(breakfastTask);
            if(finished==egg)
                    Console.WriteLine("Egg is ready!");
            else if(finished==toast)
                        Console.WriteLine("toast is ready!");

                    breakfastTask.Remove(finished);
            }

            Console.WriteLine("your Breakfast is ready, you can invite your friends");
            Console.ReadLine();
        }

        private static async Task<Toast> PreparedToastAsync(int slice)
        {
            Console.WriteLine("Warming the toaster ...");
            await Task.Delay(1000);
            for (int i = 0; i < slice; i++)
            {
                Task.Delay(1000).Wait();
                Console.WriteLine($"Put a slice num {i} of bread in the toaster");
            }
            Console.WriteLine("truning off toaster");
            return new Toast();
        }

        private static async Task<Egg> FryEggsAsync(int v)
        {
            Console.WriteLine("Warming the egg plate....");
            await Task.Delay(1000);
            Console.WriteLine($"Cracking {v} the eggs");
            await Task.Delay(1000);
            Console.WriteLine("Putting the eggs on the table");
            return new Egg();
        }

        private static Coffe Prepared()
        {
            Console.WriteLine("Preparing Coffe.....");
            return new Coffe();
        }
    }
}