using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlantCatalogAPI_Shubham.Models;

namespace PlantCatalogAPI_Shubham.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlantsController : ControllerBase
{
    private static List<Plant> plants = new List<Plant>
    {
        new Plant { Id = 1, Name = "Snake Plant", Type = "Succulent", IsIndoor = true },
        new Plant { Id = 2, Name = "Rose", Type = "Flower", IsIndoor = false }
    };

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(plants);
    }

    [HttpGet("indoor")]
    public IActionResult GetIndoorPlants()
    {
        var indoor = plants.Where(p => p.IsIndoor).ToList();
        return Ok(indoor);
    }
}