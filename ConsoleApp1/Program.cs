using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CodeFirstNewDatabaseSample
{
   class Program
   {
      static Program()
      {
         Database.SetInitializer<BlogContext>(null);
         System.Data.Entity.Infrastructure.Interception.DbInterception.Add(new CommandInterceptor());
      }

      static void Main(string[] args)
      {
         using (var db = new BlogContext())
         {
            db.Database.CreateIfNotExists();

            // Create and save a new Blog 
            Console.Write("-- Enter a name for a new Blog: ");
            var name = Console.ReadLine();

            var blog = new Blog { Name = name };
            db.Blogs.Add(blog);
            db.SaveChanges();
            blog = db.Blogs.Where(_ => _.Name == name).FirstOrDefault();

            var post1 = new Post { /*PostId = 1,*/ Title = "FST", Content = "Test 1", BlogId = blog.BlogId };
            var post2 = new Post { /*PostId = 2,*/ Title = "SEC", Content = "Test 2", BlogId = blog.BlogId };
            var post3 = new Post { /*PostId = 3,*/ Title = "THD", Content = "Test 3", BlogId = blog.BlogId };
            db.Posts.AddRange(new[] { post1, post2, post3 });

            db.SaveChanges();
            db.Database.Log = sql => { Console.WriteLine(sql); };

            Console.WriteLine("-- Press Enter to continue.");
            Console.ReadLine();

            // Display all Blogs from the database 
            var sum = db.Blogs.Where(_ => _.BlogId == 1).Select(_ => _.BlogId).Sum();
            Console.WriteLine($"-- blog query: {sum}");

            sum = db.Posts.Where(_ => _.BlogId == 1).Select(_ => _.PostId).Sum();
            Console.WriteLine($"-- post query: {sum}");

            var query = db.Blogs.Join(db.Posts,
                    b => b.BlogId,
                    p => p.BlogId,
                    (b, p) => new { Name = b.Name, Post = p.Content });

            foreach (var item in query)
            {
               Console.WriteLine($"{item.Name}, {item.Post}");
            }

            db.Database.Log = sql => { Console.WriteLine(sql); };

            Console.WriteLine("-- Press any key to exit...");
            Console.ReadLine();
         }
      }
   }
   public class Blog
   {
      public int BlogId { get; set; }
      public string Name { get; set; }

      public virtual List<Post> Posts { get; set; } //no virtual
   }

   public class Post
   {
      public int PostId { get; set; }
      public string Title { get; set; }
      public string Content { get; set; }

      public int BlogId { get; set; }
      public virtual Blog Blog { get; set; }
   }

   public class BlogContext : DbContext
   {
      public BlogContext() : base("BlogContext")
      { }
      public DbSet<Blog> Blogs { get; set; }
      public DbSet<Post> Posts { get; set; }
   }
}
