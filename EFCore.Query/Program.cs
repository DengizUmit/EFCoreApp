using EFCore.Query.Data.Context;
using EFCore.Query.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EFCore.Query
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new BlogContext();
            // added
            //context.Add(new Blog
            //{
            //    Title = "Blog-1",
            //    Url = "ud.com/blog-1"
            //});
            //context.Add(new Blog
            //{
            //    Title = "Blog-2",
            //    Url = "ud.com/blog-2"
            //});
            //context.Add(new Blog
            //{
            //    Title = "Blog-3",
            //    Url = "ud.com/blog-3"
            //});
            //context.Add(new Blog
            //{
            //    Title = "Blog-4",
            //    Url = "ud.com/blog-4"
            //});

            //context.SaveChanges();


            //// IEnumerable
            //var blogs = context.Blogs.AsEnumerable();
            //var blogsIEnumerable = blogs.Where(x => x.Title.Contains("Blog-1") || x.Title.Contains("Blog-3"));
            //foreach (var item in blogsIEnumerable)
            //{
            //    Console.WriteLine(item.Title);
            //}

            //// IQueryable
            //var query = context.Blogs.AsQueryable();
            //var blogsIQueryable = query.Where(x => x.Title.Contains("Blog-1") || x.Title.Contains("Blog-3")).ToList();
            //foreach (var item in blogsIQueryable)
            //{
            //    Console.WriteLine(item.Title);
            //}


            //// Tracking
            //var updatedTrackingBlog = context.Blogs.SingleOrDefault(x => x.Id == 2);
            //updatedTrackingBlog.Title = "Updated";
            //var updatedTrackingBlogState = context.Entry(updatedTrackingBlog).State;

            //// No-Tracking
            //var updatedNoTrackingBlog = context.Blogs.AsNoTracking().SingleOrDefault(x => x.Id == 1);
            //updatedNoTrackingBlog.Title = "Updated";
            //var updatedNoTrackingBlogState = context.Entry(updatedNoTrackingBlog).State;

            //context.SaveChanges();


            // Load Data : Lazy, Eager, Explict
            var blogs = context.Blogs.ToList();
            foreach (var blog in blogs)
            {
                Console.WriteLine($"\t\t{blog.Title}");
                foreach (var comment in blog.Comments)
                {
                    Console.WriteLine($"\t\t{comment.Content}");
                }
            }

            Console.WriteLine("Console - EFCore App!");
        }
    }
}
