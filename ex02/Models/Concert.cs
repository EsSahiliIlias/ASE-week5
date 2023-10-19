namespace ex02.Models
{
    public class Concert
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("genre")]
        public string Genre { get; set; }

        [JsonProperty("country")]
        public string country { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nGenre: {Genre}\nCountry: {country}\nPrice: {Price}\nDate: {Date}\n";
        }
    }
}