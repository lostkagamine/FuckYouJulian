namespace AnnoyTheFuckOutOfJulian.LightModes;

public class RgbLightMode : LightMode
{
    private double counter = 0;
        
    public override void Update(double delta, double total)
    {
        counter += delta;
        if (counter > 1)
        {
            counter = 0;
            var color = StackoverflowCode.ColorFromHSV((total * 12.0) % 360.0, 1.0, 1.0);
            SetLight(color);
        }
    }
}