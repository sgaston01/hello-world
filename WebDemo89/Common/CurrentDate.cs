using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
namespace WebDemo67.Common
{
    public class CurrentDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            //return base.IsValid(value);
            DateTime dateTime = Convert.ToDateTime(value);


            return (dateTime <= DateTime.Now);

            if(dateTime <= DateTime.Now)
            {

                return true;
            }
            else
            {
                return false;

            }

        }


    }
}