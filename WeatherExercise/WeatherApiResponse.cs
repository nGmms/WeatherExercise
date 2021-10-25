using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherExercise
{
    public class WeatherApiResponse
    {
        [JsonProperty("location")]
        public WeatherApiLocation Location { get; set; }

        [JsonProperty("current")]
        public WeatherApiLocation Current { get; set; }
    }
}
