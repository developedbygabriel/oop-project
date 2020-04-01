using OOPProjectLibrary.Interfaces;

namespace OOPProjectLibrary.Promoters
{
    public class XSClubPromoter : Promoter, IVlogger, IBodyBuilder
    {
        public XSClubPromoter(string firstName, string lastName, string phoneNumber)
            : base(firstName, lastName, phoneNumber)
        {
        }

        protected override string ShareWithinInnerCircle()
        {
            return $"{FirstName} {LastName} is promoting via the inner circle.";
        }

        protected override string UsePaidAds()
        {
            return $"{FirstName} {LastName} is promoting via paid ads.";
        }

        public string VloggingDetails()
        {
            return $"{FirstName} {LastName} is vlogging.";
        }

        public string WorkoutDetails()
        {
            return $"{FirstName} {LastName} is working out.";
        }
    }
}
