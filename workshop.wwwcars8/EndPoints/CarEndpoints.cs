using Microsoft.AspNetCore.Mvc;
using workshop.wwwcars8.Data;

namespace workshop.wwwcars8.EndPoints
{
    public static class CarEndpoints
    {
        public static void ConfigureCarEndpoints(this WebApplication app)
        {
            var cars = app.MapGroup("cars");
            cars.MapGet("/", GetCars);
            cars.MapGet("/{id}", GetCar);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static IResult GetCars()
        {           
            return TypedResults.Ok(CarsCollection.GetCars());
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static IResult GetCar(int id)
        {
            var car = CarsCollection.GetCar(id);
            return car != null ? TypedResults.Ok(car) : TypedResults.NotFound();
        }
    }
}
