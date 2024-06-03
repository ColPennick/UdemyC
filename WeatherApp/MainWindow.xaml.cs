using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;

namespace WeatherApp
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Open Wweather map API key
        private readonly string apiKey = "fc138847386ac470bb11af28130be1c2";

        // https://api.openweathermap.org/data/2.5/weather?q={city name}&appid={API key}
        private string requestUrl = "https://api.openweathermap.org/data/2.5/weather";

        public MainWindow()
        {
            InitializeComponent();
            WeatherMapResponse result =  GetWeatherData("Paris");


            string finalImage = "Sun.png"; // Fallback Image
            string currentWeather = result.weather[0].main.ToLower();

            if (currentWeather.Contains("snow"))
            {
                finalImage = "Snow.png";
            }
            else if (currentWeather.Contains("rain"))
            {
                finalImage = "Rain.png";
            }
            else if (currentWeather.Contains("cloud"))
            {
                finalImage = "Cloud.png";
            }
            backgoundImage.ImageSource = new BitmapImage(new Uri("Images/"+finalImage,UriKind.Relative));

            labelTemperature.Content = result.main.temp.ToString("F1") + "°C";
            labelInfo.Content = result.weather[0].main;


        }
        public WeatherMapResponse GetWeatherData(string city)
        {
            HttpClient httpClient = new HttpClient();

            var finalUri = requestUrl + "?q=" + city + "&appid=" + apiKey + "&units=metric";

            HttpResponseMessage httpResponse = httpClient.GetAsync(finalUri).Result; // Async ist asynchron und blockiert nicht den Hauptthread während der Anfrage an den Server

            string response = httpResponse.Content.ReadAsStringAsync().Result;

            // Parse JSON
            WeatherMapResponse weatherMapResponse = JsonConvert.DeserializeObject<WeatherMapResponse>(response);
            return weatherMapResponse;
        }
    }
}
