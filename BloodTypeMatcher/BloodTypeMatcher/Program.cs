using BloodTypeMatcher.Models;
using BloodTypeMatcher.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodTypeMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            // print all
            foreach (int i in Enum.GetValues(typeof(BloodTypes)))
            {
                BloodTypes bloodType = (BloodTypes)i;
                Console.WriteLine($"BloodTypes:{bloodType.ToDescriptionString()}");

                PrintBloodTypeMatches(bloodType);
            }

            // random
            Console.WriteLine("RANDOM!!!");
            PrintBloodTypeMatches(null);

            Console.WriteLine("Press any key to end program");
            Console.ReadKey();
        }

        private static BloodTypes GetRandomBloodType()
        {
            // get random BloodTypes
            Array values = Enum.GetValues(typeof(BloodTypes));
            Random random = new Random();
            var recipient = (BloodTypes)values.GetValue(random.Next(values.Length));

            return recipient;
        }

        private static void PrintBloodTypeMatches(BloodTypes? bloodType)
        {
            BloodTypes recipient = bloodType.HasValue ? bloodType.Value : GetRandomBloodType();

            var service = new BloodTypeMatcherService();
            var donors = service.GetDonorsForRecipient(recipient);

            foreach (var donor in donors)
            {
                Console.WriteLine($"{recipient.ToDescriptionString()}:{donor.ToDescriptionString()}");
            }
        }
    }
}
