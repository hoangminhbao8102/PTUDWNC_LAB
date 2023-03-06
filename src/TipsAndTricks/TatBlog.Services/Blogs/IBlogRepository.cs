using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatBlog.Core.Contracts;
using TatBlog.Core.DTO;
using TatBlog.Core.Entities;

namespace TatBlog.Services.Blogs
{
    public interface IBlogRepository
    {
        Task<Post> GetPostAsync(int year, int month, string slug, CancellationToken cancellationToken = default);

        Task<IList<Post>> GetPopularArticlesAsync(int numPosts, CancellationToken cancellationToken = default);

        Task<bool> IsPostSlugExistedAsync(int postId, string slug, CancellationToken cancellationToken = default);

        Task IncreaseViewCountAsync(int postId, CancellationToken cancellationToken = default);

        Task<IList<CategoryItem>> GetCategoriesAsync(bool showOnMenu = false, CancellationToken cancellationToken = default);

        Task<IPagedList<TagItem>> GetPagedTagsAsync(IPagingParams pagingParams, CancellationToken cancellationToken = default);

        Task<Tag> GetTagAsync(string slug, CancellationToken cancellationToken = default);

        Task<IList<TagItem>> GetTagAsync(int Id, CancellationToken cancellationToken = default);

        Task DeleteTagIDAsync(int id, CancellationToken cancellationToken = default);

        Task<Category> GetCategoryAsync(string slug, CancellationToken cancellationToken = default);

        Task<IList<Category>> GetCategoryIDAsync(int Id, CancellationToken cancellationToken = default);

        Task<IList<Category>> GetCategoryUpdateAsync(int id, CancellationToken cancellationToken = default);

        Task GetCategoryDeleleAsync(int id, CancellationToken cancellationToken = default);

        Task<bool> IsCategorySlugExistedAsync(int categoryId, string slug, CancellationToken cancellationToken = default);

        Task<IPagedList<CategoryItem>> GetPagedCategoryAsync(IPagingParams pagingParams, CancellationToken cancellationToken = default);

    }
}
