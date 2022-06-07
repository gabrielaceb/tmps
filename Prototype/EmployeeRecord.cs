using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class EmployeeRecord
    {
        public string Name;
        public string Surname;
        public int YearsOfExperience;

        public abstract void DisplayInfo();

        public abstract EmployeeRecord Clone();
    }
}
