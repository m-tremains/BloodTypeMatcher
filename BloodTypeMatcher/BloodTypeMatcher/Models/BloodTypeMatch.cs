namespace BloodTypeMatcher.Models
{
    public class BloodTypeMatch
    {
        private BloodTypes _recipient;
        private BloodTypes _donor;

        public BloodTypeMatch(BloodTypes recipient, BloodTypes donor)
        {
            _recipient = recipient;
            _donor = donor;
        }

        public BloodTypes Recipient
        {
            get => _recipient;
        }

        public BloodTypes Donor
        {
            get => _donor;
        }

    }
}
