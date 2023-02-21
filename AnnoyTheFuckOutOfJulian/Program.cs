using System.Diagnostics;
using AnnoyTheFuckOutOfJulian.LightModes;

namespace AnnoyTheFuckOutOfJulian;

public static class Program
{
    private static LightMode mode = new FlashRedLightMode();

    public static void Main(string[] args)
    {
        Console.WriteLine("fuck you julian");

        var a = new Stopwatch();
        var total = 0.0;
        while (true)
        {
            var time = a.Elapsed.TotalSeconds;
            a.Restart();
            total += time;
            mode.Update(time, total);
            Thread.Sleep(50);
        }
    }
}