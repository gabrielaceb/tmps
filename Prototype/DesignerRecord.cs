using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DesignerRecord : EmployeeRecord
    {
        public override void DisplayInfo()
        {
            string info = "Designers report:\n" +
                            $"Name: = {Name}\n" +
                            $"Surname: = {Surname}\n" +
                            $"YearsOfExperience: = {YearsOfExperience}\n";
            
            Console.WriteLine(info);
        }
        public override EmployeeRecord Clone()
        {
            DesignerRecord copy = new DesignerRecord();
            copy.Name = this.Name;
            copy.Surname = this.Surname;
            copy.YearsOfExperience = this.YearsOfExperience;

            return copy;
        }
    }
}
