using CreedsCode.Blog.Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CreedsCode.Blog.Application.PostsAdmin
{
    public class GetPosts
    {
        private ApplicationDbContext _context;

        public GetPosts(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ViewModel> DoModel()
        {
            return _context.Posts.ToList().Select(p => new ViewModel
            {
                Content = p.Content,
                Id = p.Id,
                Title = p.Title,
                CreatedDate = p.CreatedDate,
                Author =p.Author
                
            }).ToList();
        }

        public class ViewModel
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }
            public DateTime CreatedDate { get; set; }
            public string Author { get; set; }

        }

    }
}
