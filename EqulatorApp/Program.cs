
namespace EqulatorApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            bool res1 = Equlater.AreEqual(5, 19);
            bool res2 = Equlater.AreEqual(6, 6);

            Console.WriteLine(res1);

            bool res3 = GenericEqulator.AreEqual<double>(5.1, 19.3);
            Console.WriteLine(res3);
            int x = GenericEqulator.Dothnig<string, int>("ma", 1);

            var y = new GenericClass<double>();
            y.Item = 10.5;
            
        }
    }
} 