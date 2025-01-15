using System.Threading.Tasks;
using System.Web.Mvc;
using triptravel.Models.Siniflar; // UnsplashService sınıfını kullanmak için

namespace triptravel.Controllers
{
    public class UnsplashServiceController : Controller
    {
        // GET: UnsplashService
        public async Task<ActionResult> Index()
        {
            // UnsplashService'i çağır
            var unsplashService = new UnsplashService();
            var carImagesJson = await unsplashService.GetCarImagesAsync();

            // API’den gelen veriyi View'e gönder
            ViewBag.CarImagesJson = carImagesJson;

            return View();
        }
    }
}
