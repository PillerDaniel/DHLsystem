using DhlSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DhlSystem.Repository
{
    internal class EmployeeRepository
    {
        private DhlSystemContext dhlContext;

        public EmployeeRepository(DhlSystemContext context)
        {
            this.dhlContext = context;
        }
        public List<Employee> GetEmployees()
        {
            return dhlContext.Employees.ToList();
        }
        public Employee GetEmployeeById(int id)
        {
            return dhlContext.Employees.Find(id);
        }
        public void InsertEmployee(Employee employee)
        {
            dhlContext.Employees.Add(employee);
        }
        public void DeleteEmployee(int id)
        {
            dhlContext.Employees.Remove(dhlContext.Employees.Find(id));
        }
        public void UpdateEmployee(Employee employee)
        {
            dhlContext.Employees.Find(employee.Id).Name = employee.Name;
            dhlContext.Employees.Find(employee.Id).Position = employee.Position;
            dhlContext.Employees.Find(employee.Id).TourId = employee.TourId;
        }
        public void Save()
        {
            dhlContext.SaveChanges();
        }
        public void Dispose()
        {
            dhlContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
