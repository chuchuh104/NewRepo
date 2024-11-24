using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelManagement.Classes
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public static ObservableCollection<Employee> Employees { get; set; } = new ObservableCollection<Employee>
        {
            new Employee { Name = "Кулибин А.И.", Position = "Директор" },
            new Employee { Name = "Туманина Е.В.", Position = "Секретарь" }
        };

    }
}

