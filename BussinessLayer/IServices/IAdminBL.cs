using CommonLayer;
using CommonLayer.RequestModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.IServices
{
    public interface IAdminBL
    {
        EmployeeModel AdminLogin(AdminModel login);
        List<EmployeeModel> GetAllEmployee();

        bool RegisterAdmin(RegisterModel admin);
    }
}
