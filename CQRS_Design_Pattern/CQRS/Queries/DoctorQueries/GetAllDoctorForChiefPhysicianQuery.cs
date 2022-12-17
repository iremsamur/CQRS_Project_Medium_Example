using CQRS_Design_Pattern.CQRS.Results.DoctorResults;
using MediatR;
using System.Collections.Generic;

namespace CQRS_Design_Pattern.CQRS.Queries.DoctorQueries
{
    //Başhekimin göreceği doktor bilgileri için
    public class GetAllDoctorForChiefPhysicianQuery : IRequest<List<GetAllDoctorsForChiefPhysicianQueryResult>>
    {
        //MediatR ile bütün verilerin listelenmesi için query sınıfına 
        //istek gönderilecek yani mediatR'de istek karşılığı olan sınıf
        //query olacağı için IRequest'ten miras alır.
    }
}
