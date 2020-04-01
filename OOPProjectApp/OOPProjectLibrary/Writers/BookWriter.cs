using OOPProjectLibrary.Interfaces;
using System.Text;

namespace OOPProjectLibrary.Writers
{
    public class BookWriter : Writer, IVlogger
    {
        public BookWriter(string firstName, string lastName)
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
