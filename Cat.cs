public class Cat : Animal
{
    public enum Breed
    {
        Abyssinian,
        AmericanWirehair,
        Bengal,
        Himalayan,
        Ocicat,
        Serval
    }

    private Breed catBreed;

    // constructor
    public Cat (int id, string name, int age, string position, Breed breed) : base(id,name, age, position) {
        this.catBreed = breed;
    }
// getters and setters
    public Breed CatBreed
    {
        get {return catBreed;}
        set { catBreed = value;}

    }
// custom ToString class for subclass Cat
    public override string ToString()
    {
        return base.ToString() + $", Breed ={catBreed}";
    }
    
}