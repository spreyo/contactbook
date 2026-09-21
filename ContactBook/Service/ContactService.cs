using ContactBook.Models;
using ContactBook.Interface;
namespace ContactBook.Service
{
    public class ContactService : Interface.IContactService
    {
        public List<Contact> GetAll() {
            var contacts = new List<Contact>()
            {
                new Contact() { Id = 1, FirstName = "Jakub", LastName = "Kratochvil", Email = "kubko.kratochvil@gmail.com" },
                new Contact() { Id = 2, FirstName = "test", LastName = "wwww", Email = "test.kratochvil@gmail.com" },
                new Contact() { Id = 3, FirstName = "jablk", LastName = "kruska", Email = "kubko.haha@gmail.com" }
            };
            return contacts;
        }
    }
}
