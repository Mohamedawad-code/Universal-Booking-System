namespace UniversalBookingSystem.Domain
{
    public class Person
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public string Phonenumber { get; private set; }

        public Person(int id, string name, string email, string phonenumber)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Missing name");

            if (string.IsNullOrEmpty(email))
                throw new ArgumentException("Email Missing");

            if (phonenumber.Length < 5)
                throw new ArgumentException("PhoneNumber must be longer");

            Id = id;
            Name = name;
            Email = email;
            Phonenumber = phonenumber;
        }
    }
}
































































