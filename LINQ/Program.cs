using System.Linq;
namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            String[] videoGameNames = { "Zelda", "MarioIII", "Donkey Kong" };
            var orderedGameNames = videoGameNames.OrderBy(name => name.Length);
            foreach (var v in orderedGameNames) Console.WriteLine(v);
        }
    }
}
