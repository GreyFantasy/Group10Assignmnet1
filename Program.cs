
using System;
using System.IO;
public class Program
{
    public static void Main() // testing position clamping and updates, Now with animal
    
    {

        Random rand = new Random(); // random object for random selection


        string[] catNames = File.ReadAllLines("catnames.txt"); //reads through the names in the catnames text file
        string[] snakeNames = File.ReadAllLines("snakenames.txt"); //reads through the names in the snakenames text file


        Animal[] animals = new Animal[10];
        LinkedList<Animal> animalsList = new LinkedList<Animal>(); //collection for animals

        for (int i = 0; i < 6; i++) //generate 6 cats
        {
            int age = rand.Next(0,16); //no age range specified so I picked a realistic avg

            Position pos = new Position( // positions between the clamped position values.
                rand.Next(-10,11),
                rand.Next(-10,11),
                rand.Next(-10,11));
        

        Cat.Breed breed = (Cat.Breed)rand.Next(Enum.GetValues(typeof(Cat.Breed)).Length);  //random cat breed assigned

        Cat cat = new Cat(catNames[i], age, pos, breed); //random unique cat

        animals[i] = cat;
        animalsList.AddLast(cat);

 

        }

        for (int i = 0; i < 4; i++) //generate 4 snakes
        {
            int age = rand.Next(0,16); //no age range specified so I picked a realistic avg

            Position pos = new Position( // positions between the clamped position values.
                rand.Next(-10,11),
                rand.Next(-10,11),
                rand.Next(-10,11));
        
        double length = Math.Round(rand.NextDouble() * 5 + 0.5, 2); //generates random length rounded to double value decimal

        bool venomous = rand.Next(2) == 1; //yes or no, is venomous?

        Snake snake = new Snake(snakeNames[i], age, pos, length, venomous); //random unique cat

        animals[i + 6] = snake;
        animalsList.AddLast(snake);

 
        }

        Console.WriteLine("array: "); //prints the array of animals

        foreach (Animal animal in animals)
        {
            
            Console.WriteLine(animal);
        }



        Console.WriteLine();
        Console.WriteLine("linked_list: "); // prints each unique animal and its details

        foreach (Animal animal in animalsList)
        {
        Console.WriteLine(animal);
        }

        Console.WriteLine(" After Movement: ");
        foreach (Animal animal in animals) //random movement
        {
            animal.Move(rand.Next(-10, 11),rand.Next(-10, 11),rand.Next(-10, 11));
            Console.WriteLine(animal);

            
        }

        Position test = new Position(10, 10, 10);

            test.Move(100,100,100);

            Console.WriteLine(test);

        

    }
}