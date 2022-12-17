using MediatR;

namespace CQRS_Design_Pattern.CQRS.Commands.DoctorCommands
{
    //güncelleme işlemi
    public class UpdateDoctorCommand:IRequest
    {
        public int DoctorID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PoliclinicName { get; set; }
        public string HospitalName { get; set; }

        public int PatientNumber { get; set; }
        public string RegistrationNumber { get; set; }

    }
}
