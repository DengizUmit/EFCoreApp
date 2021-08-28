using EFCore.Query.Data.Context;
using EFCore.Query.Data.Entities;
using System;

namespace EFCore.Query
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new BlogContext();
            // added
            context.Add(new Blog
            {
                Title = "Blog-1",
                Url = "ud.com/blog-1"
            });
            context.Add(new Blog
            {
                Title = "Blog-2",
                Url = "ud.com/blog-2"
            });
            context.Add(new Blog
            {
                Title = "Blog-3",
                Url = "ud.com/blog-3"
            });
            context.Add(new Blog
            {
                Title = "Blog-4",
                Url = "ud.com/blog-4"
            });

            context.SaveChanges();

            Console.WriteLine("Console - EFCore App!");
        }
    }
}
