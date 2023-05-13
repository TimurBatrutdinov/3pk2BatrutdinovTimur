using System;

namespace PZ_8
{

    class Program
    {
        static void Main(string[] args)
        {
            var _student = ContactDataFactory.CreateContactData("Students") as Students;
            _student.Name = "Григорян Эди";
            _student.PhoneNumber = "89123456789";
            _student.Email = "perviymail.com";

            var _spec = ContactDataFactory.CreateContactData("Specialization") as Specialization;
            _spec.Name = "Фамилия Имя";
            _spec.PhoneNumber = "89987654321";
            _spec.Email = "vtoroy@mail.com";

            var _college = ContactDataFactory.CreateContactData("College") as College;
            _college.Name = "ОКСЭИ";
            _college.PhoneNumber = "555-321-123";
            _college.Address = "Чкалова";

            var AllContacts = new List<IContact> { _student, _spec, _college };

            foreach (var contact in AllContacts)
            {
                Console.WriteLine("\nИмя: " + contact.Name);
                Console.WriteLine("Телефон: " + contact.PhoneNumber);
            }
        }
    }
}