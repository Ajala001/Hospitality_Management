
class Doctor : BaseClass
{
    public string DoctorID {get; set;}
    public int DoctorCount {get; set;}
    static int doctorCount = 0;
    public string DoctorStatus;
    public static string LoggedInDoctor {get; set;}
    public static Dictionary<Patient, string> DoctorsReport {get;} = new Dictionary<Patient, string>();
    public string DoctorFieldOfSpecialization {get; set;}
    public Doctor(string firstName, string lastName, string gmail, string phoneNumber, int gender, string password, string fieldOfSpecialization)
    {
        FirstName = firstName;
        LastName = lastName;
        Gmail = gmail;
        PhoneNumber = phoneNumber;
        Gender = gender;
        DoctorCount = doctorCount + 1;
        DoctorID = "Doc" + DoctorCount;
        doctorCount++;
        Password = password;
        DoctorStatus = "Available";
        DoctorFieldOfSpecialization = fieldOfSpecialization;
    }

    // public Doctor(string userFirstName, string userLastName, int userID, string userEmail, string doctorPassword, string fieldOfSpecialization)
    // {
    //     FirstName = userFirstName;
    //     LastName = userLastName;
    //     UserID = userID;
    //     UserEmail = userEmail;
    //     DoctorCount = doctorCount + 1;
    //     DoctorID = "Doc" + DoctorCount;
    //     doctorCount++;
    //     DoctorPassword = doctorPassword;
    //     DoctorFieldOfSpecialization = fieldOfSpecialization;
    // }
}