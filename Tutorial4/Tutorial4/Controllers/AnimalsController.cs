using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;
using Tutorial4.Models;
using Tutorial4.Services;

namespace Tutorial4.Controllers;

[ApiController]
[Route("/animals-controller")]
// [Route("[controller]")]
public class AnimalsController : ControllerBase
{
    private StaticDataService _animals;

    public AnimalsController(StaticDataService animals)
    {
        _animals = animals;
    }
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok(_animals);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetAnimal(int id)
    {
        var animals = _animals.GetAnimal(id);
        if (animals == null)
        {
            return NotFound($"Animal with id {id} doesn't exist");
        }
        return Ok(animals);
    }
    
    [HttpPost]
    public IActionResult AddAnimal(Animal animal)
    {
        var animals = _animals.CreateAnimal(animal);
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        var animals = _animals.UpdateAnimal(id,animal);
        if (animals == null)
        {
            return NotFound($"Animal with id {id} doesn't exist");
        }
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animals = _animals.DeleteAnimal(id);
        if (animals == null)
        {
            return NoContent();
        }
        return NoContent();
    }
}