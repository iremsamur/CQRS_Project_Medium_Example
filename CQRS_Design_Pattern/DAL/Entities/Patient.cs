namespace CQRS_Design_Pattern.DAL.Entities
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int IdentityNumber { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string RegisteredHealthProblems { get; set; }
        public string NumberOfActiveAppointments { get; set; }

    }
}
