using System;
using Model;
using DAL;
using System.Collections.Generic;
using IBLL;

namespace BLL
{
    public class Bll : IBLLStudent
    {
        MyDal dal = new MyDal();
        public List<StudentModel> GetStudents()
        {
            return dal.GetStudents();
        }

        public List<UserLoginModel> GetUserLogins(string name,string pwd)
        {
            return dal.GetUserLogins(name,pwd);
        }
    }
}
