using CQRS_Design_Pattern.CQRS.Commands.DoctorCommands;
using CQRS_Design_Pattern.DAL.Context;
using CQRS_Design_Pattern.DAL.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Design_Pattern.CQRS.Handlers.DoctorHandlers
{
    public class CreateDoctorCommandHandler : IRequestHandler<CreateDoctorCommand>//Ekleme işleminde eklenecek parametreleri UI'dan tutan sınıf command olduğu için commandı veririz.
    {

        private readonly Context _context;

        public CreateDoctorCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateDoctorCommand request, CancellationToken cancellationToken)
        {
            _context.Doctors.Add(new Doctor
            {
                Name=request.Name,
                Surname=request.Surname,
                PoliclinicName=request.PoliclinicName,
                HospitalName=request.HospitalName,
                IdentityNumber=request.IdentityNumber,
                PatientNumber=request.PatientNumber,
                RegistrationNumber=request.RegistrationNumber
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
            
        }
    }
}
