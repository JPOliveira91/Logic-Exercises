using Lib.ProblemSolving.Test02.Challenge10;
using Newtonsoft.Json.Linq;

namespace Lib.ProblemSolving.UnitTest.Test02;

public class Challenge10Test
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

        var challenge10 = new Challenge10(people);
        var cityName = "Dallas";
        var value1 = challenge10.RetrieveAgeSumFilteringByCityV1(cityName);
        var value2 = challenge10.RetrieveAgeSumFilteringByCityV2(cityName);

        Assert.Equal(76, value1);
        Assert.Equal(76, value2);
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

        var challenge10 = new Challenge10(people);
        var cityName = "Los Angeles";
        var value1 = challenge10.RetrieveAgeSumFilteringByCityV1(cityName);
        var value2 = challenge10.RetrieveAgeSumFilteringByCityV2(cityName);

        Assert.Equal(84, value1);
        Assert.Equal(84, value2);

    }

    [Fact]
    public void TestCase03()
    {
        var people = new List<Person>()
        {
            new Person("Brett", "Baker", "Sao Paulo", 51)
        };

        var challenge10 = new Challenge10(people);
        var cityName = "Sao Paulo";
        var value1 = challenge10.RetrieveAgeSumFilteringByCityV1(cityName);
        var value2 = challenge10.RetrieveAgeSumFilteringByCityV2(cityName);

        Assert.Equal(51, value1);
        Assert.Equal(51, value2);

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

        var challenge10 = new Challenge10(people);
        var cityName = "Dallas";
        var value1 = challenge10.RetrieveAgeSumFilteringByCityV1(cityName);
        var value2 = challenge10.RetrieveAgeSumFilteringByCityV2(cityName);

        Assert.Equal(41, value1);
        Assert.Equal(41, value2);
    }

    [Fact]
    public void TestCase05()
    {
        var challenge10 = new Challenge10(null);
        var cityName = "Dallas";
        var value1 = challenge10.RetrieveAgeSumFilteringByCityV1(cityName);
        var value2 = challenge10.RetrieveAgeSumFilteringByCityV2(cityName);

        Assert.Null(value1);
        Assert.Null(value2);
    }

    [Fact]
    public void TestCase06()
    {
        var challenge10 = new Challenge10(new List<Person>() { });
        var cityName = "Dallas";
        var value1 = challenge10.RetrieveAgeSumFilteringByCityV1(cityName);
        var value2 = challenge10.RetrieveAgeSumFilteringByCityV2(cityName);

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
            new Person("Alice", "Thompson", "Kyoto", 18),
            new Person("Evelyn", "Thompson", "Washington", 58),
            new Person("Mort", "Martin", "Anchorage", 58),
            new Person("Eugene", "deLauter", "Los Angeles", 84),
            new Person("Gail", "Dawson", "Las Vegas", 19)
        };

        var challenge10 = new Challenge10(people);
        var cityName = "Dallas";
        var value1 = challenge10.RetrieveAgeSumFilteringByCityV1(cityName);
        var value2 = challenge10.RetrieveAgeSumFilteringByCityV2(cityName);

        Assert.Equal(0, value1);
        Assert.Equal(0, value2);
    }

    [Fact]
    public void TestCase08()
    {
        var people = new List<Person>()
        {
            new Person("Bill", "Smith", "New York", 41),
            new Person("Sarah", "Jones", "New York", 22),
            new Person("Vivianne", "Dexter", "New York", 19),
            new Person("Bob", "Smith", "New York", 49),
            new Person("Brett", "Baker", "New York", 51),
            new Person("Mark", "Parker", "New York", 19),
            new Person("Alice", "Thompson", "New York", 18),
            new Person("Evelyn", "Thompson", "New York", 58),
            new Person("Mort", "Martin", "New York", 58),
            new Person("Eugene", "deLauter", "New York", 84),
            new Person("Gail", "Dawson", "New York", 19)
        };

        var challenge10 = new Challenge10(people);
        var cityName = "New York";
        var value1 = challenge10.RetrieveAgeSumFilteringByCityV1(cityName);
        var value2 = challenge10.RetrieveAgeSumFilteringByCityV2(cityName);

        Assert.Equal(438, value1);
        Assert.Equal(438, value2);
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
            new Person("Gail", "Dawson", "Las Vegas", 50)
        };

        var challenge10 = new Challenge10(people);
        var cityName = "Las Vegas";
        var value1 = challenge10.RetrieveAgeSumFilteringByCityV1(cityName);
        var value2 = challenge10.RetrieveAgeSumFilteringByCityV2(cityName);

        Assert.Equal(50, value1);
        Assert.Equal(50, value2);
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

        var challenge10 = new Challenge10(people);
        var cityName = "Washington";
        var value1 = challenge10.RetrieveAgeSumFilteringByCityV1(cityName);
        var value2 = challenge10.RetrieveAgeSumFilteringByCityV2(cityName);

        Assert.Equal(76, value1);
        Assert.Equal(76, value2);
    }
}