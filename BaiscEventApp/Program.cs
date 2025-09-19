namespace BaiscEventApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //System.Timers.Timer timer = new System.Timers.Timer(5000);
            //timer.Elapsed += Timer_Elapsed;
            //timer.Start();
            //Console.WriteLine("Hello, World!");
            //Console.ReadLine();

            
        }

        private static void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("timer is called, Do something " + e.SignalTime);
        }

       
    }
}