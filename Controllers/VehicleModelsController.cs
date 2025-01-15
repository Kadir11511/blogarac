using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using triptravel.Models.Siniflar;

namespace triptravel.Controllers
{
    public class VehicleModelsController : Controller
    {
        private static List<VehicleModel> vehicles = new List<VehicleModel>
        {
            new VehicleModel { Id = 1, Name = "Tesla Model X", Description = "Otonom ve lüks bir SUV.", ImageUrl = "tesla_model_x.jpg" },
            new VehicleModel { Id = 2, Name = "BMW i7", Description = "Elektrikli ve çevre dostu.", ImageUrl = "bmw_i7.jpg" },
            new VehicleModel { Id = 3, Name = "Mercedes EQS", Description = "Konfor ve teknoloji bir arada.", ImageUrl = "mercedes_eqs.jpg" }
        };

        [HttpGet]
        public JsonResult GetVehicles()
        {
            return Json(vehicles, JsonRequestBehavior.AllowGet);
        }
    }
}
