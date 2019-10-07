using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLib.Model.Entity
{
    public class UserInfo
    {
        [Required]
        [Display(Name = "Email")]
        
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string MissionCode { get; set; }

        public string CountryCode { get; set; }
    }
}
