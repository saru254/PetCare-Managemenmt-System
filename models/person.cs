namespace PetCareSystem.Models
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string ContactNumber { get; set; }

        public Person(string name, string contact)
        {
            Name = name;
            ContactNumber = contact;
        }
        public virtual void DisplayInfo()
        {
            COnsole.WriteLine(&"Name: {Name}, Contact: {ContactNumber}");
        }
    }
}