using CreedsCode.Blog.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace CreedsCode.Blog.Application.PostsAdmin
{
    public class UpdatePost
    {
        private ApplicationDbContext _contex;

        public UpdatePost(ApplicationDbContext context)
        {
            _contex = context;
        }

        public async Task DoModelAsync(ViewModel vm)
        {
            _contex.Entry(vm).State = EntityState.Modified;

            await _contex.SaveChangesAsync();
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
