namespace PetCareSystem.Models
{
    public class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }

        public Pet(string name, atring species, int age)
        {
            Name = name;
            Species = species;
            Age = age;
        }
        public void Display()
        {
            Console.WriteLine($"{Name} the {Species}, Age: {Age}");
        }
    }
}