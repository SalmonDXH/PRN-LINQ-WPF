using System.Collections.Generic;
using BusinessObjects;

namespace Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryService iCategoryService;
        public CategoryService() {
            iCategoryService = new CategoryService();
        }

        public List<Category> GetCategories()
        {
            return iCategoryService.GetCategories();
        }
    }
}
