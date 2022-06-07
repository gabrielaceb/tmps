using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DeveloperRecord : EmployeeRecord
    {
        private DateTime _createdOn;

        public DeveloperRecord()
        {
            _createdOn = DateTime.Now;
        }

        public DeveloperRecord( DateTime createdOn )
        {
            _createdOn = createdOn;
        }
        public override void DisplayInfo()
        {
            string info = "Developers report:\n" +
                            $"Name: = {Name}\n" +
                            $"Surname: = {Surname}\n" +
                            $"YearsOfExperience: = {YearsOfExperience}\n" +
                            $"Date: = {_createdOn }\n";

            Console.WriteLine(info);
        }
        public override EmployeeRecord Clone()
        {
            DeveloperRecord copy = new DeveloperRecord(this._createdOn);
            copy.Name = this.Name;
            copy.Surname = this.Surname;
            copy.YearsOfExperience = this.YearsOfExperience;

            return copy;
        }
    }
}
