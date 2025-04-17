using MicroservicesDotNet.Model;

namespace MicroservicesDotNet.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
