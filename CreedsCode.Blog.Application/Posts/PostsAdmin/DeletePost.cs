using CreedsCode.Blog.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreedsCode.Blog.Application.PostsAdmin
{
    public class DeletePost
    {
        private ApplicationDbContext _context;

        public DeletePost(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task DoModelAsync(int id)
        {
            var post = _context.Posts.FirstOrDefault(p => p.Id == id);

            _context.Posts.Remove(post);

            await _context.SaveChangesAsync();
        }

    }
}
