using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheAccounting.Models.ViewModels
{
    public class FeeData
    {
        /// <summary>
        /// 編號
        /// </summary>
        [Display(Name = "#")]
        public int Id { get; set; }

        /// <summary>
        /// 類別
        /// </summary>
        [Display(Name = "類別")]
        public enFeeType FeeType { get; set; }

        /// <summary>
        /// 金額
        /// </summary>
        [Display(Name = "金額")]
        [DisplayFormat(DataFormatString = "{0:#,##0}")]
        public double Amount { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [Display(Name = "日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime FeeDay { get; set; }

        /// <summary>
        /// 備註
        /// </summary>
        [Display(Name = "備註")]
        public string Memo { get; set; }
    }

    public enum enFeeType
    {
        支出 = 1,
        收入 = 2
    }
}