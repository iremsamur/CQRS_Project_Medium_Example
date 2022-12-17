using CQRS_Design_Pattern.CQRS.Queries.DoctorQueries;
using CQRS_Design_Pattern.CQRS.Results.DoctorResults;
using CQRS_Design_Pattern.DAL.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Design_Pattern.CQRS.Handlers.DoctorHandlers
{
    public class GetAllDoctorsForPatientQueryHandler : IRequestHandler<GetAllDoctorForPatientQuery, List<GetAllDoctorsForPatientQueryResult>>
    {
        private readonly Context _context;

        public GetAllDoctorsForPatientQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllDoctorsForPatientQueryResult>> Handle(GetAllDoctorForPatientQuery request, CancellationToken cancellationToken)
        {
            return await _context.Doctors.Select(x =>
             new GetAllDoctorsForPatientQueryResult
             {


                 Name = x.Name,
                 Surname = x.Surname,
                 PoliclinicName = x.PoliclinicName,
                 HospitalName = x.HospitalName,



             }).AsNoTracking().ToListAsync();
        }
    }
}
