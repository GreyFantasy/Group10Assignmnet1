public class Snake : Animal
{
    private double length;
    private bool venomous;

    // constructor
    public Snake(int id, string name, int age, string position, double length, bool venomous)
    : base(id, name, age, position)
    {
        this.length() = length;
        this.venomous() = venomous;
    }

    // setters and getters
    public double Length
    {
        get { return length; }
        set { length = value; }
    }
    public double Venomous
    {
        get { return venomous;}
        set { venomous = value; }
    }

    // custom ToString method for Snake class
    public override String ToString()
    {
        return base.ToString() + $", Length={length:F2}m, Venomous={venomous}";
    }



}