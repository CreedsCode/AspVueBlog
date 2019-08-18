using CreedsCode.Blog.Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CreedsCode.Blog.Application.Posts
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
                CreatedDate = $"{GetMonth(p.CreatedDate.Month)} {p.CreatedDate.Day}, {p.CreatedDate.Year}",
                Author = p.Author,
                Featured= p.Featured
            }).ToList();
        }


        private static string GetMonth(int month)
        {
            string createdMonth = "";
            switch (month)
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
            return createdMonth;
        }

        public class ViewModel
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }
            public string CreatedDate { get; set; }
            public string Author { get; set; }
            public bool Featured { get; set; }
        }

    }
}
