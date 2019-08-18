using CreedsCode.Blog.Database;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CreedsCode.Blog.Application.PostsAdmin
{
    public class CreatePost
    {
        private ApplicationDbContext _context;

        public CreatePost(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task DoModelAsync(ViewModel post)
        {
            _context.Posts.Add(new Domain.Models.Post
            {
                Content = post.Content,
                Title = post.Title,
                CreatedDate = DateTime.Now,
                Author = "CreedsCode",
                Featured = false
            });

            await _context.SaveChangesAsync();

        }

        public class ViewModel
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public DateTime CreatedDate { get; set; }
            public string Author { get; set; }

        }

    }
}
