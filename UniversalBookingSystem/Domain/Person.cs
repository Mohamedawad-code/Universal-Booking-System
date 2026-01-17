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


            Id = id;
            Name = name;
            Email = email;
            Phonenumber = phonenumber;
        }

        public void ChangeName(string newName)
        {
            Name = newName;
        }

        public void ChangeEmail(string newEmail)
        {
            Email = newEmail;
        }

        public void ChangePhone(string newPhone)
        {
            Phonenumber = newPhone;
        }


    }
}
































































