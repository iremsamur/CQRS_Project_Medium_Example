using MediatR;

namespace CQRS_Design_Pattern.CQRS.Commands.DoctorCommands
{
    //silme işlemi
    public class RemoveDoctorCommand:IRequest
    {
        public RemoveDoctorCommand(int doctorID)
        {
            DoctorID = doctorID;
        }

        public int DoctorID { get; set; }
    }
}
