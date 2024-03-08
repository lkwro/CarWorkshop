using Microsoft.AspNetCore.Mvc;

namespace CarWorkshop.MVC.Controllers
{
    public class CarWorkshopController:Controller
    {
        [HttpPost]
        public IActionResult Create(Domain.Entities.CarWorkshop carWorkshop)
        {

        }
    }
}
