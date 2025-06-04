namespace PetCareSystem.Models.Services
{
    public class Vaccination : PetService
    {
        public override string ServiceName => "Vaccination";

        public override void PerformService(Pet pet)
        {
            Console.WriteLine($"Vaccinating {pet.Name}...");
        }
    }
}
