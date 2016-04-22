using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheAccounting.Models
{
    public enum enFeeType
    {
        [Display(Name = "支出")]
        Pay = 0,

        [Display(Name = "收入")]
        Income = 1
    }
}