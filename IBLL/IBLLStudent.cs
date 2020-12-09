using System;
using Model;
using System.Collections.Generic;

namespace IBLL
{
    public interface IBLLStudent
    {
        List<StudentModel> GetStudents();
        List<UserLoginModel> GetUserLogins(string name,string pwd);
    }
}
