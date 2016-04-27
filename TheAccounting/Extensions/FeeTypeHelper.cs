using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Mvc;
using TheAccounting.Models;
using TheAccounting.Models.ViewModels;

namespace TheAccounting.Extensions
{
    public static class FeeTypeHelper
    {
        public static MvcHtmlString DisplayForFeeType<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression)
        {
            #region // 取出 enum 的 Display 屬性

            var metaData = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            var enumType = metaData.Model;
            var fieldInfo = enumType.GetType().GetField(enumType.ToString());
            var descriptionAttributes = fieldInfo.GetCustomAttributes(
                typeof(DisplayAttribute), false) as DisplayAttribute[];

            var displayName = (descriptionAttributes.Length > 0) ? descriptionAttributes[0].Name : enumType.ToString();

            #endregion

            string css = "";

            // Income：文字樣式為藍色，Pay：文字樣式為紅色
            if (enumType.ToString() == enFeeType.Income.ToString())
                css = "class=\"text-primary\"";
            else if (enumType.ToString() == enFeeType.Pay.ToString())
                css = "class=\"text-danger\"";

            var sb = new StringBuilder();
            sb.AppendFormat("<span {0}>{1}</span>", css, HttpUtility.HtmlEncode(displayName));

            return MvcHtmlString.Create(sb.ToString());
        }
    }
}