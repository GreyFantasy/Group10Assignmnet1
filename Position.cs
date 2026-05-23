using System.Net.Http.Headers;

public class Position
{
    private double x;
    private double y;
    private double z;

    public double X //Clamps value of x to +/- 10.0
    {
        get { return x;}
        set
        {
            if (value > 10)
            {
                x = 10;
            }
            
            else if (value < -10)
            {
                x = -10;
            }

            else
            {
                x = value;
            }
        }
    }

    public double Y //Clamps value of y to +/- 10.0
    {
        get { return y;}
        set
        {
            if (value > 10)
            {
                y = 10;
            }
            
            else if (value < -10)
            {
                y = -10;
            }

            else
            {
                y = value;
            }
        }
    }

    public double Z //Clamps value of z to +/- 10.0
    {
        get { return z;}
        set
        {
            if (value > 10)
            {
                z = 10;
            }
            
            else if (value < -10)
            {
                z = -10;
            }

            else
            {
                z = value;
            }
        }
    }

    public Position (double x, double y, double z) //Sets position values to clamped positon values
    {
        X = x;
        Y = y;
        Z = z;
    }

    public void Move (double dx, double dy, double dz) // updates positions
    {
        x += dx;
        y += dy;
        z += dz;

        //Clamp final values to +/- 20.0
        if (X > 20) X = 20;
        if (X < -20) X = -20;

        if (Y > 20) Y = 20;
        if (Y < -20) Y = -20;

        if (Z > 20) Z = 20;
        if (Z < -20) Z = -20;
    }

    public override string ToString() //one decimal place format
    {
        return "(" + X.ToString("F1") +", "
        + Y.ToString("F1") +", "
        + Z.ToString("F1") +")";
    }


}