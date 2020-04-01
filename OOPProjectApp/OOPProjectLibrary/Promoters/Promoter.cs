using System.Text;

namespace OOPProjectLibrary.Promoters
{
    public abstract class Promoter
    {
        public enum Types
        {
            Omnia,
            XS
        }

        public Promoter(string firstName, string lastName, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public Types Type { get; set; }

        public string BusinessCard => $"{FirstName} {LastName} {PhoneNumber}";

        public string PromotionDetails()
        {
            var output = new StringBuilder();

            output.Append(ShareWithinInnerCircle());
            output.Append("\n");
            output.Append(UsePaidAds());

            return output.ToString();
        }

        protected abstract string ShareWithinInnerCircle();

        protected abstract string UsePaidAds();
    }
}
