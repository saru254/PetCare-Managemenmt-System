namespace PetCareSystem.Models.Services
{
    public class Checkup : PetService
    {
        public override string ServiceName => "General Checkup";

        public override void PerformService(Pet pet)
        {
            Console.WriteLine($"Performing health checkup on {pet.Name}...");
        }
    }
}
