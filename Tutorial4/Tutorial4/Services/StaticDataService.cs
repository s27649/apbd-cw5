using Tutorial4.Database;
using Tutorial4.Models;

namespace Tutorial4.Services;

public class StaticDataService
{
    public readonly StaticData _animal;
    public StaticDataService(StaticData animals)
    {
        _animal = animals;
    }

    public IEnumerable<Animal> GetAnimals()
    {
        return _animal.GetAnimal();
    }

    public int CreateAnimal(Animal animal)
    {
        return _animal.CreateAnimal(animal);
    }

    public Animal GetAnimal(int idAnimal)
    {
        return _animal.GetAnimal(idAnimal);
    }

    public int UpdateAnimal(int id,Animal animal)
    {
        return _animal.UpdateAnimal(id,animal);
    }

    public int DeleteAnimal(int idAnimal)
    {
        return _animal.DeleteAnimal(idAnimal);
    }
}