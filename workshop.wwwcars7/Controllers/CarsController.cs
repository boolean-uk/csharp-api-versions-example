using Microsoft.AspNetCore.Mvc;
using workshop.wwwcars7.Data;
using workshop.wwwcars7.Models;

namespace workshop.wwwcars7.Controllers;

[ApiController]
[Route("[controller]")]
public class CarsController : ControllerBase
{        
    [HttpGet(Name = "Cars")]
    public IEnumerable<Car> Get()
    {
        return CarsCollection.GetCars();
    }
}
