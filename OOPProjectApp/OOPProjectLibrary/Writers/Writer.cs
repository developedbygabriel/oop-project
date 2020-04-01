namespace OOPProjectLibrary.Writers
{
    public abstract class Writer
    {
        public enum Types
        {
            Blog,
            Book
        }

        public Writer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Types Type { get; set; }

        public string AuthorBio => $"My name is {FirstName} {LastName}.";

        public abstract string WritingDetails();
    }
}
