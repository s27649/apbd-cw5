using Tutorial4.Models;
namespace Tutorial4.Databases;

public interface IAnimalDb
{
    IEnumerable<Animal> GetAnimals();
    int CreateAnimal(Animal animal);
    Animal GetAnimal(int id);
    int UpdateAnimal(int id, Animal animal);
    int DeleteAnimal(int id);

}