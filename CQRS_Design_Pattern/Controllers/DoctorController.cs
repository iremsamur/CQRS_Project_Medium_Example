using CQRS_Design_Pattern.CQRS.Commands.DoctorCommands;
using CQRS_Design_Pattern.CQRS.Queries.DoctorQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CQRS_Design_Pattern.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IMediator _mediator;

        public DoctorController(IMediator mediator)
        {
            _mediator = mediator;
        }


        //tüm verileri listeleme başhekim için
        public async Task<IActionResult> GetAllDoctorsForChiefPhysician()
        {
            var values = await _mediator.Send(new GetAllDoctorForChiefPhysicianQuery());
            //Benim requestim Query'de olduğu için query'i parametre olarak send metoduna veriyorum.
            //Böylece verileri bana query üzerinden getirir.
            return View(values);

        }
        public async Task<IActionResult> GetAllDoctorsForPatient()
        {
            var values = await _mediator.Send(new GetAllDoctorForPatientQuery());
            
            return View(values);

        }
        ////tüm verileri listeleme hasta için

        //doktor ekleme
        //ekleme işlemi
        [HttpGet]
        public IActionResult AddDoctor()
        {
            return View();
        }
        //ekleme işlemi
        [HttpPost]
        public async Task<IActionResult> AddDoctor(CreateDoctorCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("GetAllDoctorsForChiefPhysician");

        }
        //doktor silme
        //silme
        public async Task<IActionResult> DeleteDoctor(int id)
        {
            await _mediator.Send(new RemoveDoctorCommand(id));
            return RedirectToAction("GetAllDoctorsForChiefPhysician");

        }
        //güncelleme
        [HttpGet]
        public async Task<IActionResult> UpdateDoctor(int id)
        {
            var values = await _mediator.Send(new GetDoctorByIDForChiefPhysicianQuery(id));
            return View(values);
        }
        //güncelleme işlemi
        [HttpPost]
        public async Task<IActionResult> UpdateDoctor(UpdateDoctorCommand command)
        {
            var values = await _mediator.Send(command);
            return RedirectToAction("GetAllDoctorsForChiefPhysician");
        }

    }
}
