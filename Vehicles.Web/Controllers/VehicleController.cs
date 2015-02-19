using System.Web.Mvc;
using Vehicles.Model;
using Vehicles.Web.Models.ViewModels;
using Vehicles.Web.VehicleService;

namespace Vehicles.Web.Controllers
{
    public class VehicleController : Controller
    {
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Vehicle vehicle)
        {
            var svc = new VehicleServiceClient();
            svc.AddVehicle(vehicle);
            svc.Close();

            return Details(vehicle);
        }

        public ActionResult DisplayAll()
        {
            var svc = new VehicleServiceClient();
            var vehicles = svc.GetAllVehicles();
            svc.Close();

            return View(vehicles);
        }

        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(SearchViewModel model)
        {
            var svc = new VehicleServiceClient();
            var vehicle = svc.GetVehicle(model.Id);
            svc.Close();

            if (vehicle == null)
            {
                ViewBag.Message = "There are no results for vehicle id: " + model.Id;
                return View();
            }

            return Details(vehicle);
        }

        public ActionResult Details(Vehicle vehicle)
        {
            return View("Details", vehicle);
        }
    }
}