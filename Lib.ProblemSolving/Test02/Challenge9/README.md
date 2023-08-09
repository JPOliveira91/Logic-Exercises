6 - Considerando a lista abaixo, escreva um trecho de código utilizando linq (.NET) que retorne a cidade com o maior número de moradores:

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

var people = new List<Person>()
{
	new Person("Bill", "Smith", "San Francisco", 41),
	new Person("Sarah", "Jones", "San Antonio", 22),
	new Person("Stacy", "Baker", "New York", 21),
	new Person("Vivianne", "Dexter", "New York", 19),
	new Person("Bob", "Smith", "New York", 49),
	new Person("Brett", "Baker", "Sao Paulo", 51),
	new Person("Mark", "Parker", "Atlanta", 19),
	new Person("Alice", "Thompson", "Dallas", 18),
	new Person("Evelyn", "Thompson", "Washington", 58),
	new Person("Mort", "Martin", "Dallas", 58),
	new Person("Eugene", "deLauter", "Los Angeles", 84),
	new Person("Gail", "Dawson", "Las Vegas", 19)
};