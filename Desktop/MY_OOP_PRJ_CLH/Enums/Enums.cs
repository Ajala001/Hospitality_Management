namespace enums
{
    public enum UserOptions
    {
        Register = 1,
        Login,
        Exit
    }

    public enum UserRoles
    {
        Doctor = 1,
        Patient,
    }

public enum AdminRoles
{
    Add_Doctor = 1,
    Remove_Doctor,
    View_Doctor_Details,
    View_Patient_Details,
    View_All_Doctors,
    View_Available_Doctors,
    View_Booked_Doctors,
    View_All_Patients,
    ViewDoctorsReport,
    View_Appointment_List,
    Logout
}

public enum DoctorRoles
{
    ViewAppointment = 1,

}

public enum PatientRoles
{
    ScheduleAppointment = 1,
}
}
