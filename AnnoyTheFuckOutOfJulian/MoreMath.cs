namespace AnnoyTheFuckOutOfJulian;

public static class MoreMath
{
    public static bool RoughlyZero(double a, double epsilon = 0.0003)
        => a < epsilon;
}