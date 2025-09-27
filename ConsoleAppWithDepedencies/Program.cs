using Blogs.Database.Models;

AppDbContext db = new AppDbContext();

List<TblBlog> blogs = db.TblBlogs.ToList();

if (blogs.Count == 0)
{
    Console.WriteLine("No Blogs Found");
    return;
}

Console.Write("Menu : L - List All Blogs, S - Search Blog By Id, E - Exit the Program : ");

string input = Console.ReadLine().ToUpper();

while (input != "L" && input != "S" && input != "E")
{
    Console.Write("Invalid Input. Please Enter L or S or E : ");
    input = Console.ReadLine().ToUpper();
}

// Exit the Program
if (input == "E")
{  
    return;
}

#region ListBlog
else if (input == "L")
{
    foreach (var item in blogs)
    {
        Console.WriteLine($@"Id : {item.BlogId} 
        - Title : {item.BlogTitle} 
        - Author : {item.BlogAuthor} 
        - Content : {item.BlogContent}");
    }
    return;
}
#endregion

#region SearchById
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
#endregion