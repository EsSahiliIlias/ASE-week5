var todapplicationService = new TodoApplicationService();
var posts = await todapplicationService.GetPosts();
var postById = await todapplicationService.GetPostById(1);
var comments = await todapplicationService.GetCommentsByPostId(100);
var postAndComments = await todapplicationService.GetPostAndComments(1);


//Get all posts
foreach (var post in posts)
{
    Console.WriteLine(post);
}


//Search for a post by ID
Console.WriteLine(postById);


//add a new post
// var AddPost = await todapplicationService.AddPost(new Post
// {
//     Title = "New Post",
//     Body = "New Post Body",
//     UserId = 3
// });

foreach (var comment in comments)
{
    Console.WriteLine(comment);
}

Console.WriteLine(postAndComments);



