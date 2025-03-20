internal class Program
{
    private static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        HttpClient client = new HttpClient();
        var result = await client.GetAsync("https://baconipsum.com/api/?type=meat-and-filler");
        Console.WriteLine(result.Content.ReadAsStringAsync().Result);
    }
}