using Tutorial4.Databases;
using Tutorial4.Models;

namespace Tutorial4.Services;

public class VisitService : IVisitService
{
    public readonly IVisitDb _IVisitDb;
    
    public VisitService(IVisitDb visitDb)
    {
        _IVisitDb = visitDb;
    }
    
    public IEnumerable<Visit> GetVisit()
    {
        return _IVisitDb.GetVisit();
    }

    public int CreateVisit(Visit visit)
    {
        return _IVisitDb.CreateVisit(visit);
    }
}