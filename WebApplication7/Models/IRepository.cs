namespace WebApplication7.Models;

public interface IRepository
{
    IEnumerable<Pie> AllPies { get;  }
    IEnumerable<Pie> PiesOfTheWeek { get; }
    Pie? GetPieById(int id);
}