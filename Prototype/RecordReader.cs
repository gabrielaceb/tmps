using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RecordReader
    {


        public static DeveloperRecord ReadDeveloperRecordFromDatabase(int id)
        {
            Console.WriteLine("Reading developer record...");

            DeveloperRecord developerRecord = new DeveloperRecord();
            developerRecord.Name = "Ana";
            developerRecord.Surname = "Vinari";
            developerRecord.YearsOfExperience = 4;

            return developerRecord;
        }

        public static DesignerRecord ReadDesignerRecordFromDatabase(int id)
        {
            Console.WriteLine("Reading developer record...");

            DesignerRecord designerRecord = new DesignerRecord();
            designerRecord.Name = "Gabi";
            designerRecord.Surname = "Ceb";
            designerRecord.YearsOfExperience = 4;

            return designerRecord;
        }
    }
}
