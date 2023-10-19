namespace ex02.Services
{
    public interface IArtistService
    {
        Task<List<Artist>> GetAllArtists();
        Task<List<Concert>> GetAllConcerts();

        Task<string> GetArtistWithConcerts(string artistName);
    }

    public class ArtistService : IArtistService
    {
        private IswaggerRepository _swaggerRepository;

        public ArtistService(IswaggerRepository swaggerRepository)
        {
            _swaggerRepository = swaggerRepository;
        }

        public async Task<List<Artist>> GetAllArtists() => await _swaggerRepository.GetAllArtists();

        public async Task<List<Concert>> GetAllConcerts() => await _swaggerRepository.GetAllConcerts();

        public async Task<string> GetArtistWithConcerts(string artistName)
        {
            Console.WriteLine($"Getting concerts for {artistName}");
            try
            {

                //get all artists
                var artists = await GetAllArtists();

                //get all concerts
                var concerts = await GetAllConcerts();

                //get the ConcertIds of the Artist with the given name
                var artistConcertIds = artists.Where(a => a.Name == artistName).Select(a => a.ConcertIds).ToList();

                //create a list with ever concerty that has an id in the artistConcertIds list
                var artistConcerts = concerts.Where(c => artistConcertIds[0].Contains(c.Id)).ToList();

                //create a string with all the concerts
                var artistConcertsString = string.Join(",", artistConcerts);
                var response = $"{artistName} has the following concerts: {artistConcertsString}";

                return response;
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Error getting concerts");
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}