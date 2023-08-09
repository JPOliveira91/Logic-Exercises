using Lib.ProblemSolving.Test02.Challenge9;
using Newtonsoft.Json.Linq;

namespace Lib.ProblemSolving.UnitTest.Test02;

public class Challenge9Test
{
    [Fact]
    public void TestCase01()
    {
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

        var challenge9 = new Challenge9(people);
        var value1 = challenge9.RetrieveCityWithMostPeopleV1();
        var value2 = challenge9.RetrieveCityWithMostPeopleV2();

        Assert.Equal(new List<string>() { "New York" }, value1);
        Assert.Equal(new List<string>() { "New York" }, value2);
    }

    [Fact]
    public void TestCase02()
    {
        var people = new List<Person>()
        {
            new Person("Bill", "Smith", "San Francisco", 41),
            new Person("Sarah", "Jones", "San Antonio", 22),
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

        var challenge9 = new Challenge9(people);
        var value1 = challenge9.RetrieveCityWithMostPeopleV1();
        var value2 = challenge9.RetrieveCityWithMostPeopleV2();

        Assert.Equal(new List<string>() { "Dallas", "New York" }, value1);
        Assert.Equal(new List<string>() { "Dallas", "New York" }, value2);

    }

    [Fact]
    public void TestCase03()
    {
        var people = new List<Person>()
        {
            new Person("Brett", "Baker", "Sao Paulo", 51)
        };

        var challenge9 = new Challenge9(people);
        var value1 = challenge9.RetrieveCityWithMostPeopleV1();
        var value2 = challenge9.RetrieveCityWithMostPeopleV2();

        Assert.Equal(new List<string>() { "Sao Paulo" }, value1);
        Assert.Equal(new List<string>() { "Sao Paulo" }, value2);

    }

    [Fact]
    public void TestCase04()
    {
        var people = new List<Person>()
        {
            new Person("Alice", "Smith", "San Francisco", 41),
            new Person("Alice", "Smith", "San Antonio", 41),
            new Person("Alice", "Smith", "New York", 41),
            new Person("Alice", "Smith", "New York", 41),
            new Person("Alice", "Smith", "Sao Paulo", 41),
            new Person("Alice", "Smith", "Washington", 19),
            new Person("Alice", "Smith", "Dallas", 41),
            new Person("Alice", "Baker", "Washington", 41),
            new Person("Brett", "Smith", "Washington", 41),
            new Person("Alice", "Smith", "Los Angeles", 41),
            new Person("Alice", "Smith", "Las Vegas", 41)
        };

        var challenge9 = new Challenge9(people);
        var value1 = challenge9.RetrieveCityWithMostPeopleV1();
        var value2 = challenge9.RetrieveCityWithMostPeopleV2();

        Assert.Equal(new List<string>() { "Washington" }, value1);
        Assert.Equal(new List<string>() { "Washington" }, value2);
    }

    [Fact]
    public void TestCase05()
    {
        var challenge9 = new Challenge9(null);
        var value1 = challenge9.RetrieveCityWithMostPeopleV1();
        var value2 = challenge9.RetrieveCityWithMostPeopleV2();

        Assert.Null(value1);
        Assert.Null(value2);
    }

    [Fact]
    public void TestCase06()
    {
        var challenge9 = new Challenge9(new List<Person>() { });
        var value1 = challenge9.RetrieveCityWithMostPeopleV1();
        var value2 = challenge9.RetrieveCityWithMostPeopleV2();

        Assert.Null(value1);
        Assert.Null(value2);
    }

    [Fact]
    public void TestCase07()
    {
        var people = new List<Person>()
        {
            new Person("Bill", "Smith", "San Francisco", 41),
            new Person("Sarah", "Jones", "San Antonio", 22),
            new Person("Vivianne", "Dexter", "Tokyo", 19),
            new Person("Bob", "Smith", "New York", 49),
            new Person("Brett", "Baker", "Sao Paulo", 51),
            new Person("Mark", "Parker", "Atlanta", 19),
            new Person("Alice", "Thompson", "Dallas", 18),
            new Person("Evelyn", "Thompson", "Washington", 58),
            new Person("Mort", "Martin", "Anchorage", 58),
            new Person("Eugene", "deLauter", "Los Angeles", 84),
            new Person("Gail", "Dawson", "Las Vegas", 19)
        };

        var challenge9 = new Challenge9(people);
        var value1 = challenge9.RetrieveCityWithMostPeopleV1();
        var value2 = challenge9.RetrieveCityWithMostPeopleV2();

        Assert.Equal(new List<string>() { "Anchorage", "Atlanta", "Dallas", "Las Vegas", "Los Angeles", "New York", "San Antonio", "San Francisco", "Sao Paulo", "Tokyo", "Washington" }, value1);
        Assert.Equal(new List<string>() { "Anchorage", "Atlanta", "Dallas", "Las Vegas", "Los Angeles", "New York", "San Antonio", "San Francisco", "Sao Paulo", "Tokyo", "Washington" }, value2);
    }

    [Fact]
    public void TestCase08()
    {
        var people = new List<Person>()
        {
            new Person("Bill", "Smith", "San Francisco", 41),
            new Person("Sarah", "Jones", "San Antonio", 22),
            new Person("Vivianne", "Dexter", "New York", 19),
            new Person("Bob", "Smith", "New York", 49),
            new Person("Brett", "Baker", "Sao Paulo", 51),
            new Person("Mark", "Parker", "Atlanta", 19),
            new Person("Alice", "Thompson", "Washington", 18),
            new Person("Evelyn", "Thompson", "Washington", 58),
            new Person("Mort", "Martin", "Dallas", 58),
            new Person("Eugene", "deLauter", "Los Angeles", 84),
            new Person("Gail", "Dawson", "Las Vegas", 19)
        };

        var challenge9 = new Challenge9(people);
        var value1 = challenge9.RetrieveCityWithMostPeopleV1();
        var value2 = challenge9.RetrieveCityWithMostPeopleV2();

        Assert.Equal(new List<string>() { "New York", "Washington" }, value1);
        Assert.Equal(new List<string>() { "New York", "Washington" }, value2);
    }

    [Fact]
    public void TestCase09()
    {
        var people = new List<Person>()
        {
            new Person("Bill", "Smith", "Atlanta", 41),
            new Person("Sarah", "Jones", "San Antonio", 22),
            new Person("Vivianne", "Dexter", "New York", 19),
            new Person("Bob", "Smith", "New York", 49),
            new Person("Brett", "Baker", "Sao Paulo", 51),
            new Person("Mark", "Parker", "Atlanta", 19),
            new Person("Alice", "Thompson", "Washington", 18),
            new Person("Evelyn", "Thompson", "Washington", 58),
            new Person("Mort", "Martin", "Dallas", 58),
            new Person("Eugene", "deLauter", "Los Angeles", 84),
            new Person("Gail", "Dawson", "Las Vegas", 19)
        };

        var challenge9 = new Challenge9(people);
        var value1 = challenge9.RetrieveCityWithMostPeopleV1();
        var value2 = challenge9.RetrieveCityWithMostPeopleV2();

        Assert.Equal(new List<string>() { "Atlanta", "New York", "Washington" }, value1);
        Assert.Equal(new List<string>() { "Atlanta", "New York", "Washington" }, value2);
    }

    [Fact]
    public void TestCase10()
    {
        var people = new List<Person>()
        {
            new Person("Bill", "Smith", "Atlanta", 41),
            new Person("Sarah", "Jones", "San Antonio", 22),
            new Person("Vivianne", "Dexter", "New York", 19),
            new Person("Bob", "Smith", "London", 49),
            new Person("Brett", "Baker", "Sao Paulo", 51),
            new Person("Mark", "Parker", "Atlanta", 19),
            new Person("Alice", "Thompson", "Washington", 18),
            new Person("Evelyn", "Thompson", "Washington", 58),
            new Person("Mort", "Martin", "Dallas", 58),
            new Person("Eugene", "deLauter", "Los Angeles", 84),
            new Person("Gail", "Dawson", "Las Vegas", 19)
        };

        var challenge9 = new Challenge9(people);
        var value1 = challenge9.RetrieveCityWithMostPeopleV1();
        var value2 = challenge9.RetrieveCityWithMostPeopleV2();

        Assert.Equal(new List<string>() { "Atlanta", "Washington" }, value1);
        Assert.Equal(new List<string>() { "Atlanta", "Washington" }, value2);
    }
}