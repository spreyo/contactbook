using ContactBook.Models;

namespace ContactBook.Interface
{
    public interface IContactService
    {
        List<Contact> GetAll();
    }
}
