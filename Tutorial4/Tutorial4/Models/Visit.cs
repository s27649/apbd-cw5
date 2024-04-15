namespace Tutorial4.Models;

public class Visit
{
    public DateTime Date_Visit { get; set; }
    public Animal Animal { get; set; }
    public string  Description{ get; set; }
    public Decimal Price{ get; set; }
    
}