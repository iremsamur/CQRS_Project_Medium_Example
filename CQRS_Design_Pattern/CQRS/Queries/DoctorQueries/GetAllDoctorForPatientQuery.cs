using CQRS_Design_Pattern.CQRS.Results.DoctorResults;
using MediatR;
using System.Collections.Generic;

namespace CQRS_Design_Pattern.CQRS.Queries.DoctorQueries
{
    //Hastanın göreceği doktor bilgileri için mediatR istek sınıfı
    public class GetAllDoctorForPatientQuery:IRequest<List<GetAllDoctorsForPatientQueryResult>>
    {
    }
}
