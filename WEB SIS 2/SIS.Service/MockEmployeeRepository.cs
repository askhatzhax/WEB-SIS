using System;
using System.Collections.Generic;
using SIS.Models;
using System.Text;

namespace SIS.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;


        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>() {
                new Employee()
                {
                    Id=0, Name="Askhat",Email="example@gmail.com", PhotoPath="avtar3.png", Department=Dept.HR
                },
                new Employee()
                {
                    Id=1, Name="Askhat1",Email="example@gmail.com", PhotoPath="avtar3.png", Department=Dept.IT
                },
                new Employee()
                {
                    Id=2, Name="Askhat2",Email="example@gmail.com", PhotoPath="avtar3.png", Department=Dept.IT
                },
                new Employee()
                {
                    Id=3, Name="Askhat3",Email="example@gmail.com", PhotoPath="avtar3.png", Department=Dept.Payroll
                },
                new Employee()
                {
                    Id=4, Name="Askhat4",Email="example@gmail.com", PhotoPath="avtar3.png", Department=Dept.HR
                },
                new Employee()
                {
                    Id=5, Name="Askhat5",Email="example@gmail.com", PhotoPath="avtar3.png", Department=Dept.Payroll
                },


            };
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;//throw new NotImplementedException();
        }

    }
}
