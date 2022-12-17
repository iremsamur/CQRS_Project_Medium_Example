using CQRS_Design_Pattern.CQRS.Commands.DoctorCommands;
using CQRS_Design_Pattern.DAL.Context;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Design_Pattern.CQRS.Handlers.DoctorHandlers
{
    public class RemoveDoctorCommandHandler : IRequestHandler<RemoveDoctorCommand>
    {
        private readonly Context _context;

        public RemoveDoctorCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(RemoveDoctorCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Doctors.Find(request.DoctorID);//silinecek verileri bul
            _context.Doctors.Remove(values);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
