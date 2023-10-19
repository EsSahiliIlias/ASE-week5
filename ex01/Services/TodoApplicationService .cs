namespace ex01.Services;

public interface ITodoApplicationService
{
    Task<List<Post>> GetPosts();
    Task<Post> GetPostById(int postId);
    Task<int> AddPost(Post post); // Add a new post and return its ID
    Task<List<Comment>> GetCommentsByPostId(int postId); // Get comments for a certain post
    Task<string> GetPostAndComments(int postId);

}

public class TodoApplicationService : ITodoApplicationService
{

    private IPostRepository _postRepository;

    public TodoApplicationService()
    {
        _postRepository = new PostRepository();
    }

    public async Task<List<Post>> GetPosts() => await _postRepository.GetPosts();

    public async Task<Post> GetPostById(int postId) => await _postRepository.GetPostById(postId);

    public async Task<int> AddPost(Post post) => await _postRepository.AddPost(post);

    public async Task<List<Comment>> GetCommentsByPostId(int postId) => await _postRepository.GetCommentsByPostId(postId);

    public async Task<string> GetPostAndComments(int postId)
    {
        var post = await GetPostById(postId);
        var comments = await GetCommentsByPostId(postId);
        var result = $"Post: {post.Title}\nComments:\n";
        foreach (var comment in comments)
        {
            result += comment.Body;
        }
        return result;
    }

}