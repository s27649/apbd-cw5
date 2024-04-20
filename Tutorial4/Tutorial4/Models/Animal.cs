namespace Tutorial4.Models;

public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public double Weight { get; set; }
    public string Color { get; set; }
    
    public void Animals(Animal animal)
    {
        Id = animal.Id;
        Name = animal.Name;
        Category = animal.Category;
        Weight = animal.Weight;
        Color = animal.Color;
    }
}