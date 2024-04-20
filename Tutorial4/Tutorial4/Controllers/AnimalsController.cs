using Microsoft.AspNetCore.Mvc;
using Tutorial4.Models;
using Tutorial4.Services;

namespace Tutorial4.Controllers;

[ApiController]
[Route("/animals-controller")]
public class AnimalsController : ControllerBase
{
    private readonly IAnimalService _animalService;

    public AnimalsController(IAnimalService animals)
    {
        _animalService = animals;
    }
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var _animals = _animalService.GetAnimals();
        return Ok(_animals);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetAnimal(int id)
    {
        var animals = _animalService.GetAnimal(id);
        if (animals == null)
        {
            return NotFound($"Animal with id {id} doesn't exist");
        }
        return Ok(animals);
    }
    
    [HttpPost]
    public IActionResult AddAnimal(Animal animal)
    {
        var animals = _animalService.CreateAnimal(animal);
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        var animals = _animalService.UpdateAnimal(id,animal);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animals = _animalService.DeleteAnimal(id);
        return NoContent();
    }
}