using BloodTypeMatcher.Models;
using System.Collections.Generic;
using System.Linq;

namespace BloodTypeMatcher.Services
{
    public class BloodTypeMatcherService
    {
        private BloodTypeMatches _matches;

        public BloodTypeMatcherService()
        {
            _matches = new BloodTypeMatches();
        }

        public List<BloodTypeMatch> GetMatchesForRecipient(BloodTypes recipient)
        {
            var matches = _matches.Matches
                .Where(w => w.Recipient == recipient)
                .ToList();

            return matches;
        }

        public List<BloodTypes> GetDonorsForRecipient(BloodTypes recipient)
        {
            var donors = GetMatchesForRecipient(recipient)
                .Select(s => s.Donor)
                .ToList();

            return donors;
        }
    }
}
