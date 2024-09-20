using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace logindemo.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set;}
        [Display(Name = "使用者代號")]

        public string UserNo { get; set;}="";
        [Display(Name = "使用者姓名")]
        public string UserName { get; set;}="";
        [Display(Name = "登入密碼")]
        public string Password { get; set;} = "";
        
    }
}