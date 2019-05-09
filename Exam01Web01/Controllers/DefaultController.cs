using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using Model;
namespace Exam01Web01.Controllers
{
    public class DefaultController : Controller
    {
        Mydal dal = new Mydal();
        // GET: Default
        //班级信息，模糊查询，分页
        public ActionResult ClassIndex(string cname,int pageSize,int pageIndex)
        {
            List<ClassInfo> list = dal.GetClass(cname).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return View(list);
        }
        //学生信息，模糊查询，分页
        public ActionResult StudentIndex(string sname, int pageSize, int pageIndex)
        {
            List<Student> list = dal.GetStudent(sname).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return View(list);
        }
        //根据班级Id查询所在班级的学生
        public ActionResult StudentIndexByCid(int cid)
        {
            List<Student> list = dal.GetStudentByClassId(cid);
            return View(list);
        }
    }
}