using PetCareSystem.Models;
using PetCareSystem.Models.Services;
using PetCareSystem.Services;

class Program
{
    static void Main()
    {
        var owner = new Owner("Alice", "555-2013");
        var pet = new Pet("Bobby", "Dog", 7);
        owner.AddPet(pet);

        var service = new Grooming();
        var appointment = new Appointment
        {
            owner = owner,
            pet = pet,
            service = service,
            Date = DateTime.Now.AddDays(1)
        };
        var manager = new AppointmentManager();
        manager.AddAppointment(appointment);

        Console.WriteLine("n=== Appointments ===");
        manager.ShowAppointments();
    }
}