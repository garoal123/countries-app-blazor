using CountryInfo;
using QuickType;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

public class CountriesService
{
    private readonly HttpClient _httpClient;

    public CountriesService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("https://restcountries.com/v3.1/"); // Configura la base URL
    }

    public async Task<List<countryV3>> GetCountriesByRegion(string region)
    {
        var url = region == "all" ? "all" : $"region/{region}";
        var request = new HttpRequestMessage(HttpMethod.Get, url);
        var response = await _httpClient.SendAsync(request);

        try
        {
            response.EnsureSuccessStatusCode();

            var jsonString = await response.Content.ReadAsStringAsync();

            // Deserializar el JSON utilizando el código autogenerado
            var countries = countryV3.FromJson(jsonString);
            return countries;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return new List<countryV3>(); // Si hay un error, devuelve una lista vacía
    }

    public async Task<List<countryV3>> GetCountriesByCode(string code)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"alpha/{code}");
        var response = await _httpClient.SendAsync(request);

        try
        {
            response.EnsureSuccessStatusCode();

            var jsonString = await response.Content.ReadAsStringAsync();

            // Deserializar el JSON utilizando el código autogenerado
            var countries = countryV3.FromJson(jsonString);
            return countries;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return new List<countryV3>(); // Si hay un error, devuelve una lista vacía
    }

}
