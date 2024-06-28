using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodTypeMatcher.Models
{
    public class BloodTypeMatches
    {
        private List<BloodTypeMatch> _bloodTypeMatches;

        public BloodTypeMatches()
        {
            _bloodTypeMatches = new List<BloodTypeMatch>()
            {
                // ABPos
                new BloodTypeMatch(BloodTypes.ABPos, BloodTypes.ABPos),
                new BloodTypeMatch(BloodTypes.ABPos, BloodTypes.ABNeg),
                new BloodTypeMatch(BloodTypes.ABPos, BloodTypes.APos),
                new BloodTypeMatch(BloodTypes.ABPos, BloodTypes.ANeg),
                new BloodTypeMatch(BloodTypes.ABPos, BloodTypes.BPos),
                new BloodTypeMatch(BloodTypes.ABPos, BloodTypes.BNeg),
                new BloodTypeMatch(BloodTypes.ABPos, BloodTypes.OPos),
                new BloodTypeMatch(BloodTypes.ABPos, BloodTypes.ONeg),
                
                // ABNeg
                new BloodTypeMatch(BloodTypes.ABNeg, BloodTypes.ABNeg),
                new BloodTypeMatch(BloodTypes.ABNeg, BloodTypes.ANeg),
                new BloodTypeMatch(BloodTypes.ABNeg, BloodTypes.BNeg),
                new BloodTypeMatch(BloodTypes.ABNeg, BloodTypes.ONeg),
                
                // APos
                new BloodTypeMatch(BloodTypes.APos, BloodTypes.APos),
                new BloodTypeMatch(BloodTypes.APos, BloodTypes.ANeg),
                new BloodTypeMatch(BloodTypes.APos, BloodTypes.OPos),
                new BloodTypeMatch(BloodTypes.APos, BloodTypes.ONeg),
                
                // ANeg
                new BloodTypeMatch(BloodTypes.ANeg, BloodTypes.ANeg),
                new BloodTypeMatch(BloodTypes.ANeg, BloodTypes.ONeg),
                
                // BPos
                new BloodTypeMatch(BloodTypes.BPos, BloodTypes.BPos),
                new BloodTypeMatch(BloodTypes.BPos, BloodTypes.BNeg),
                new BloodTypeMatch(BloodTypes.BPos, BloodTypes.OPos),
                new BloodTypeMatch(BloodTypes.BPos, BloodTypes.ONeg),
                
                // BNeg
                new BloodTypeMatch(BloodTypes.BNeg, BloodTypes.BNeg),
                new BloodTypeMatch(BloodTypes.BNeg, BloodTypes.ONeg),
                
                // OPos
                new BloodTypeMatch(BloodTypes.OPos, BloodTypes.OPos),
                new BloodTypeMatch(BloodTypes.OPos, BloodTypes.ONeg),
                
                // ONeg
                new BloodTypeMatch(BloodTypes.ONeg, BloodTypes.ONeg)
            };
        }

        public List<BloodTypeMatch> Matches
        {
            get => _bloodTypeMatches;
        }
    }
}
