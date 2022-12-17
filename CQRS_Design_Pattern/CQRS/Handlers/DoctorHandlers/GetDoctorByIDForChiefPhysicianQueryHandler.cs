using CQRS_Design_Pattern.CQRS.Queries.DoctorQueries;
using CQRS_Design_Pattern.CQRS.Results.DoctorResults;
using CQRS_Design_Pattern.DAL.Context;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Design_Pattern.CQRS.Handlers.DoctorHandlers
{
    public class GetDoctorByIDForChiefPhysicianQueryHandler : IRequestHandler<GetDoctorByIDForChiefPhysicianQuery, GetDoctorByIDForChiefPhysicianQueryResult>
    {
        private readonly Context _context;

        public GetDoctorByIDForChiefPhysicianQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetDoctorByIDForChiefPhysicianQueryResult> Handle(GetDoctorByIDForChiefPhysicianQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Doctors.FindAsync(request.DoctorID);
            return new GetDoctorByIDForChiefPhysicianQueryResult
            {
                DoctorID = values.DoctorID,
         
                Name = values.Name,
                Surname = values.Surname,
                PoliclinicName = values.PoliclinicName,
                HospitalName = values.HospitalName,
                PatientNumber = values.PatientNumber,
                RegistrationNumber = values.RegistrationNumber

            };
        }
    }
}
