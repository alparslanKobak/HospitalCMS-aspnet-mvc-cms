using App.Data.Entity;

namespace App.Web.Mvc.Services
{
	public interface ICategoryService
	{
		Task<List<Category>?> GetCategories(string? searchKey = null);
		int QueryCount { get; set; }
	}
}
