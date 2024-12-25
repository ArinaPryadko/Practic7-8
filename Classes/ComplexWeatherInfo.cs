using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.DataModel;

namespace WpfApp2.Classes
{
    public class ComplexWeatherInfo
    {
        private string _time;

        public string Time
        {
            get { return _time; }
            set 
            { 
                _time = value ?? throw 
                    new ArgumentNullException(nameof(_time));
            }
        }

        private Type_of_weather _weather;
        public Type_of_weather Weather
        {
            get { return _weather; }
            set 
            {
                _weather = value ?? throw
                    new ArgumentNullException(nameof(_weather));
            }
        }

        public double Temperature { get; set; }
        public double Humidity { get; set;}
        public ComplexWeatherInfo() { }

        public ComplexWeatherInfo(
            string time,
            Type_of_weather weather, 
            double temperature, 
            double humidity)
        {
            Time = time;
            Weather = weather;
            Temperature = temperature;
            Humidity = humidity;
        }
    }
}
