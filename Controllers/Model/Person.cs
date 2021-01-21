namespace PersonAPI.Controllers.Model
{
    public class Person
    {
        public long Id { get; set; }   
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string Gender { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}