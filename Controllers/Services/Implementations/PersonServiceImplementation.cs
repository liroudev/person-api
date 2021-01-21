using System.Collections.Generic;
using System.Threading;
using PersonAPI.Model;

namespace PersonAPI.Controllers.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
           
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();

        for (int i = 0; i < 8; i++)
        {
                Person person = MockPerson(i);
                persons.Add(person);
        }

            return persons;
        }

        public Person FindByID(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Filipe",
                LastName = "André",
                Adress = "Santa Rita - PB - Brasil",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        public Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name " + i,
                LastName = "Person Last Name " + i,
                Adress = "Some Adress " + i,
                Gender = i % 2 == 0 ? "Male": "Female"
            };

        }

        public long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

    }
}