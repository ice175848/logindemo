using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace logindemo.Models
{
    public class vmLogin
    {
        [Display(Name ="登入帳號")]
        [Required(ErrorMessage ="登入帳號不可空白!")]
        public string UserNo { get; set; }="";
        [Display(Name ="登入密碼")]
        [Required(ErrorMessage = "登入密碼不可空白!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }="";


        public List<Users> UserList{get;set;}
        public vmLogin()
        {
            UserList = new List<Users>();
            SetUserSeedData();
        }

        private void SetUserSeedData()
        {
            UserList.Clear();
            UserList.Add(new Users{Id = 1,UserNo = "U001",UserName = "王大明",Password = "12345"});
            UserList.Add(new Users{Id = 2,UserNo = "U002",UserName = "李曉華",Password = "12345"});
            UserList.Add(new Users{Id = 3,UserNo = "U003",UserName = "陳曉同",Password = "12345"});
        }
    }
}