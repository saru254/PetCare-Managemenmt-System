namespace PetCareSystem.Models.Service
{
    public class Grooming : PetService
    {
        public override string ServiceName => "Grooming";
        public override void PerformService(Pet pet)
        {
            Console.WriteLine($"Grooming {pet.Name}...");
        }
    }
}