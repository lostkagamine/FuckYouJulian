using System.Drawing;

namespace AnnoyTheFuckOutOfJulian.LightModes;

public class FlashRedLightMode : LightMode
{
    private bool on = false;
    private double counter = 0;
        
    public override void Update(double delta, double total)
    {
        counter += delta;
        if (counter > 1)
        {
            counter = 0;
            on = !on;
            var value = on switch
            {
                true => Color.Red,
                false => Color.FromArgb(0, 0, 0, 0)
            };
            SetLight(value);
        }
    }
}