using System.Collections.Generic;
using PersonAPI.Model;

namespace PersonAPI.Controllers.Services
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