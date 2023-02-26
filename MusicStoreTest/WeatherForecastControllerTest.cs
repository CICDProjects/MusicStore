using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MusicStore.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreTest
{
    public class WeatherForecastControllerTest
    {
        public void Test_WeatherForecast()
        {
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .BuildServiceProvider();
            var factory = serviceProvider.GetService<ILoggerFactory>();
            var logger = factory.CreateLogger<WeatherForecastController>();
            WeatherForecastController weatherForecastController = new WeatherForecastController(logger);
            Assert.NotNull(weatherForecastController);
            Assert.NotNull(weatherForecastController.Get());
            

        }
    }
}
