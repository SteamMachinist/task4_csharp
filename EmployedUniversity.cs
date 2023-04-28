using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_csharp
{
    internal class EmployedUniversity : University
    {
        public double EmployedAccordingToEducationPercentage { get; private set; }

        public EmployedUniversity(string name, int enrolled, int graduated, double employedAccordingToEducationPercentage) 
            : base(name, enrolled, graduated)
        {
            EmployedAccordingToEducationPercentage = employedAccordingToEducationPercentage;
        }

        public override double CalculateQ()
        {
            return base.CalculateQ() * EmployedAccordingToEducationPercentage / 100;
        }

        public override string? ToString()
        {
            return "EmployedUniversity(Name = " + Name + "; Enrolled = " + Enrolled 
                + "; Graduated = " + Graduated + "; employed = " + EmployedAccordingToEducationPercentage 
                + "%; Q = " + Math.Round(CalculateQ(), 3) + ")";
        }
    }
}
