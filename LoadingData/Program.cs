using LoadingData;
using LoadingData.Entitties;
using Microsoft.EntityFrameworkCore;

var db=new AppDbContext();

//var user=new User()
//{
//    Id = 1,
//    Name = "sherali",
//    Blogs = new List<BlogUser>()
//    {
//        new BlogUser()
//        {
//            Blog = new Blog()
//            {
//                Name = "sherali's daily",
//                Posts = new List<Post>()
//                {
//                    new Post()
//                    {
//                        Content = "hmhm",
//                        Comments = new List<Comment>()
//                        {
//                            new Comment()
//                            {
//                                Text = "Zo'r"
//                            }
//                        }
//                    }
//                }
//            },
//            IsAdmin = true
//        }
//    }
//};

//db.Users.Add(user);











//var user = db.Users.Include(u=>u.UserBlogs).ThenInclude(userBlog=>userBlog.Blog).FirstOrDefault(u => u.Id == 1);

//Console.WriteLine(user.UserBlogs);

//user.UserBlogs.Find(b => b.Blog.Name == "sherali's daily");

//foreach (var blog in user.UserBlogs)
//{
//    Console.WriteLine(blog.Blog.Name);
//}











//EAGER LOADING
/*var users = db.Users.Include(u=>u.UserBlogs).
    ThenInclude(userblog=>userblog.Blog).
    ThenInclude(blog=>blog.Posts).
    ThenInclude(post=>post.Comments).
    ToList();
foreach (var user in users)
{
    Console.WriteLine(user.Id);
    Console.WriteLine(user.Name);
    foreach (var userBlog in user.UserBlogs)
    {
        Console.WriteLine(userBlog.Blog.Name);
        Console.WriteLine(userBlog.Blog.Id);
    }
}
*/




//LAZY LOADING

/*var users = db.Users.ToList();

if (users.Count<2)
{
    return;
}

foreach (var user in users)
{
    foreach (var userBlog in user.UserBlogs)
    {
        Console.WriteLine($"Name: {userBlog.Blog.Name}");
    }
}
*/






//EXPLICIT LOADING
var users = db.Users.ToList();

if (users.Count < 2)
{
    return;
}

foreach (var user in users)
{
    db.Entry(user).Collection(u=>u.UserBlogs).Load();

    foreach (var userBlog in user.UserBlogs)
    {
        db.Entry(userBlog).
            Reference(u => u.Blog).
            Load();

        Console.WriteLine($"Name: {userBlog.Blog.Name}");
    }
}












//db.SaveChanges();