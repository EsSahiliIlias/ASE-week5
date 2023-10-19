namespace ex01.Repositories;


public interface IPostRepository
{
    Task<List<Post>> GetPosts();
    Task<Post> GetPostById(int postId); 
    Task<int> AddPost(Post post);
    Task<List<Comment>> GetCommentsByPostId(int postId); 
}

public class PostRepository : IPostRepository
{

    public async Task<List<Post>> GetPosts()
    {
        var client = new HttpClient();
        var response = await client.GetAsync(Global.BASE_URL + "/posts");
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<Post>>(content);
    }

    public async Task<Post> GetPostById(int postId)
    {
        var client = new HttpClient();
        var response = await client.GetAsync(Global.BASE_URL + "/posts/" + postId);
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<Post>(content);
    }

    public async Task<int> AddPost(Post post)
    {
        var client = new HttpClient();
        var json = JsonConvert.SerializeObject(post);
        var data = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await client.PostAsync(Global.BASE_URL + "/posts", data);
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<Post>(content).Id;
    }

    public async Task<List<Comment>> GetCommentsByPostId(int postId)
    {
        var client = new HttpClient();
        var response = await client.GetAsync(Global.BASE_URL + "/posts/" + postId + "/comments");
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<Comment>>(content);
    }
}