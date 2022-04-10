using System;
using CleanArchitecture.Modules;
using Domain.UseCases;
using Ninject;

namespace CleanArchitecture
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel(new WeatherModule());
            var useCase = kernel.Get<GetWeatherInteractor>();
            while (true)
            {
                Console.WriteLine($"--Введите название города (на английском языке), погоду которого хотите узнать--");
                string city = Console.ReadLine();
                var weather = useCase.Handle(city);
                Console.WriteLine($"Погода для города {city}:");
                Console.WriteLine($"Долгота: {weather.Lon}°");
                Console.WriteLine($"Широта: {weather.Lat}°");
                Console.WriteLine($"Описание: {weather.Description}");
                Console.WriteLine($"Температура: {weather.Temperature}°C");
                Console.ReadLine();
            }
        }
    }
}
