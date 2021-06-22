using System.Collections.Generic;
using API.Model;

namespace API.Services.Implementations
{
  public class PersonService : IPersonService
  {
    public Person Create(Person person)
    {
      return person;
    }

    public void Delete(long id)
    {
      throw new System.NotImplementedException();
    }

    public List<Person> FindAll()
    {
      var list = new List<Person>();

      return list;
    }

    public Person FindById(long id)
    {
      return new Person{
          Id = 1,
          FirstName = "Caio",
          LastName = "Oliveira",
          Address = "Distrito Federal",
          Gender = "Male"
      };
    }
  }
}