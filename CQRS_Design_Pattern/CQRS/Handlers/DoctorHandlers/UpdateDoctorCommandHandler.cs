using CQRS_Design_Pattern.CQRS.Commands.DoctorCommands;
using CQRS_Design_Pattern.DAL.Context;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Design_Pattern.CQRS.Handlers.DoctorHandlers
{
    //güncelleme
  

    public class UpdateDoctorCommandHandler : IRequestHandler<UpdateDoctorCommand>
    {
        private readonly Context _context;

        public UpdateDoctorCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateDoctorCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Doctors.Find(request.DoctorID);
            values.Name = request.Name;
            values.Surname = request.Surname;
         
            values.RegistrationNumber = request.RegistrationNumber;
            values.PatientNumber = request.PatientNumber;
            values.PoliclinicName = request.PoliclinicName;
            values.HospitalName= request.HospitalName;
            values.RegistrationNumber = request.RegistrationNumber;
            await _context.SaveChangesAsync();
            return Unit.Value;

        }
    }
}
