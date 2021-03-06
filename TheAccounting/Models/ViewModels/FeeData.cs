﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TheAccounting.Models.Attributes;

namespace TheAccounting.Models.ViewModels
{
    public class FeeData
    {
        /// <summary>
        /// 類別
        /// </summary>
        [Required]
        [Display(Name = "類別")]
        public enFeeType FeeType { get; set; }

        /// <summary>
        /// 金額
        /// </summary>
        [Required]
        [Display(Name = "金額")]
        [Range(0, int.MaxValue, ErrorMessage = "金額只能輸入正整數")]
        [DisplayFormat(DataFormatString = "{0:#,##0}")]
        public double Amount { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [Required]
        [FeeDay]
        [Display(Name = "日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime FeeDay { get; set; }

        /// <summary>
        /// 備註
        /// </summary>
        [Display(Name = "備註")]
        [StringLength(100)]
        public string Memo { get; set; }
    }
}