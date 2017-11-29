using SetlistFmApi.SearchOptions.Location;
using Xunit;

namespace SetlistFmApi.IntegrationTests
{
  public abstract class LocationTestsBase : IntegrationTestBase
  {
    private const string O2ARENAVENUEID = "73d466b5";
    private const string SANJOSECOUNTRYID = "5392171";


    [Fact]
    public void FindCity_ById_CanFindCity()
    {
      var city = _client.FindCity(SANJOSECOUNTRYID);
      Assert.Equal("San Jose", city.Name);
    }

    [Fact]
    public void FindCountries_CanFindCountries()
    {
      var results = _client.FindCountries();
      Assert.NotEmpty(results.Countries);
    }

    [Fact]
    public void FindVenue_ById_CanFindVenue()
    {
      var venue = _client.FindVenue(O2ARENAVENUEID);
      Assert.NotNull(venue);
      Assert.Equal("The O2 Arena", venue.Name);
    }

    [Fact]
    public void FindVenues_CanFindVenues()
    {
      var options = new VenueSearchOptions() { Name = "Terminal 5" };
      var results = _client.FindVenues(options);
      Assert.NotNull(results);
      Assert.NotEmpty(results.Venues);
    }

    [Fact]
    public void FindSetlistsByVenue_CanFindSetlists()
    {
      var options = new SetlistByVenueSearchOptions() { VenueId = O2ARENAVENUEID };
      var results = _client.FindSetlistsByVenue(options);
      Assert.NotNull(results);
      Assert.NotEmpty(results.Setlists);
    }
  }
}
