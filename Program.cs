using System;

class Student
{
    private string name;

    public Student(string name)
    {
        this.name = name; // Referring to class-level variable
    }

    public void Display()
    {
        Console.WriteLine($"Student Name: {this.name}");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student("Ancelia");
        student.Display();
    }
}
