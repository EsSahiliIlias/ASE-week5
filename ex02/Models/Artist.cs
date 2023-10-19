namespace ex02.Models
{
    public class Artist
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("genre")]
        public string Genre { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        //concertid
        [JsonProperty("concertIds")]
        public List<int> ConcertIds { get; set; }

        public override string ToString()
        {
            return $"ArtistName: {Name}\nGenre: {Genre}\nCountry: {Country}\n";
        }
    }
}