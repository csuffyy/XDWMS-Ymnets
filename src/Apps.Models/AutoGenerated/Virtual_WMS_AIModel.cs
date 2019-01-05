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

	public partial class WMS_AIModel:Virtual_WMS_AIModel
	{
		
	}
	public class Virtual_WMS_AIModel
	{
		[Display(Name = "未设置")]
		public virtual int Id { get; set; }
		[Display(Name = "到货单据号")]
		public virtual string ArrivalBillNum { get; set; }
		[Display(Name = "采购订单ID")]
		public virtual int POId { get; set; }
		[Display(Name = "未设置")]
		public virtual Nullable<int> PartId { get; set; }
		[Display(Name = "到货箱数")]
		public virtual Nullable<decimal> BoxQty { get; set; }
		[Display(Name = "到货数量")]
		public virtual Nullable<decimal> ArrivalQty { get; set; }
		[Display(Name = "到货日期")]
		public virtual Nullable<System.DateTime> ArrivalDate { get; set; }
		[Display(Name = "接收人")]
		public virtual string ReceiveMan { get; set; }
		[Display(Name = "到货状态")]
		public virtual string ReceiveStatus { get; set; }
		[Display(Name = "送检单号")]
		public virtual string InspectBillNum { get; set; }
		[Display(Name = "送检人")]
		public virtual string InspectMan { get; set; }
		[Display(Name = "送检日期")]
		public virtual Nullable<System.DateTime> InspectDate { get; set; }
		[Display(Name = "送检状态")]
		public virtual string InspectStatus { get; set; }
		[Display(Name = "检验日期")]
		public virtual Nullable<System.DateTime> CheckOutDate { get; set; }
		[Display(Name = "检验结果")]
		public virtual string CheckOutResult { get; set; }
		[Display(Name = "合格数量")]
		public virtual Nullable<decimal> QualifyQty { get; set; }
		[Display(Name = "不合格数量")]
		public virtual Nullable<decimal> NoQualifyQty { get; set; }
		[Display(Name = "检验说明")]
		public virtual string CheckOutRemark { get; set; }
		[Display(Name = "重新送检单")]
		public virtual string ReInspectBillNum { get; set; }
		[Display(Name = "入库单号")]
		public virtual string InStoreBillNum { get; set; }
		[Display(Name = "入库员")]
		public virtual string InStoreMan { get; set; }
		[Display(Name = "入库仓库")]
		public virtual Nullable<int> InvId { get; set; }
		[Display(Name = "入库子库存")]
		public virtual Nullable<int> SubInvId { get; set; }
		[Display(Name = "入库状态")]
		public virtual string InStoreStatus { get; set; }
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
		}
}
