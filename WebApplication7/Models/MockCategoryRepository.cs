namespace WebApplication7.Models;

public class MockCategoryRepository : ICategoryRepository
{
    public IEnumerable<Category> AllCategories => new List<Category>()
    {
        new Category() { CategoryId = 1, CategoryName = "Fruit Pies", CategoryDescription = "All Fruit-Pies" },
        new Category() { CategoryId = 2, CategoryName = "Cheese Cake", CategoryDescription = "Cheesy all the way" },
        new Category()
        {
            CategoryId = 3, CategoryName = "Seasonal Pies", CategoryDescription = "Get in the mood for a seasonal Pie"
        },
    };
}