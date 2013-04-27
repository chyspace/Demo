using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Mvc3.Models
{
    public class AboutModel
    {
        [HiddenInput(DisplayValue = false)]
        public string DemoField3 { get; private set; }

        [HiddenInput]
        public string DemoField2 { get; private set; }

        [Display(Name = "DisplayName")]
        public string DemoField1 { get; private set; }


        [Required]
        public string Username { get; set; }

        public string NickName { get; set; }
        
        public int Age { get; set; }
        
        public int Telephone { get; set; }
        
        public bool IsMarried { get; set; }
        
        public Address Address { get; set; }
    }

    public class Address
    {
        public string Country { get; set; }
        
        public string Province { get; set; }
        
        public string City { get; set; }
        
        public string Street { get; set; }
        
        public int ZipCode { get; set; }
    }
}