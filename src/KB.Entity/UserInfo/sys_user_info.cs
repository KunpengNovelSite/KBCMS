using System;
using System.Collections.Generic;
using System.Text;

namespace KP.Entity.UserInfo
{
    public class sys_user_info
    {
        public int ID { set; get; }
        public string UserId { set; get; }
        public string UserName { set; get; }
        public string Pwd { set; get; }
        public int Status { set; get; }
        public string Mobile { set; get; }
        public string Email { set; get; }
        public string vx { set; get; }
        public string qq { set; get; }
        public string Nickname { set; get; }
        public string Sex { set; get; }
        public string Birthday { set; get; }
        public string Identification_number { set; get; }
        public string Passport_number { set; get; }
        public string Other_number { set; get; }
        public bool Issuperuser { set; get; }
        public DateTime? Create_Time { set; get; }
        public DateTime? Update_Time { set; get; }
        public bool is_editor { set; get; }
        public bool Is_author { set; get; }
        public int Level { set; get; }
        public string Remark { set; get; }
    }
}