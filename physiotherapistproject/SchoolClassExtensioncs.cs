using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace physiotherapistproject
{
    public static class SchoolClassExtensioncs
    {
        public static string whoHasHigherBonus(this PhysioTherapist pt1, PhysioTherapist pt2)
        {
            int difference = 0;
            if (pt1.Bonus > pt2.Bonus)
            {
                difference = pt1.Bonus - pt2.Bonus;
                return $"{pt1.Name} pótléka {difference} Ft-al több mint {pt2.Name} pótléka.";
            }
            else if (pt2.Bonus > pt1.Bonus)
            {
                difference = pt2.Bonus - pt1.Bonus;
                return $"{pt2.Name} pótléka {difference} Ft-al több mint {pt1.Name} pótléka.";
            }
            else
            {
                return "A két gyógytornász pótléka megegyezik.";
            }
        }
    }
}
