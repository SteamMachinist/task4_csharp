using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_csharp
{
    internal class University
    {
        public string Name { get; protected set; }
        public int Enrolled { get; protected set; }
        public int Graduated { get; protected set; }

        public University(string name, int enrolled, int graduated)
        {
            Name = name;
            Enrolled = enrolled;
            Graduated = graduated;
        }

        public virtual double CalculateQ()
        {
            return (double)Graduated / Enrolled;
        }

        public override string? ToString()
        {
            return "University(Name = " + Name + "; Enrolled = " + Enrolled 
                + "; Graduated = " + Graduated + "; Q = " + Math.Round(CalculateQ(), 3) + ")";
        }
    }
}
