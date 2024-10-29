using System;

namespace TwoDemensionArray;

public class Point
{
    public int x;
    public int y;

    public double CalDistance(Point p)
    {
        double sum = Math.Pow((this.x-p.x),2) + Math.Pow((this.y-p.y),2);
        return Math.Sqrt(sum); // Eu Distance.
    }
}