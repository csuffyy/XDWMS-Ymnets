//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using Apps.Models;
using System;
using System.ComponentModel.DataAnnotations;
namespace Apps.Models.Spl
{

	public partial class Spl_ContactCompanyCategoryModel:Virtual_Spl_ContactCompanyCategoryModel
	{
		
	}
	public class Virtual_Spl_ContactCompanyCategoryModel
	{
		[Display(Name = "主键ID")]
		public virtual string Id { get; set; }
		[Display(Name = "单位类别")]
		public virtual string Name { get; set; }
		[Display(Name = "创建时间")]
		public virtual System.DateTime CreateTime { get; set; }
		[Display(Name = "客户or供应商")]
		public virtual string Category { get; set; }
		}
}
