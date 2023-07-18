using App.Data;
using App.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Mvc.Services.Concrete
{
	public class CategoryService : ICategoryService
	{
		private readonly AppDbContext _dbContext;

		public int QueryCount { get; set; } = 0;

		public CategoryService(AppDbContext appDbContext)
        {
			_dbContext = appDbContext;
		}

		public async Task<List<Category>?> GetCategories(string? searchKey)
		{
			IQueryable<Category> query = _dbContext.Categories;

			if (!string.IsNullOrWhiteSpace(searchKey))
			{
				query = query.Where(c => c.Name.Contains(searchKey) || c.Description.Contains(searchKey));
			}
			QueryCount++;

			return await query.ToListAsync();
		}
	}
}
