using System;

class Animal
{
    public void Speak()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog barks.");
    }
}

class Program
{
    static void Main()
    {
        Dog myDog = new Dog();
        myDog.Speak();  // Inherited method
        myDog.Bark();   // Dog-specific method
    }
}
