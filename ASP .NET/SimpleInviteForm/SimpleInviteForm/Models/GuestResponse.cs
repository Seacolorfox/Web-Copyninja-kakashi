using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleInviteForm.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage="请确认宁的姓名")]
        public string Name { get; set; }
        [Required(ErrorMessage ="请确认宁的邮箱")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="请输入有效的邮箱")]
        public string Email { get; set; }
        [Required(ErrorMessage = "请确认宁的电♂fa")]
        public string PhoneNum { get; set; }
        [Required(ErrorMessage = "请确认宁是否真的接受邀♂请")]
        public bool? WillAttend { get; set; }
    }
}