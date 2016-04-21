using System;
using System.Collections.Generic;
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
        public int Id { get; set; }

        /// <summary>
        /// 類別
        /// </summary>
        public enFeeType FeeType { get; set; }

        /// <summary>
        /// 金額
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:#,##0}")]
        public double Amount { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime FeeDay { get; set; }

        /// <summary>
        /// 備註
        /// </summary>
        public string Memo { get; set; }
    }

    public enum enFeeType
    {
        支出 = 1,
        收入 = 2
    }
}