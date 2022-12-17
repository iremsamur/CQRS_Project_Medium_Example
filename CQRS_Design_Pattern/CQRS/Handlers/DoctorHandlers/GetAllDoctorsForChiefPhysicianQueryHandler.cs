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
    //crud işleminden listeleme işleminin yazıldığı handler sınıfı
    //başkheminin tüm doktor bilgilerini listelemesi
    public class GetAllDoctorsForChiefPhysicianQueryHandler : IRequestHandler<GetAllDoctorForChiefPhysicianQuery, List<GetAllDoctorsForChiefPhysicianQueryResult>>
        //Handle metodunun otomatik gelebilmesi için
        //mediatR ile IRequestHandler'dan miras alır.
        //Bu içerisine parametrelerin tutulacağı query sınıfını alır. Yani mediatR'deki request sınıfı olur. ikinci olarak ise
        //gelen sonuçların tutulacağı result sınıfını alır.
    {
        private readonly Context _context;

        public GetAllDoctorsForChiefPhysicianQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllDoctorsForChiefPhysicianQueryResult>> Handle(GetAllDoctorForChiefPhysicianQuery request, CancellationToken cancellationToken)
        {
            return await _context.Doctors.Select(x =>
             new GetAllDoctorsForChiefPhysicianQueryResult
             {
                 DoctorID = x.DoctorID,
                 //sol taraf result sınıfından gelen proplar iken,
                 //sağ taraf Doctor entitiy'si yani 
                 //veritabanından gelen proplar olur
                 Name = x.Name,
                 Surname = x.Surname,
                 PoliclinicName = x.PoliclinicName,
                 HospitalName = x.HospitalName,
                 PatientNumber = x.PatientNumber,
                 RegistrationNumber = x.RegistrationNumber


             }).AsNoTracking().ToListAsync();
        }
    }
}
