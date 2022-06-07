using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DesignerRecord designerRecord1 = RecordReader.ReadDesignerRecordFromDatabase(50);
            DeveloperRecord developerRecord1 = RecordReader.ReadDeveloperRecordFromDatabase(43);

            Console.WriteLine("Press Enter you want to start the copying...");
            Console.ReadLine();

            DeveloperRecord developerRecord2 = (DeveloperRecord)developerRecord1.Clone();

            developerRecord1.DisplayInfo();
            developerRecord2.Name = "Gabi";
            developerRecord2.DisplayInfo();

            Console.ReadKey();
        }
    }
}
