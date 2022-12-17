using MediatR;

namespace CQRS_Design_Pattern.CQRS.Commands.DoctorCommands
{
    //doktor kayıt işlemi
    //Bu sınıf create işleminde kullanılacak parametreleri tutar.
    public class CreateDoctorCommand : IRequest
        //ekleme işlemi için herhangi bir parametre tutacak olan ayrı bir
        //query sınıfına ihtiyaç yok o yüzden sadece IRequestten miras alır

       
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int IdentityNumber { get; set; }
        public string PoliclinicName { get; set; }//poliklinik adı
        public string HospitalName { get; set; }

        public int PatientNumber { get; set; } //hasta sayısı
        public string RegistrationNumber { get; set; } //sicil no

    }
}
