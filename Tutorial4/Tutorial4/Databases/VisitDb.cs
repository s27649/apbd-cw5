using Tutorial4.Models;

namespace Tutorial4.Databases;

public class VisitDb: IVisitDb
{
    private List<Visit> _visits = new List<Visit>()
    {
        new Visit()
        {
            Date_Visit = new DateTime(2023, 04, 10),
            Animal = AnimalDb.animals[1],
            Description = "description1",
            Price = 400
        }
    };
    
    public IEnumerable<Visit> GetVisit()
    {
        return _visits;
    }

    public int CreateVisit(Visit visit)
    {
       _visits.Add(visit);
       return 1;
    }
}