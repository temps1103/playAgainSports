using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace playAgainSports.Models
{
    public class Login_User
    {
        [Required]
        [EmailAddress]
        public string Login_Email {get;set;}

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Login_Password {get;set;}
        
    }
}