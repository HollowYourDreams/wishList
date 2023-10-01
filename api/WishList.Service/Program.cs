using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http.HttpResults;
using WishList.Service.Controllers;
using WishList.Contracts.Interfaces;
using WishList.Service.Services;

namespace WishList.Service
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddScoped<IWishService, WishService>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();


            app.Run();
        }
    }
}


//public static class WeatherForecastEndpoints
//{
//	public static void MapWeatherForecastEndpoints (this IEndpointRouteBuilder routes)
//    {
//        var group = routes.MapGroup("/api/WeatherForecast").WithTags(nameof(WeatherForecast));

//        group.MapGet("/", () =>
//        {
//            return new [] { new WeatherForecast() };
//        })
//        .WithName("GetAllWeatherForecasts")
//        .WithOpenApi();

//        group.MapGet("/{id}", (int id) =>
//        {
//            //return new WeatherForecast { ID = id };
//        })
//        .WithName("GetWeatherForecastById")
//        .WithOpenApi();

//        group.MapPut("/{id}", (int id, WeatherForecast input) =>
//        {
//            return TypedResults.NoContent();
//        })
//        .WithName("UpdateWeatherForecast")
//        .WithOpenApi();

//        group.MapPost("/", (WeatherForecast model) =>
//        {
//            //return TypedResults.Created($"/api/WeatherForecasts/{model.ID}", model);
//        })
//        .WithName("CreateWeatherForecast")
//        .WithOpenApi();

//        group.MapDelete("/{id}", (int id) =>
//        {
//            //return TypedResults.Ok(new WeatherForecast { ID = id });
//        })
//        .WithName("DeleteWeatherForecast")
//        .WithOpenApi();
//    }
//}}