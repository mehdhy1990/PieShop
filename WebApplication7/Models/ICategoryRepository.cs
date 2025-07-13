namespace WebApplication7.Models;

public interface ICategoryRepository
{
    IEnumerable<Category> Categories { get; }
}