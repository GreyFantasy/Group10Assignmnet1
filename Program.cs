public class Program
{
    public static void Main() // testing position clamping and updates
    
    {
        Position p1 = new Position(5, 12, -15);

        Console.WriteLine(p1);

        p1.Move(10, -5, 30);

        Console.WriteLine(p1);
    }
}