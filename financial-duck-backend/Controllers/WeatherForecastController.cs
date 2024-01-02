using financial_duck_backend.Infra.Context;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace financial_duck_backend.Controllers;
[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{

    private readonly ILogger<WeatherForecastController> _logger;
    public DBContext a;
    public WeatherForecastController(ILogger<WeatherForecastController> logger, DBContext context)
    {
        a = context;
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public ICollection<object> Get()
    {
        return a._randomCollection.Find(Builders<object>.Filter.Eq("category", "Nome da Categoria")).ToList();
    }
}
