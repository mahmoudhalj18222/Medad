using LinqSample;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //showmessage("Hello, World!");
        //var addition = (int a, int b) =>
        //{
        //    Console.WriteLine(a.ToString());
        //    return a + b;
        //};
        //var result = addition(5, 10);
        //Console.WriteLine(result);

        var proudect = proudects();
        // ling by using lambda expression
        proudect = proudect.OrderBy(x => x.Name).ThenByDescending(p => p.price).ToList();
        proudect = proudect.Where(x => x.price > 300 && x.Location == "Location 5 ").ToList();

        int sum = proudect.Sum(x => x.price);
        int max = proudect.Max(x => x.price);
        int min = proudect.Min(x => x.price);


        var proudectGruopBy = proudect.GroupBy(x => x.Location == "Location 5 ").ToList();
        // linq sql like query
        var proudect2 = proudects();
        proudect2 = (from p in proudect2
                     where p.price > 300 && p.Location == "Location 5 "
                     select p).ToList();


        var firstProudect = proudect.FirstOrDefault();
        var lastPudect = proudect.LastOrDefault();
        var myitem = proudect.SingleOrDefault(x => x.Location == "Location 5");

        var isExiteLo5 = proudect.Exists(x => x.Location == "Location 5");

        var listOfNameProudect = proudect.Select(x => new{ x.Name, x.Location}).DistinctBy(x=>x.Location).ToList();

        int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int multi = number.Aggregate((a, b) => a*b);

        var colors = proudect.SelectMany(x => x.colors).ToList();

        var theerProudect=  proudect.Take(3).ToList();

        var skipProudect = proudect.Skip(3).ToList();


        foreach (var item in proudect)
        {

            Console.WriteLine(item.Name + " "+ item.price + " "+ item.Location);
        }

        int[] number1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int [] number2 = { 1, 2, 3, 4, 5, 11, 12, 13, 9 };

        var number3 = number1.Intersect(number2).ToList();
        var number4 = number1.Union(number2).ToList();
        var number5 = number1.Except(number2).ToList();

    }
    private static List<Proudect> proudects()
    {
        return new List<Proudect>() {
            new Proudect() { Id = 1, Name = "Proudect 30", price = 100, Location = "Location 1", colors = new List<string>() { "red", "blue" } },
            new Proudect() { Id = 2, Name = "Proudect 2", price = 200, Location = "Location 2", colors = new List<string>() { "green", "yellow" } },
            new Proudect() { Id = 3, Name = "Proudect 3", price = 300, Location = "Location 3", colors = new List<string>() { "black", "white" } },
            new Proudect() { Id = 4, Name = "Proudect 3", price = 400, Location = "Location 4", colors = new List<string>() { "pink", "purple" } },
            new Proudect() { Id = 5, Name = "Proudect 5", price = 500, Location = "Location 5", colors = new List<string>() { "orange", "brown" } },
            new Proudect() { Id = 6, Name = "Proudect 6", price = 600, Location = "Location 5", colors = new List<string>() { "gray", "cyan" } },
            new Proudect() { Id = 7, Name = "Proudect 7", price = 700, Location = "Location 5", colors = new List<string>() { "magenta", "lime" } },
            };
    }

    public static void showmessage(string message) =>Console.WriteLine(message);
}