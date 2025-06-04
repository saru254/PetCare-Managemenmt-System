# 🐾 PetCare Management System

A simple console-based **Object-Oriented Programming (OOP)** project in **C#** that simulates a pet care clinic. The system manages pet owners, their pets, and clinic appointments for services like grooming, vaccination, and checkups.

---

## 💡 Features

- Register pet owners and their pets
- Schedule appointments for:
  - ✅ Grooming
  - ✅ Vaccination
  - ✅ General Checkups
- Display all scheduled appointments
- Demonstrates core OOP principles:
  - **Encapsulation**
  - **Inheritance**
  - **Polymorphism**
  - **Abstraction**

---

## 🧱 Project Structure
PetCareSystem/
├── Models/
│ ├── Person.cs
│ ├── Owner.cs
│ ├── Pet.cs
│ ├── Appointment.cs
│ └── Services/
│ ├── PetService.cs
│ ├── Grooming.cs
│ ├── Vaccination.cs
│ └── Checkup.cs
├── Services/
│ └── AppointmentManager.cs
├── Program.cs
└── README.md


---

## 🚀 How to Run

1. Open the solution in **Visual Studio** or any C# IDE.
2. Build and run the project.
3. The console will simulate:
   - Creating an owner
   - Adding a pet
   - Scheduling a service appointment
   - Displaying all appointments

---

## 📚 OOP Concepts Demonstrated

| Concept        | Where It's Used                            |
|----------------|---------------------------------------------|
| **Encapsulation** | Private fields and controlled access in `Pet`, `Owner` |
| **Inheritance**    | `Owner` inherits from abstract `Person` class       |
| **Polymorphism**   | `PetService` base class with different service types |
| **Abstraction**    | `PetService` is an abstract class, not directly instantiated |

---

## 🔧 Future Improvements

- Console menu interface
- Save/load data from a file
- User input for dynamic data
- Add vet employees and clinic hours

---

## 👨‍💻 Author

This project was created as part of learning **C# OOP**.

Feel free to modify, enhance, or expand it for your own practice!

---


