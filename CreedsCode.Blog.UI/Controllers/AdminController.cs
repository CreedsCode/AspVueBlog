using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreedsCode.Blog.Application.PostsAdmin;
using CreedsCode.Blog.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CreedsCode.Blog.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("posts")]
        public IEnumerable<GetPosts.ViewModel> GetPosts() => new GetPosts(_context).DoModel();

        [HttpGet("posts/{id}")]
        public GetPost.ViewModel GetPost(int id) => new GetPost(_context).DoModel(id);

        [HttpPost("posts")]
        public IActionResult CreatePost([FromBody]CreatePost.ViewModel vm) => Ok(new CreatePost(_context).DoModelAsync(vm));

        [HttpDelete("posts/{id}")]
        public async Task<IActionResult> DeletePost(int id)
        {
            await new DeletePost(_context).DoModelAsync(id);
            return NoContent();
        }

        [HttpPut("posts")]
        public IActionResult UpdatePost([FromBody]UpdatePost.ViewModel vm) => Ok(new UpdatePost(_context).DoModelAsync(vm));
    }
}