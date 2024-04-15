using Tutorial4.Models;

namespace Tutorial4.Database;

public class StaticData
{
    public static List<Animal> animals= new()
    {
        new Animal() { Id = 1, Name = "Jack", Category = "Pies", Weight = 5, Color = "białyy"},
        new Animal() { Id = 2, Name = "Nika", Category = "Kot", Weight = 3.2, Color = "szary"},
        new Animal() { Id = 3, Name = "Sam", Category = "Pies", Weight = 10.3, Color = "brązowy"},
    };
    
    public IEnumerable<Animal> GetAnimal()
    {
        return animals;
    }

    public int CreateAnimal(Animal animal)
    {
        animals.Add(animal);
        return 1;
    }

    public Animal GetAnimal(int id)
    {
        return animals.Find(animal => animal.Id == id);
    }

    public int UpdateAnimal(int id, Animal animal)
    {
        var updatingAnimal = animals.Find(animal => animal.Id == id);
        animals.Remove(updatingAnimal);
        animals.Add(animal);
        return 1;
    }

    public int DeleteAnimal(int id)
    {
        animals.RemoveAll(animal=>animal.Id == id);
        return 1;
    }
}