using CreedsCode.Blog.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreedsCode.Blog.Application.PostsAdmin
{
    public class GetPost
    {
        private ApplicationDbContext _context;

        public GetPost(ApplicationDbContext context)
        {
            _context = context;
        }

        public ViewModel DoModel(int id)
        {
            var post = _context.Posts.FirstOrDefault(p => p.Id == id);

            var createdMonth = "";
            switch (post.CreatedDate.Month)
            {
                case 1:
                    createdMonth = "January";
                    break;
                case 2:
                    createdMonth = "February";
                    break;
                case 3:
                    createdMonth = "March";
                    break;
                case 4:
                    createdMonth = "April";
                    break;
                case 5:
                    createdMonth = "May";
                    break;
                case 6:
                    createdMonth = "June";
                    break;
                case 7:
                    createdMonth = "July";
                    break;
                case 8:
                    createdMonth = "August";
                    break;
                case 9:
                    createdMonth = "September";
                    break;
                case 10:
                    createdMonth = "October";
                    break;
                case 11:
                    createdMonth = "November";
                    break;
                case 12:
                    createdMonth = "December";
                    break;
                default:
                    break;
            }

            return (new ViewModel
            {
                Content = post.Content,
                Id = post.Id,
                Title = post.Title,
                CreatedDate = $"{createdMonth} {post.CreatedDate.Day}, {post.CreatedDate.Year}",
                Author =post.Author
            });
        }

        public class ViewModel
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }
            public string CreatedDate { get; set; }
            public string Author { get; set; }

        }

    }
}
