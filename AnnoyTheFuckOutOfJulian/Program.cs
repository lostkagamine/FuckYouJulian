using System.Diagnostics;
using System.Reflection;
using AnnoyTheFuckOutOfJulian.LightModes;

namespace AnnoyTheFuckOutOfJulian;

public static class Program
{
    private static LightMode mode = new FlashRedLightMode();

    public static void Main(string[] args)
    {
        if (args.Length >= 1)
        {
            var type = args[0];
            var asm = Assembly.GetExecutingAssembly();
            var ty = asm.GetType($"AnnoyTheFuckOutOfJulian.LightModes.{type}");
            if (ty == null)
            {
                throw new Exception("eat shit, type invalid");
            }

            if (!ty.IsAssignableTo(typeof(LightMode)))
            {
                throw new Exception("get fucked, type not assignable to LightMode");
            }

            var inst = (LightMode?)Activator.CreateInstance(ty) ?? throw new Exception("fuck");

            mode = inst;
        }
        
        Console.WriteLine("fuck you julian");
        Console.WriteLine($"initialising lightmode type {mode.GetType().Name}");

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