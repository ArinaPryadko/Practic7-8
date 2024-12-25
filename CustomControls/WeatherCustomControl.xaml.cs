using System;
using System.Windows.Controls;
using WpfApp2.Classes;

namespace WpfApp2.CustomControls
{
    /// <summary>
    /// Логика взаимодействия для WeatherCustomControl.xaml
    /// </summary>
    public partial class WeatherCustomControl : UserControl
    {
        private ComplexWeatherInfo _weather;
        public WeatherCustomControl()
        {
            InitializeComponent();
        }
        public WeatherCustomControl(ComplexWeatherInfo complex)
        {
            InitializeComponent();
            Fill(complex);
        }
        public void Fill(ComplexWeatherInfo complex) 
        { 
            _weather = complex ?? throw new ArgumentNullException(nameof(_weather));

            label_Humidity.Content = _weather.Humidity;
            label_Temperature.Content = _weather.Temperature;
            label_Time.Content = _weather.Time;
            label_Type.Content = _weather.Weather.Name;
        }
    }
}
