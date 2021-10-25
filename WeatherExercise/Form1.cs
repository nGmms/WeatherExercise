using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherExercise
{
    public partial class mainForm : Form
    {

          

        public mainForm()   
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
        private async Task getWeatherDataAsync() 
        {
            using (var httpClient = new HttpClient())
            {
                var url = $"Example.com/theEndpoint";
                var contentString = await httpClient.GetStringAsync(url);
                Console.WriteLine(contentString);
            }
        }
        public static async Task<WeatherApiResponse> GetWeatherData() 
        {
            using (var httpClient = new HttpClient()) 
            {
                var url = http://api.weatherapi.com/v1/current.json?key=bb36db8746ff4aa5bcc105326212510&q=Engomi&aqi=no;
                var response = await httpClient.GetAsync(url);
                var contentString = await response.Content.ReadAsStringAsync();

                return contentString;
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var weatherData = await GetWeatherData();
            MessageBox.Show(weatherData);
        }
    }
}
