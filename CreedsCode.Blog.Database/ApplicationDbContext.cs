using System;
using System.Collections.Generic;
using System.Text;
using CreedsCode.Blog.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CreedsCode.Blog.Database
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        :base(options)
        {}

        public DbSet<Post> Posts { get; set; }

    }
}
