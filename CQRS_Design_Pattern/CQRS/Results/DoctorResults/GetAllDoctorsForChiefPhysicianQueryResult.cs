namespace CQRS_Design_Pattern.CQRS.Results.DoctorResults
{
    //Hastane başhekiminin hangi bilgileri görmeye ihtiyacı var.
    //Onları tutan sınıf
    public class GetAllDoctorsForChiefPhysicianQueryResult
    {
        //başhekimin sadece şu bilgileri görmesi gereksin.
        public int DoctorID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PoliclinicName { get; set; }
        public string HospitalName { get; set; }

        public int PatientNumber { get; set; } 
        public string RegistrationNumber { get; set; } 

    }
}
