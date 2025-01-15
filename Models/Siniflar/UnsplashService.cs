using System.Net.Http;
using System.Threading.Tasks;
using System.Configuration;

namespace triptravel.Models.Siniflar
{
    public class UnsplashService
    {
        private readonly string _accessKey = ConfigurationManager.AppSettings["UnsplashAccessKey"];
        private readonly string _baseUrl = ConfigurationManager.AppSettings["UnsplashBaseUrl"];

        public async Task<string> GetCarImagesAsync()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Client-ID {_accessKey}");
                var response = await client.GetAsync($"{_baseUrl}/search/photos?query=car&per_page=10");

                return response.IsSuccessStatusCode
                    ? await response.Content.ReadAsStringAsync()
                    : null;
            }
        }
    }
}
