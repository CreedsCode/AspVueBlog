using CreedsCode.Blog.Application.Posts;
using CreedsCode.Blog.Database;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CreedsCode.Blog.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PostsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<GetPosts.ViewModel> GetPosts(string category = "All")
        {
            switch (category.ToLower())
            {
                case "all":
                    return new GetPosts(_context).DoModel();
                case "featured":
                    return new GetPosts(_context).DoModel().Where(p => p.Featured == true);
                default:
                    return new GetPosts(_context).DoModel();
            }
        }

        [HttpGet("{id}")]
        public GetPost.ViewModel GetPost(int id, string type = "Full")
        {
            switch (type.ToLower())
            {
                case "short":
                    return new GetPost(_context).DoModelShort(id);
                case "full":
                    return new GetPost(_context).DoModel(id);
                default:
                    return new GetPost(_context).DoModel(id);
            }
        }
    }
}