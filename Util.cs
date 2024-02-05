using System;
using System.Collections.Generic;
using System.IO;

namespace CatWorx.BadgeMaker
{
    class Util
    {
        public static void PrintEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                string template = "{0,-10}\t{1,-20}\t{2}";
                Console.WriteLine(
                    string.Format(
                        template,
                        employees[i].GetId(),
                        employees[i].GetFullName(),
                        employees[i].GetPhotoUrl()
                    )
                );
            }
        }

        public static void MakeCSV(List<Employee> employees)
        {
            // Creck if "data" folder exists
            if (!Directory.Exists("data"))
            {
                // If not, create it
                Directory.CreateDirectory("data");
            }
        }
    }
}
