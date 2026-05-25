public class Program
{
    public static void Main() // testing position clamping and updates, Now with animal
    
    {
        Position p1 = new Position(1, 2, 3);

        Animal a1 = new Animal("Bella", 5, p1);

        Console.WriteLine(p1);

        a1.Move(5, -2, 10);

        Console.WriteLine(a1);
    }
}