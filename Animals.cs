using System;

public abstract class Animal
{
    public abstract void MakeNoise();
}

public class Dog : Animal
{
    public override void MakeNoise()
    {
        Console.WriteLine("bow bow");
    }
}

public class Cat : Animal
{
    public override void MakeNoise()
    {
        Console.WriteLine("meow meow");
    }
}

public class DumbDog : Dog
{
    public override void MakeNoise()
    {
        throw new Exception("I can't make noise");
    }
}

public class DumbCat : Cat
{
    public override void MakeNoise()
    {
        throw new Exception("I can't make noise");
    }
}

class AnimalsProgram
{
    static void Main(string[] args)
    {
        Animal dog = new Dog();
        dog.MakeNoise();

        Animal cat = new Cat();
        cat.MakeNoise();

        Animal DumbDog = new DumbDog();
        try
        {
            DumbDog.MakeNoise();
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }


        Animal DumbCat = new DumbCat();
        try
        {
            DumbCat.MakeNoise();
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}