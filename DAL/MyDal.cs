using System;
using Model;
using System.Collections.Generic;


namespace DAL
{
    public class MyDal
    {
        //查询所有学生信息
        public List<StudentModel> GetStudents()
        {
            string sql = "select * from Student join Class on Student.CId=Class.CId";
            return DBHelper.GetList<StudentModel>(sql);
        }
        //登录
        public List<UserLoginModel> GetUserLogins(string name="",string pwd="")
        {
            string sql = "select * from User_Login where 1=1";
            if (name!="")
            {
                sql += $" and UName='{name}'";
            }
            if (pwd!="")
            {
                sql += $" and UPwd='{pwd}'";
            }
            return DBHelper.GetList<UserLoginModel>(sql);
        }

    }
}
