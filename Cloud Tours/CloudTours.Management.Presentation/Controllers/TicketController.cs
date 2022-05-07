using CloudTours.Management.Application.Trips;
using CloudTours.Management.Presentation.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CloudTours.Management.Presentation.Controllers
{
    public class TicketController : Controller
    {
        private ITripService tripService;

        public TicketController(ITripService tripService)
        {
            this.tripService = tripService;
        }
        public IActionResult Index()
        {
            return View();
        }
        //public async Task< IActionResult> Add (int id)
        //{

        //    if (await FakeTripService.IsExist(id))
        //    {
        //        var trip = await FakeTripService.GetTripById(id);
        //        return Json("Bilet Alındı");
        //    }
        //    return Json("Bilet Alındı");
        //}
    }
}
