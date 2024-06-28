using System.ComponentModel;

namespace BloodTypeMatcher.Models
{
    public enum BloodTypes
    {
        [Description("AB+")]
        ABPos,
        [Description("AB-")]
        ABNeg,
        [Description("A+")]
        APos,
        [Description("A-")]
        ANeg,
        [Description("B+")]
        BPos,
        [Description("B-")]
        BNeg,
        [Description("O+")]
        OPos,
        [Description("O-")]
        ONeg,

    }
    public static class MyEnumExtensions
    {
        public static string ToDescriptionString(this BloodTypes val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}
