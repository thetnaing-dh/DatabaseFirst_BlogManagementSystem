using Blogs.Database.Models;

AppDbContext db = new AppDbContext();

List<TblBlog> blogs = db.TblBlogs.ToList();

if (blogs.Count == 0)
{
    Console.WriteLine("No Blogs Found");
    return;
}

Console.Write("Enter Id of the Blog : ");

int id = int.TryParse(Console.ReadLine(), out var tempId) ? tempId : 0;

if (id == 0)
{
    Console.WriteLine("Invalid Id");
    return;
}

var blog = blogs.FirstOrDefault(b => b.BlogId == id);

if (blog != null)
{
    Console.WriteLine($@"Id : {blog.BlogId} 
    - Title : {blog.BlogTitle} 
    - Author : {blog.BlogAuthor} 
    - Content : {blog.BlogContent}");
}
else
{
    Console.WriteLine("Blog Not Found");
    return;
}