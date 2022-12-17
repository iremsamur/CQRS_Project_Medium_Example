namespace CQRS_Design_Pattern.CQRS.Results.DoctorResults
{
    //Hastanın doktorun bilgilerinden görmesi gereken alanların
    //listelenmesi için
    public class GetAllDoctorsForPatientQueryResult
    {
        //crud operasyonunundaki listeleme işlemini yaparken
        //Doctor entity'si içinden hangileri
        //listelenecekse, sadece gerekli olan prop'ların
        //tutulduğu sınıftır
        public string Name { get; set; }
        public string Surname { get; set; }
        
        public string PoliclinicName { get; set; }
        public string HospitalName { get; set; }
        //Hastanın sadece doktorun bu bilgilerini görmesi yeterli olur.


    }
}
