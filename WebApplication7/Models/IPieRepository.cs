namespace WebApplication7.Models;

public interface IPieRepository
{
    IEnumerable<Pie> AllPies { get;  }
    IEnumerable<Pie> PiesOfTheWeek { get; }
    Pie? GetPieById(int id);
}