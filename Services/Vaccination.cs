namespace PetCareSystem.Models.Services
{
    public class Vacination : PetService
    {
        public override string ServiceName => "Vaccination";
        public override void PerformService(Pet pet)
        {
            Console.WriteLine($"Vaccination {pet.Name}....");
        }
    }
}