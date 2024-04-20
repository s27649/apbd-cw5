using Tutorial4.Models;

namespace Tutorial4.Databases;

public interface IVisitDb
{
    IEnumerable<Visit> GetVisit();
    int CreateVisit(Visit visit);
}