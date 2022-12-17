using Microsoft.AspNetCore.Mvc;

namespace CQRS_Design_Pattern.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
