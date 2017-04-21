using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using WebDemo67.Common;
using System.Web.Mvc;

namespace WebDemo67.Models
{

    [MetadataType(typeof(EmployeeMetaData))]
    public partial class Employee
    {
        //[System.Web.Mvc.Compare("Email")]
        public string ConfirmEmail { get; set; }

    }
    
    
    public class EmployeeMetaData
    { 
       // [StringLength(10,MinimumLength =5)]
       // [Required]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-Za-z]+))$",ErrorMessage ="Please enter upper and lower case letter only")]
        public string Name { get; set; }

        [Range(1,100)]
        public int Age { get; set; }

        //from 80 - 81
        /*
        [Range(typeof(DateTime),"01/01/2000" , "05/01/2016")]
        [DisplayFormat(DataFormatString ="{0:d}" , ApplyFormatInEditMode =true)]
        public DateTime HireDate { get; set; }
        */

        //[DateRange("01/01/2000")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [CurrentDate]
        public DateTime HireDate { get; set; }

        [RegularExpression(@"^[\w-\._\+%]@(?:[\w-]+\.)+\w]{2,6}$")]
        public string Email { get; set; }

    }

    [MetadataType(typeof(UserMetadata))]
    public partial class User
    {



    }


    public class UserMetadata
    {
        [Remote("IsUSerNameAvaliable" , "Home" , ErrorMessage = "User Name exist ???")]
        public string UserName { get; set; }
    }




}