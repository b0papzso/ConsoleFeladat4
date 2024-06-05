using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace physiotherapistproject
{
    public class PhysioTherapist
    {
        public PhysioTherapist(string name, int bonus, string gender, int workedDays) 
        {
            Name = name;
            bonus = Bonus;
            gender = Gender;
            workedDays = WorkedDays;
        }
        public string Name { get; set; }
        public int Bonus { get; set; }
        public string Gender {  get; set; }
        public int WorkedDays { get; set; }

        public PhysioTherapist() 
        { 
            Name = string.Empty;
            Bonus = 0;
            Gender = string.Empty;
            WorkedDays = 0;
        }

        public override string ToString()
        {
            return $"{Name}, {Bonus} Ft, és {Gender}";
        }
    }
}
