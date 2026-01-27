namespace UniversalBookingSystem.Domain
    
{
    public class Meeting
    {
        public List<Person> PeopleList = new List<Person>();

        public string MeetingNote { get; private set; }
        public DateTime Date { get; private set; }

        public Meeting (string meetingnote, DateTime date)
        {

            Validate(date);

            MeetingNote = meetingnote;
            Date = date;
        }

        public void Rescehdule(DateTime newDate)
        {
            Validate(newDate);
            Date = newDate;
        }




        private void Validate(DateTime date)
        {
            if (date == default)
                throw new ArgumentException ("Must set a date");

            if (date <= DateTime.Now)
                throw new ArgumentException("Date cant be in the past");


        }

    }
}
