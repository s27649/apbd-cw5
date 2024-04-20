using Microsoft.AspNetCore.Mvc;
using Tutorial4.Models;
using Tutorial4.Services;

namespace Tutorial4.Controllers;

[ApiController]
[Route("/visits-controller")]
public class VisitController : ControllerBase
{
    private readonly IVisitService _visitService;

    public VisitController(IVisitService visitService)
    {
        _visitService = visitService;
    }

    [HttpGet]
    public IActionResult GetVisit()
    {
        var visits = _visitService.GetVisit();
        return Ok(visits);
    }

    [HttpPost]
    public IActionResult CreateVisit(Visit visit)
    {
        var visits = _visitService.CreateVisit(visit);
        return StatusCode(StatusCodes.Status201Created);
    }
}