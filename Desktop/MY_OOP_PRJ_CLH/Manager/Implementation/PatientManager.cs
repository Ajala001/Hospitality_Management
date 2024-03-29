using System.Runtime.CompilerServices;

class PatientManager : IPatientManager
{
    static List<Patient> patients = new List<Patient>();

    public void AddPatient(Patient patient)
    {
        if (!IsPatientInList(patient))
        {
            patients.Add(patient);
            Console.WriteLine("Rgistered successfully.");
            DisplayPatientID(patient.Gmail);
        }
        else
        {
            Console.WriteLine($"Patient with email {patient.Gmail} already exists.");
            return;
        }
    }

    static bool IsPatientInList(Patient patient)
    {
        foreach (var patientItem in patients)
        {
            if (patientItem.Gmail == patient.Gmail)
            {
                return true;
            }
        }
        return false;
    }

    public void DisplayPatientID(string gmail)
    {
        foreach (var patientItem in patients)
        {
            if (patientItem.Gmail == gmail)
            {
                if (patientItem.Gender == 1)
                {
                    Console.WriteLine($"Mr. {patientItem.FirstName} {patientItem.LastName}, Your ID is {patientItem.PatientID}");
                }
                else if (patientItem.Gender == 2)
                {
                    Console.WriteLine($"Mrs. {patientItem.FirstName} {patientItem.LastName}, Your ID is {patientItem.PatientID}");
                }
            }
        }
    }

    public static bool AuthenticatePatient(Patient patient, string patientID, string patientPass)
    {
        if(!IsPatientInList(patient))
        {
            Console.WriteLine("Your Details Dont't Exist on Our System!!!");
            return false;
        }else
        {
            if(patient.PatientID == patientID && patient.Password == patientPass)
            {
                Console.WriteLine("Login Successful.");
                return true;
            }else
            {
                Console.WriteLine("Invalid Credentials!!!");
                return false;
            }
        }
    }

    public static List<Patient> ListOfPatients()
    {
        if (patients != null)
        {
            return patients;
        }
        return null;
    }

    public static Patient GetpatientByID(string patientID)
    {
        if (patients != null)
        {
            foreach (var patientItem in patients)
            {
                if (patientItem.PatientID == patientID)
                {
                    return patientItem;
                }
            }
        }
        return null;
    }

    public static void SetPatientStatus(Patient patient)
    {
        foreach (var patientItem in ListOfPatients())
        {
            if (patientItem.PatientID == patient.PatientID)
            {
                patient.BookAppointment = true;
            }
        }
    }
}