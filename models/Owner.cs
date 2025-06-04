namespace PetCareSystem.Models
{
    public class Owner : Person
    {
        public List<Pet> Pets { get; private set; }
        public Owner(string name, string contact) : base(name, contact)
        {
            Pets = new List<Pet>();
        }
        public void AddPet(Pet pet) => Pets.Add(pet);
    }
}