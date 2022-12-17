namespace CQRS_Design_Pattern.DAL.Entities
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int IdentityNumber { get; set; }
        public string PoliclinicName { get; set; }//poliklinik adı
        public string HospitalName { get; set; }

        public int PatientNumber { get; set; } //hasta sayısı
        public string RegistrationNumber { get; set; } //sicil no


    }
}
