namespace ex01.Models;

    public class Comment
    {
        [JsonProperty("postId")]
        public int PostId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nBody: {Body} \n";
        }
    }