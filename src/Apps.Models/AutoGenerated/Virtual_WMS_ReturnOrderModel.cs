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

	public partial class WMS_ReturnOrderModel:Virtual_WMS_ReturnOrderModel
	{
		
	}
	public class Virtual_WMS_ReturnOrderModel
	{
		[Display(Name = "退货单ID")]
		public virtual int Id { get; set; }
		[Display(Name = "退货单号")]
		public virtual string ReturnOrderNum { get; set; }
		[Display(Name = "到货检验单ID")]
		public virtual Nullable<int> AIID { get; set; }
		[Display(Name = "重新送检单ID")]
		public virtual Nullable<int> ReInspectID { get; set; }
		[Display(Name = "物料编码")]
		public virtual Nullable<int> PartID { get; set; }
		[Display(Name = "代理商编码")]
		public virtual Nullable<int> SupplierId { get; set; }
		[Display(Name = "库存编码")]
		public virtual Nullable<int> InvId { get; set; }
		[Display(Name = "未设置")]
		public virtual Nullable<int> SubInvId { get; set; }
		[Display(Name = "批次号：YYYYMM")]
		public virtual string Lot { get; set; }
		[Display(Name = "应退货数量")]
		public virtual decimal ReturnQty { get; set; }
		[Display(Name = "实际退货数量")]
		public virtual decimal AdjustQty { get; set; }
		[Display(Name = "单据状态：无效，有效")]
		public virtual string Status { get; set; }
		[Display(Name = "退货说明")]
		public virtual string Remark { get; set; }
		[Display(Name = "打印状态")]
		public virtual string PrintStaus { get; set; }
		[Display(Name = "打印时间")]
		public virtual Nullable<System.DateTime> PrintDate { get; set; }
		[Display(Name = "打印人")]
		public virtual string PrintMan { get; set; }
		[Display(Name = "确认状态")]
		public virtual string ConfirmStatus { get; set; }
		[Display(Name = "确认人")]
		public virtual string ConfirmMan { get; set; }
		[Display(Name = "确认时间")]
		public virtual Nullable<System.DateTime> ConfirmDate { get; set; }
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
		[Display(Name = "创建人")]
		public virtual string CreatePerson { get; set; }
		[Display(Name = "创建时间")]
		public virtual Nullable<System.DateTime> CreateTime { get; set; }
		[Display(Name = "修改人")]
		public virtual string ModifyPerson { get; set; }
		[Display(Name = "修改时间")]
		public virtual Nullable<System.DateTime> ModifyTime { get; set; }
		[Display(Name = "未设置")]
		public virtual Nullable<int> BatchId { get; set; }
		[Display(Name = "未设置")]
		public virtual string ReturnOderType { get; set; }
		}
}
