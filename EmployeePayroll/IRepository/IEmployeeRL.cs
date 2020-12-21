using CommonLayer.RequestModel;
using RepositoryLayer.ContextModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.IRepository
{
    public interface IEmployeeRL
    {
        bool RegisterEmployee(RegisterModel employee);
        bool Delete(int EmpId);
        bool EditEmployee(UpdateModel updatedEmployee, int EmpId);
        List<CompanyEmployee> GetAllEmployee();

    }
}
