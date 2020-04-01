using OOPProjectLibrary.Interfaces;

namespace OOPProjectLibrary.Writers
{
    public class BlogWriter : Writer, IVlogger
    {
        public BlogWriter(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        public override string WritingDetails()
        {
            return $"{FirstName} {LastName} is writing!";
        }

        public string VloggingDetails()
        {
            return $"{FirstName} {LastName} is vlogging!";
        }
    }
}
