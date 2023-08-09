namespace Lib.ProblemSolving.Test02.Challenge9;

public class Challenge9
{
    List<Person> _peopleData = new List<Person>();

    public Challenge9(List<Person> people)
    {
        _peopleData = people;
    }

    public List<string> RetrieveCityWithMostPeopleV1()
    {
        if (_peopleData == null || _peopleData.Count == 0) return null;

        var processedCities = (from people in _peopleData
                               group people by people.City into cities
                               select new
                               {
                                   Name = cities.Key,
                                   Count = cities.Count()
                               }).ToList();

        var citiesWithMostPeople = (from city in processedCities
                                    where city.Count == processedCities.Max(pc => pc.Count)
                                    orderby city.Name
                                    select city.Name).ToList();

        return citiesWithMostPeople;
    }

    public List<string> RetrieveCityWithMostPeopleV2()
    {
        if (_peopleData == null || _peopleData.Count == 0) return null;

        var processedCities = _peopleData.GroupBy(p => p.City);
        var maxCount = processedCities.Max(ci => ci.Count());

        var citiesWithMostPeople = processedCities.Where(c => c.Count() == maxCount);

        return citiesWithMostPeople.Select(c => c.Key).OrderBy(ci => ci).ToList();
    }
}