using System;
using System.Collections.Generic;
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
        public double Amount { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        public DateTime FeeDay { get; set; }

        /// <summary>
        /// 備註
        /// </summary>
        public string Memo { get; set; }
    }

    public enum enFeeType
    {
        /// <summary>
        /// 收入
        /// </summary>
        Income = 1,

        /// <summary>
        /// 支出
        /// </summary>
        Pay = 2
    }
}