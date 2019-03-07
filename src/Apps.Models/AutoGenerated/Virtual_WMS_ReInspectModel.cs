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
namespace Apps.Models.WMS
{

	public partial class WMS_ReInspectModel:Virtual_WMS_ReInspectModel
	{
		
	}
	public class Virtual_WMS_ReInspectModel
	{
		[Display(Name = "重新送检单ID")]
		public virtual int Id { get; set; }
		[Display(Name = "到货送检单ID")]
		public virtual int AIId { get; set; }
		[Display(Name = "原送检单结果")]
		public virtual string OCheckOutResult { get; set; }
		[Display(Name = "原送检单合格数量")]
		public virtual Nullable<decimal> OQualifyQty { get; set; }
		[Display(Name = "原送检单不合格数量")]
		public virtual Nullable<decimal> ONoQualifyQty { get; set; }
		[Display(Name = "原送检单说明")]
		public virtual string OCheckOutRemark { get; set; }
		[Display(Name = "原送检单检验日期")]
		public virtual Nullable<System.DateTime> OCheckOutDate { get; set; }
		[Display(Name = "新送检单结果")]
		public virtual string NCheckOutResult { get; set; }
		[Display(Name = "新送检单合格数量")]
		public virtual Nullable<decimal> NQualifyQty { get; set; }
		[Display(Name = "新送检单不合格数量")]
		public virtual Nullable<decimal> NNoQualifyQty { get; set; }
		[Display(Name = "新送检单检验结果")]
		public virtual string NCheckOutRemark { get; set; }
		[Display(Name = "新送检单检验日期")]
		public virtual Nullable<System.DateTime> NCheckOutDate { get; set; }
		[Display(Name = "调整说明")]
		public virtual string Remark { get; set; }
		[Display(Name = "调整人")]
		public virtual string AdjustMan { get; set; }
		[Display(Name = "调整时间")]
		public virtual Nullable<System.DateTime> AdjustDate { get; set; }
		[Display(Name = "未设置")]
		public virtual string Attr1 { get; set; }
		[Display(Name = "未设置")]
		public virtual string Attr2 { get; set; }
		[Display(Name = "未设置")]
		public virtual string Attr3 { get; set; }
		[Display(Name = "未设置")]
		public virtual string Attr4 { get; set; }
		[Display(Name = "未设置")]
		public virtual string Attr5 { get; set; }
		[Display(Name = "创建时间")]
		public virtual string CreatePerson { get; set; }
		[Display(Name = "创建人")]
		public virtual Nullable<System.DateTime> CreateTime { get; set; }
		[Display(Name = "修改人")]
		public virtual string ModifyPerson { get; set; }
		[Display(Name = "修改人")]
		public virtual Nullable<System.DateTime> ModifyTime { get; set; }
		}
}
