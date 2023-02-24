using System.Net.Http.Json;
using FirstApp.Models;

namespace FirstApp.Clients;

public class NasaClient {
    private readonly HttpClient _client;

    public NasaClient(HttpClient client){
        _client = client;
    }

    public async Task<NasaResponse> getNasa(string date){
        string url = "https://api.nasa.gov/planetary/apod?api_key=UM9PDj0UB5HDQUFboAKTtdjQ83zwHczJOUXuP2cl";
        if (date != null){
            url += "&date=" + date;
        } 
        return await _client.GetFromJsonAsync<NasaResponse>(url);
    }
}