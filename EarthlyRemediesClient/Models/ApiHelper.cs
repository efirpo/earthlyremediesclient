using System.Threading.Tasks;
using RestSharp;

namespace EarthlyRemediesClient.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAllRemedies()
    {
      RestClient client = new RestClient("http://localhost:5000/api/remedies");
      RestRequest request = new RestRequest($"remedies", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> GetRemedy(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"remedies/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task Post(string newRemedy)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"remedies", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newRemedy);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Put(int id, string newRemedy)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"remedies/{id}", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newRemedy);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Delete(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"remedies/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteTaskAsync(request);
    }
  }
}