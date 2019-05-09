using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;
using IDal;
namespace DAL
{
    public class Mydal
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        public static string conStr = "Data Source=.;Initial Catalog=Exam01Web01;Integrated Security=True";

        /// <summary>
        /// 显示班级信息，根据名称模糊查询
        /// </summary>
        /// <param name="cname"></param>
        /// <returns></returns>
        public List<ClassInfo> GetClass(string cname)
        {
            //连接数据库
            SqlConnection conn = new SqlConnection(conStr);
            //查询语句
            string sql =string.Format("select * from Class where ClassName like '{0}'",cname);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            sda.Fill(dt);
            //table转化为list
            var table = JsonConvert.SerializeObject(dt);
            var list = JsonConvert.DeserializeObject<List<ClassInfo>>(table);
            return list;
        }

        /// <summary>
        /// 显示班级信息，根据名称模糊查询
        /// </summary>
        /// <param name="cname"></param>
        /// <returns></returns>
        public List<Student> GetStudent(string sname)
        {
            //连接数据库
            SqlConnection conn = new SqlConnection(conStr);
            //查询语句
            string sql = string.Format("select * from Student s join Class c on s.Cid=c.Id where Name like '{0}'", sname);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            sda.Fill(dt);
            //table转化为list
            var table = JsonConvert.SerializeObject(dt);
            var list = JsonConvert.DeserializeObject<List<Student>>(table);
            return list;
        }
        /// <summary>
        /// 通过班级id查询所在班级的学生信息
        /// </summary>
        /// <param name="cname"></param>
        /// <returns></returns>
        public List<Student> GetStudentByClassId(int cid)
        {
            //连接数据库
            SqlConnection conn = new SqlConnection(conStr);
            //查询语句
            string sql = string.Format("select * from Student s join Class c on s.Cid=c.Id where Cid={0}", cid);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            sda.Fill(dt);
            //table转化为list
            var table = JsonConvert.SerializeObject(dt);
            var list = JsonConvert.DeserializeObject<List<Student>>(table);
            return list;
        }
    }
}
