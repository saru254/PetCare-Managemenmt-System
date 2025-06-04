namespace PetCareSystem.Services
{
    using PetCareSystem.Models;

    public class AppointmentManager
    {
        private List<Appointment> appointments = new List<Appointment>();
        public void AddAppointment(Appointment appointment)
        {
            appointments.Add(appointment);
            Console.WriteLine("Appointment scheduled successfully.");
        }
        public void ShowAppointments()
        {
            foreach (var appt in appointments)
                appt.DisplayAppointment();
        }
    }
}