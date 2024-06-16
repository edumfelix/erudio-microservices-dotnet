using RestWithASPNETUdemy.Models;

namespace RestWithASPNETUdemy.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person GetByID(long id);
        List<Person> GetAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
