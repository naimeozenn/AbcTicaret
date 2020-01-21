﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Models
{
    public class Register
    {
        [Required]
        [DisplayName("Adınız")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Soyadınız")]
        public string SurName { get; set; }

        [Required]
        [DisplayName("Kullanıcı Adınız")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("E-mail")]
        [EmailAddress(ErrorMessage ="Geçerli bir mail adresi giriniz.")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Parola")]
        public string Password { get; set; }

        [Required]
        [DisplayName("Tekrar Parola")]
        [Compare("Password",ErrorMessage ="Farklı bir parola girdiniz.")]
        public string RePassword { get; set; }
    }
}