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
        // Open Weather map API key (note: no access to disposable account anymore)
        private readonly string apiKey = "fc138847386ac470bb11af28130be1c2";

        /*
        Important quote regarding the geocoding used in this code:
 
        "Please use Geocoder API if you need automatic convert city names and zip-codes to
        geo coordinates and the other way around.

        Please note that API requests by city name, zip-codes and city id have been
        deprecated. Although they are still available for use, bug fixing and updates are
        no longer available for this functionality."
         */

        // URL scheme:  https://api.openweathermap.org/data/2.5/weather?q={city name}&appid={API key}
        private string requestUrl = "https://api.openweathermap.org/data/2.5/weather";

        public MainWindow()
        {
            InitializeComponent();
            UpdateData("Berlin"); // start app with a default city (default textBox text "Berlin" was set separately)
        }

        // Update the UI with the weather data
        public void UpdateData(string city)
        {
            WeatherMapResponse result = GetWeatherData(city);

            string finalImage = "Sun.png"; // default image
            string currentWeather = result.weather[0].description.ToLower();

            /*
            OpenWeatherMap API Weather Conditions (example clouds)
            https://openweathermap.org/weather-conditions
            Group 80x: Clouds
            801 	Clouds 	few clouds: 11-25% 	
            802 	Clouds 	scattered clouds: 25-50% 	
            803 	Clouds 	broken clouds: 51-84% 	
            804 	Clouds 	overcast clouds: 85-100% 	
            */

            // Set the background image according to the weathercondition     
            if (currentWeather.Contains("snow") || currentWeather.Contains("sleet"))
            {
                finalImage = "Snow.png";
            }
            else if (currentWeather.Contains("rain"))
            {
                finalImage = "Rain.png";
            }
            else if (currentWeather.Contains("overcast clouds") || currentWeather.Contains("broken clouds") || currentWeather.Contains("scattered clouds"))
            {
                finalImage = "Cloud.png";
            }
            backgoundImage.ImageSource = new BitmapImage(new Uri("Images/" + finalImage, UriKind.Relative));

            // Set the values to the XAML labels
            labelTemperature.Content = result.main.temp.ToString("F1") + "°C";
            labelInfo.Content = result.weather[0].description;
        }

        // Get Weather Data from OpenWeatherMap API by city name
        public WeatherMapResponse GetWeatherData(string city)
        {
            HttpClient httpClient = new HttpClient();
            var finalUri = requestUrl + "?q=" + city + "&appid=" + apiKey + "&units=metric";
            HttpResponseMessage httpResponse = httpClient.GetAsync(finalUri).Result; // Async ist asynchron und blockiert nicht den Hauptthread während der Anfrage an den Server
            string response = httpResponse.Content.ReadAsStringAsync().Result;
            // Parse JSON to WeatherMapResponse object
            WeatherMapResponse weatherMapResponse = JsonConvert.DeserializeObject<WeatherMapResponse>(response);
            return weatherMapResponse;
        }

        // Button Click Event Handler
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string query = textBoxQuery.Text;
            UpdateData(query);
        }

    }
}
