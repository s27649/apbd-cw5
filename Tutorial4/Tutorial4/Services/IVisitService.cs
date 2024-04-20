using Tutorial4.Models;

namespace Tutorial4.Services;

public interface IVisitService
{
    IEnumerable<Visit> GetVisit();
    int CreateVisit(Visit visit);
}