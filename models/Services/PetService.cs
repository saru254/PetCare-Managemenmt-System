namespace PetCareSystem.Models.Services
{
    public abstract class PetService
    {
        public abstract string ServiceName { get; }
        public abstract void PerformService(Pet pet);
    }
}
