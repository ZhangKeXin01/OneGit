using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sex { get; set; }//性别
        public string Phone { get; set; }//电话
        public string Email { get; set; }//邮箱
        public string Address { get; set; }//家庭地址
        public int Cid { get; set; }

    }
}
