using System;

namespace WindowsFormsApp2
{
    public class Employee
    {
        public string Name { get; set; }
        public int IdNumber { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }

        // 礚把计篶
        public Employee()
        {
            Name = string.Empty;
            IdNumber = 0;
            Department = string.Empty;
            Position = string.Empty;
        }

        // ㄢ把计篶 - 砞﹚ Name, IdNumber
        public Employee(string name, int id) : this()
        {
            Name = name;
            IdNumber = id;
        }

        // 把计篶
        public Employee(string name, int id, string department, string position)
        {
            Name = name;
            IdNumber = id;
            Department = department ?? string.Empty;
            Position = position ?? string.Empty;
        }
    }
}
