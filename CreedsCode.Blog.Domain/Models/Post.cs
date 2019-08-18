using System;
using System.Collections.Generic;
using System.Text;

namespace CreedsCode.Blog.Domain.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Featured { get; set; }
    }
}
