using CQRS_Design_Pattern.CQRS.Results.DoctorResults;
using MediatR;

namespace CQRS_Design_Pattern.CQRS.Queries.DoctorQueries
{
   
    //Başhekim için id'ye göre doktor bilgilerini getirme
    public class GetDoctorByIDForChiefPhysicianQuery : IRequest<GetDoctorByIDForChiefPhysicianQueryResult>
    {
        //Query sınıfı ise, parametreye göre veri getirme yapılacağı zaman kullanılır. Bu durumda metodun alacağı parametreyi tutar.
        public int DoctorID { get; set; }

        public GetDoctorByIDForChiefPhysicianQuery(int doctorID)
        {
            DoctorID = doctorID;
        }
    }
}
