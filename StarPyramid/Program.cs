using System;
using System.Linq;

namespace StarPyramid;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(
            new[] { Enumerable.Range(1, 10) }
            .Select(p => p.Where(p1 => p1 % 2 != 0)
                            .Select(item =>
                                new string(' ', (p.Count() - item) / 2) +
                                new string('*', item) +
                                    Environment.NewLine)
            )
            .FirstOrDefault()
            .Aggregate("", (agg, item) => agg + item)
        );

        Console.ReadLine();
    }
}