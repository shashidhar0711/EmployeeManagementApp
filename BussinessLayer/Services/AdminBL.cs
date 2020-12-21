using BussinessLayer.IServices;
using CommonLayer;
using CommonLayer.RequestModel;
using RepositoryLayer.IRepository;
using System;
using System.Collections.Generic;

namespace BussinessLayer.Services
{
    public class AdminBL : IAdminBL
    {
        private readonly IAdminRL adminRL;

        public AdminBL(IAdminRL adminRL)
        {
            this.adminRL = adminRL;
        }

        public EmployeeModel AdminLogin(AdminModel login)
        {
            try
            {
                return this.adminRL.AdminLogin(login);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<EmployeeModel> GetAllEmployee()
        {
            try
            {
                return this.adminRL.GetAllEmployee();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool RegisterAdmin(RegisterModel admin)
        {
            try
            {
                return this.adminRL.RegisterAdmin(admin);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
