using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDal
{
    public interface IStudent
    {
        List<Student> GetStudent(string sname);
        List<ClassInfo> GetClass(string cname);
        List<Student> GetStudentByClassId(int cid);
    }
}
