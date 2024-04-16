namespace Laboratory_2.Models
{
    public abstract class Person
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }


        public Person(string id, string firstName, string secondName)
        {
            Id = id;
            FirstName = firstName;
            SecondName = secondName;
        }
    }
}
