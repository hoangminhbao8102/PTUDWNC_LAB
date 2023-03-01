using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatBlog.Core.Entities;
using TatBlog.Data.Contexts;

namespace TatBlog.Data.Seeders
{
    public class DataSeeder : IDataSeeder
    {
        private readonly BlogDbContext _dbContext;

        public DataSeeder(BlogDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Initialize()
        {
            _dbContext.Database.EnsureCreated();

            if (_dbContext.Posts.Any()) return;

            var authors = AddAuthors();
            var categories = AddCategories();
            var tags = AddTags();
            var posts = AddPosts(authors, categories, tags);
        }

        private IList<Author> AddAuthors()
        {
            var authors = new List<Author>()
            {
                new()
                {
                    FullName = "Jason Mouth",
                    UrlSlug = "jason-mouth",
                    Email = "json@gmail.com",
                    JoinedDate = new DateTime(2022, 10, 21)
                },
                new()
                {
                    FullName = "Jessica Wonder",
                    UrlSlug = "jessica-wonder",
                    Email = "jessica665@motip.com",
                    JoinedDate = new DateTime(2020, 4, 19)
                },
                new()
                {
                    FullName = "Kathy Smith",
                    UrlSlug = "kathy-smith",
                    Email = "kathy.smith@iworld.com",
                    JoinedDate = new DateTime(2010, 6, 9)
                },
                new()
                {
                    FullName = "Tran Phuong Thao",
                    UrlSlug = "tran-phuong-thao",
                    Email = "thaotp@gmail.com",
                    JoinedDate = new DateTime(2018, 6, 30)
                },
                new()
                {
                    FullName = "Nguyen Thanh Nhan",
                    UrlSlug = "nguyen-thanh-nhan",
                    Email = "nhannt@gmail.com",
                    JoinedDate = new DateTime(2016, 4, 19)
                }
            };
            _dbContext.Authors.AddRange(authors);
            _dbContext.SaveChanges();
            return authors;
        }

        private IList<Category> AddCategories() 
        {
            var categories = new List<Category>()
            {
                new()
                {
                    Name = ".NET Core",
                    Description = ".NET Core",
                    UrlSlug = "dot-net-core"
                },
                new()
                {
                    Name = "Architecture",
                    Description = "Architecture",
                    UrlSlug = "architecture"
                },
                new()
                {
                    Name = "Messaging",
                    Description = "Messaging",
                    UrlSlug = "messaging"
                },
                new()
                {
                    Name = "OPP",
                    Description = "Object-Oriented Program",
                    UrlSlug = "object-oriented program"
                },
                new()
                {
                    Name = "Design Patterns",
                    Description = "Design Patterns",
                    UrlSlug = "design-patterns"
                },
                new()
                {
                    Name = "C#",
                    Description = "C Sharp",
                    UrlSlug = "c-sharp"
                },
                new()
                {
                    Name = "ASP.NET",
                    Description = "ASP.NET",
                    UrlSlug = "asp-dot-net"
                },
                new()
                {
                    Name = "Web Application",
                    Description = "Web Application",
                    UrlSlug = "web-application"
                },
                new()
                {
                    Name = "Database",
                    Description = "Database",
                    UrlSlug = "database"
                },
                new()
                {
                    Name = "Mobile Application",
                    Description = "Mobile Application",
                    UrlSlug = "mobile-application"
                }
            };
            _dbContext.AddRange(categories);
            _dbContext.SaveChanges();
            return categories;
        }

        private IList<Tag> AddTags() 
        {
            var tags = new List<Tag>()
            {
                new()
                {
                    Name = "Google",
                    Description = "Google",
                    UrlSlug = "google"
                },
                new()
                {
                    Name = "ASP.NET MVC",
                    Description = "Google",
                    UrlSlug = "asp-net-core"
                },
                new()
                {
                    Name = "Google",
                    Description = "Google",
                    UrlSlug = "google"
                },
                new()
                {
                    Name = "ASP.NET MVC",
                    Description = "Google",
                    UrlSlug = "asp-net-core"
                },
                new()
                {
                    Name = "Google",
                    Description = "Google",
                    UrlSlug = "google"
                },
                new()
                {
                    Name = "ASP.NET MVC",
                    Description = "Google",
                    UrlSlug = "asp-net-core"
                },
                new()
                {
                    Name = "Google",
                    Description = "Google",
                    UrlSlug = "google"
                },
                new()
                {
                    Name = "ASP.NET MVC",
                    Description = "Google",
                    UrlSlug = "asp-net-core"
                },
                new()
                {
                    Name = "Google",
                    Description = "Google",
                    UrlSlug = "google"
                },
                new()
                {
                    Name = "ASP.NET MVC",
                    Description = "Google",
                    UrlSlug = "asp-net-core"
                },
                new()
                {
                    Name = "Google",
                    Description = "Google",
                    UrlSlug = "google"
                },
                new()
                {
                    Name = "ASP.NET MVC",
                    Description = "Google",
                    UrlSlug = "asp-net-core"
                },
                new()
                {
                    Name = "Google",
                    Description = "Google",
                    UrlSlug = "google"
                },
                new()
                {
                    Name = "ASP.NET MVC",
                    Description = "Google",
                    UrlSlug = "asp-net-core"
                },
                new()
                {
                    Name = "Google",
                    Description = "Google",
                    UrlSlug = "google"
                },
                new()
                {
                    Name = "ASP.NET MVC",
                    Description = "Google",
                    UrlSlug = "asp-net-core"
                },
                new()
                {
                    Name = "Google",
                    Description = "Google",
                    UrlSlug = "google"
                },
                new()
                {
                    Name = "ASP.NET MVC",
                    Description = "Google",
                    UrlSlug = "asp-net-core"
                },
                new()
                {
                    Name = "Google",
                    Description = "Google",
                    UrlSlug = "google"
                },
                new()
                {
                    Name = "ASP.NET MVC",
                    Description = "Google",
                    UrlSlug = "asp-net-core"
                }
            };
            _dbContext.AddRange(tags);
            _dbContext.SaveChanges();
            return tags;
        }

        private IList<Post> AddPosts(IList<Author> authors, IList<Category> categories, IList<Tag> tags) 
        {
            var posts = new List<Post>()
            {
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                },
                new()
                {
                    Title = "ASP.NET Core Diagnostic Scenarios",
                    ShortDescription = "David and friends has a great repos",
                    Description = "Noi dung gi do",
                    Meta = "",
                    UrlSlug = "asp-net-core-diagnostic-scenarios",
                    Published = true,
                    PostedDate = new DateTime(2021, 9, 30, 10, 20, 0),
                    ModifiedDate = null,
                    ViewCount = 10,
                    Author = authors[0],
                    Category = categories[0],
                    Tags = new List<Tag>(){tags[0]}
                }
            };
            _dbContext.AddRange(posts);
            _dbContext.SaveChanges();
            return posts;
        }
    }
}
