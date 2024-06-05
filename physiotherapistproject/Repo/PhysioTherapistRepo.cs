using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using physiotherapistproject;

namespace physiotherapistproject.Repo
{
    public class PhysioTherapistRepo
    {
        public PhysioTherapistRepo()
        {
            PhysioTherapists = new List<PhysioTherapist>
            {
                new PhysioTherapist("Sándor Johanna", 6000, "Nő", 9),
                new PhysioTherapist("Sándor Sándor", 5000, "Férfi", 10)
            };
        }

        public List<PhysioTherapist> PhysioTherapists { get; set; }

        public string MostPaidPhysioTherapist(List<PhysioTherapist> physioTherapists)
        {
            string mostPaidClass = "";
            int maxPay = int.MinValue;
            int classCount = physioTherapists.Count;
            int equalcount = 1;
            int noPayCount = 0;
            foreach (PhysioTherapist therapists in physioTherapists)
            {
                if (therapists.Bonus == 0)
                {
                    noPayCount++;
                }
                else if ((therapists.Bonus * therapists.WorkedDays) == maxPay)
                {
                    equalcount++;
                }
                if ((therapists.Bonus * therapists.WorkedDays) > maxPay)
                {
                    maxPay = therapists.Bonus;
                    mostPaidClass = $"{therapists.Name}";
                }
            }
            if (noPayCount == classCount)
            {
                mostPaidClass = "Egyik osztály sem fizet osztálypénzt";
            }
            if (equalcount == classCount)
            {
                mostPaidClass = "Az összes osztály ugyanannyit fizet";
            }
            return mostPaidClass;
        }
    }
}
