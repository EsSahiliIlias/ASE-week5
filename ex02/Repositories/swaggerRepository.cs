namespace ex02.Repositories;

public interface IswaggerRepository
{
    Task<List<Artist>> GetAllArtists();
    Task<List<Concert>> GetAllConcerts();
}

public class swaggerRepository : IswaggerRepository
{
    public async Task<List<Artist>> GetAllArtists()
    {
        var client = new HttpClient();
        var response = await client.GetAsync(Global.BASE_URL + "/artists");
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<Artist>>(content);
    }

    public async Task<List<Concert>> GetAllConcerts()
    {
        var client = new HttpClient();
        var response = await client.GetAsync(Global.BASE_URL + "/concerts");
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<Concert>>(content);
    }
}
