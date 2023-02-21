using System.Drawing;
using Flurl.Http;

namespace AnnoyTheFuckOutOfJulian;

public abstract class LightMode
{
    public abstract void Update(double delta, double total);

    public void SetLight(Color c)
    {
        var a = "https://soulja-boy-told.me/light?r={R}&g={G}&b={B}&bri={BR}"
            .Replace("{R}", c.R.ToString())
            .Replace("{G}", c.G.ToString())
            .Replace("{B}", c.B.ToString())
            .Replace("{BR}", c.A.ToString());
        Task.Run(async () => 
            await a
                .WithHeader("User-Agent", "gh/ry00001/FuckYouJulian")
                .GetAsync());
    }
}