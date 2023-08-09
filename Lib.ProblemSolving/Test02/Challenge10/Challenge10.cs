namespace Lib.ProblemSolving.Test02.Challenge10;

public class Challenge10
{
    List<Person> _peopleData = new List<Person>();

    public Challenge10(List<Person> people)
    {
        _peopleData = people;
    }

    public int? RetrieveAgeSumFilteringByCityV1(string cityName)
    {
        if (_peopleData == null || _peopleData.Count == 0) return null;

        var ageSumFilteringByCity = (from people in _peopleData
                                     where people.City.Equals(cityName)
                                     group people by people.City into cities
                                     select cities.Sum(ci => ci.Age)).FirstOrDefault();

        return ageSumFilteringByCity;
    }

    public int? RetrieveAgeSumFilteringByCityV2(string cityName)
    {
        if (_peopleData == null || _peopleData.Count == 0) return null;

        var ageSumFilteringByCity = _peopleData.Where(p => p.City.Equals(cityName)).Sum(ci => ci.Age);

        return ageSumFilteringByCity;
    }
}