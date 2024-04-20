using Tutorial4.Databases;
using Tutorial4.Models;

namespace Tutorial4.Services;

public class AnimalService:IAnimalService
{
    private readonly IAnimalDb _IAnimalDb;
    public AnimalService(IAnimalDb animalDb)
    {
        _IAnimalDb = animalDb;
    }

    public IEnumerable<Animal> GetAnimals()
    {
        return _IAnimalDb.GetAnimals();
    }

    public int CreateAnimal(Animal animal)
    {
        return _IAnimalDb.CreateAnimal(animal);
    }

    public Animal GetAnimal(int id)
    {
        return _IAnimalDb.GetAnimal(id);
    }

    public int UpdateAnimal(int id, Animal animal)
    {
        return _IAnimalDb.UpdateAnimal(id, animal);
    }

    public int DeleteAnimal(int id)
    {
        return _IAnimalDb.DeleteAnimal(id);
    }
}