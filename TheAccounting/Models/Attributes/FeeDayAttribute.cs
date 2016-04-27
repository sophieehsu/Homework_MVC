using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheAccounting.Models.Attributes
{
    public class FeeDayAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value==null)
                return new ValidationResult("日期為必填");

            DateTime dt;
            bool isDatetime = DateTime.TryParse(value.ToString(), out dt);

            if (isDatetime)
            {
                if(dt > DateTime.Now)
                    return new ValidationResult("日期只能小於今天");
                else
                    return ValidationResult.Success;
            }
            else
                return new ValidationResult("請輸入日期格式");
        }
    }
}