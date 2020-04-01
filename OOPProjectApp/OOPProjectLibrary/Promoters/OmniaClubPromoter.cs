namespace OOPProjectLibrary.Promoters
{
    public class OmniaClubPromoter : Promoter
    {
        public OmniaClubPromoter(string firstName, string lastName, string phoneNumber)
            : base(firstName, lastName, phoneNumber)
        {
        }

        protected override string ShareWithinInnerCircle()
        {
            return $"{FirstName} {LastName} is promoting in the inner circle.";
        }

        protected override string UsePaidAds()
        {
            return $"{FirstName} {LastName} is promoting with paid ads.";
        }
    }
}
