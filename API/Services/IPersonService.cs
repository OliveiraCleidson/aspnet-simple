using System.Collections.Generic;
using API.Models;

namespace API.Services
{
    public interface IPersonService
    {
         public Person Create(Person Person);
         Person FindById(long id);

         List<Person> FindAll();

         void Delete(long id);
    }
}