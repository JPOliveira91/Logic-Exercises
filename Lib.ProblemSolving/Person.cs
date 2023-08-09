namespace Lib.ProblemSolving;

public class Person
{
    public Person(string firstName, string lastName, string city, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        City = city;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
    public int Age { get; set; }
}