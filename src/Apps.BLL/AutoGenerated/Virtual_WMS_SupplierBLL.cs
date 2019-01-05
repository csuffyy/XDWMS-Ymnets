//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Apps.Models;
using Apps.Common;
using Unity.Attributes;
using System.Transactions;
using Apps.BLL.Core;
using Apps.Locale;
using LinqToExcel;
using System.IO;
using System.Text;
using Apps.IDAL.WMS;
using Apps.Models.WMS;
using Apps.IBLL.WMS;
namespace Apps.BLL.WMS
{
	public partial class WMS_SupplierBLL: Virtual_WMS_SupplierBLL,IWMS_SupplierBLL
	{
        

	}
	public class Virtual_WMS_SupplierBLL
	{
        [Dependency]
        public IWMS_SupplierRepository m_Rep { get; set; }

		public virtual List<WMS_SupplierModel> GetList(ref GridPager pager, string queryStr)
        {

            IQueryable<WMS_Supplier> queryData = null;
            if (!string.IsNullOrWhiteSpace(queryStr))
            {
                queryData = m_Rep.GetList(
								
								a=>a.SupplierCode.Contains(queryStr)
								|| a.SupplierShortName.Contains(queryStr)
								|| a.SupplierName.Contains(queryStr)
								|| a.SupplierType.Contains(queryStr)
								|| a.LinkMan.Contains(queryStr)
								|| a.LinkManTel.Contains(queryStr)
								|| a.LinkManAddress.Contains(queryStr)
								|| a.Status.Contains(queryStr)
								|| a.Remark.Contains(queryStr)
								|| a.CreatePerson.Contains(queryStr)
								
								|| a.ModifyPerson.Contains(queryStr)
								
								);
            }
            else
            {
                queryData = m_Rep.GetList();
            }
            pager.totalRows = queryData.Count();
            //排序
            queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
            return CreateModelList(ref queryData);
        }

		public virtual List<WMS_SupplierModel> GetListByUserId(ref GridPager pager, string userId,string queryStr)
		{
			return new List<WMS_SupplierModel>();
		}
		
		public virtual List<WMS_SupplierModel> GetListByParentId(ref GridPager pager, string queryStr,object parentId)
        {
			return new List<WMS_SupplierModel>();
		}

        public virtual List<WMS_SupplierModel> CreateModelList(ref IQueryable<WMS_Supplier> queryData)
        {

            List<WMS_SupplierModel> modelList = (from r in queryData
                                              select new WMS_SupplierModel
                                              {
													Id = r.Id,
													SupplierCode = r.SupplierCode,
													SupplierShortName = r.SupplierShortName,
													SupplierName = r.SupplierName,
													SupplierType = r.SupplierType,
													LinkMan = r.LinkMan,
													LinkManTel = r.LinkManTel,
													LinkManAddress = r.LinkManAddress,
													Status = r.Status,
													Remark = r.Remark,
                                                    MoreAccept = r.MoreAccept,
													CreatePerson = r.CreatePerson,
													CreateTime = r.CreateTime,
													ModifyPerson = r.ModifyPerson,
													ModifyTime = r.ModifyTime,
          
                                              }).ToList();

            return modelList;
        }

        public virtual bool Create(ref ValidationErrors errors, WMS_SupplierModel model)
        {
            try
            {
                WMS_Supplier entity = m_Rep.GetById(model.Id);
                if (entity != null)
                {
                    errors.Add(Resource.PrimaryRepeat);
                    return false;
                }
                entity = new WMS_Supplier();
               				entity.Id = model.Id;
				entity.SupplierCode = model.SupplierCode;
				entity.SupplierShortName = model.SupplierShortName;
				entity.SupplierName = model.SupplierName;
				entity.SupplierType = model.SupplierType;
				entity.LinkMan = model.LinkMan;
				entity.LinkManTel = model.LinkManTel;
				entity.LinkManAddress = model.LinkManAddress;
				entity.Status = model.Status;
                entity.MoreAccept = model.MoreAccept;
				entity.Remark = model.Remark;
				entity.CreatePerson = model.CreatePerson;
				entity.CreateTime = model.CreateTime;
				entity.ModifyPerson = model.ModifyPerson;
				entity.ModifyTime = model.ModifyTime;
  

                if (m_Rep.Create(entity))
                {
                    return true;
                }
                else
                {
                    errors.Add(Resource.InsertFail);
                    return false;
                }
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message);
                ExceptionHander.WriteException(ex);
                return false;
            }
        }



         public virtual bool Delete(ref ValidationErrors errors, object id)
        {
            try
            {
                if (m_Rep.Delete(id) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message);
                ExceptionHander.WriteException(ex);
                return false;
            }
        }

        public virtual bool Delete(ref ValidationErrors errors, object[] deleteCollection)
        {
            try
            {
                if (deleteCollection != null)
                {
                    using (TransactionScope transactionScope = new TransactionScope())
                    {
                        if (m_Rep.Delete(deleteCollection) == deleteCollection.Length)
                        {
                            transactionScope.Complete();
                            return true;
                        }
                        else
                        {
                            Transaction.Current.Rollback();
                            return false;
                        }
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message);
                ExceptionHander.WriteException(ex);
                return false;
            }
        }

		
       

        public virtual bool Edit(ref ValidationErrors errors, WMS_SupplierModel model)
        {
            try
            {
                WMS_Supplier entity = m_Rep.GetById(model.Id);
                if (entity == null)
                {
                    errors.Add(Resource.Disable);
                    return false;
                }
                              				entity.Id = model.Id;
				entity.SupplierCode = model.SupplierCode;
				entity.SupplierShortName = model.SupplierShortName;
				entity.SupplierName = model.SupplierName;
				entity.SupplierType = model.SupplierType;
				entity.LinkMan = model.LinkMan;
				entity.LinkManTel = model.LinkManTel;
				entity.LinkManAddress = model.LinkManAddress;
				entity.Status = model.Status;
                entity.MoreAccept = model.MoreAccept;
				entity.Remark = model.Remark;
				entity.CreatePerson = model.CreatePerson;
				entity.CreateTime = model.CreateTime;
				entity.ModifyPerson = model.ModifyPerson;
				entity.ModifyTime = model.ModifyTime;
 


                if (m_Rep.Edit(entity))
                {
                    return true;
                }
                else
                {
                    errors.Add(Resource.NoDataChange);
                    return false;
                }

            }
            catch (Exception ex)
            {
                errors.Add(ex.Message);
                ExceptionHander.WriteException(ex);
                return false;
            }
        }

      

        public virtual WMS_SupplierModel GetById(object id)
        {
            if (IsExists(id))
            {
                WMS_Supplier entity = m_Rep.GetById(id);
                WMS_SupplierModel model = new WMS_SupplierModel();
                              				model.Id = entity.Id;
				model.SupplierCode = entity.SupplierCode;
				model.SupplierShortName = entity.SupplierShortName;
				model.SupplierName = entity.SupplierName;
				model.SupplierType = entity.SupplierType;
				model.LinkMan = entity.LinkMan;
				model.LinkManTel = entity.LinkManTel;
				model.LinkManAddress = entity.LinkManAddress;
				model.Status = entity.Status;
				model.Remark = entity.Remark;
                model.MoreAccept = entity.MoreAccept;
				model.CreatePerson = entity.CreatePerson;
				model.CreateTime = entity.CreateTime;
				model.ModifyPerson = entity.ModifyPerson;
				model.ModifyTime = entity.ModifyTime;
 
                return model;
            }
            else
            {
                return null;
            }
        }


		 /// <summary>
        /// 校验Excel数据,这个方法一般用于重写校验逻辑
        /// </summary>
        public virtual bool CheckImportData(string fileName, List<WMS_SupplierModel> list,ref ValidationErrors errors )
        {
          
            var targetFile = new FileInfo(fileName);

            if (!targetFile.Exists)
            {

                errors.Add("导入的数据文件不存在");
                return false;
            }

            var excelFile = new ExcelQueryFactory(fileName);

            //对应列头
			 	 excelFile.AddMapping<WMS_SupplierModel>(x => x.SupplierCode, "供应商编码");
				 excelFile.AddMapping<WMS_SupplierModel>(x => x.SupplierShortName, "供应商简称");
				 excelFile.AddMapping<WMS_SupplierModel>(x => x.SupplierName, "供应商名称");
				 excelFile.AddMapping<WMS_SupplierModel>(x => x.SupplierType, "供应商类型");
				 excelFile.AddMapping<WMS_SupplierModel>(x => x.LinkMan, "联系人");
				 excelFile.AddMapping<WMS_SupplierModel>(x => x.LinkManTel, "联系人电话");
				 excelFile.AddMapping<WMS_SupplierModel>(x => x.LinkManAddress, "联系人地址");
				 excelFile.AddMapping<WMS_SupplierModel>(x => x.Status, "状态");                
                excelFile.AddMapping<WMS_SupplierModel>(x => x.Remark, "说明");
				 excelFile.AddMapping<WMS_SupplierModel>(x => x.CreatePerson, "创建人");
				 excelFile.AddMapping<WMS_SupplierModel>(x => x.CreateTime, "创建时间");
				 excelFile.AddMapping<WMS_SupplierModel>(x => x.ModifyPerson, "修改人");
				 excelFile.AddMapping<WMS_SupplierModel>(x => x.ModifyTime, "修改时间");
 
            //SheetName
            var excelContent = excelFile.Worksheet<WMS_SupplierModel>(0);
            int rowIndex = 1;
            //检查数据正确性
            foreach (var row in excelContent)
            {
                var errorMessage = new StringBuilder();
                var entity = new WMS_SupplierModel();
						 				  entity.Id = row.Id;
				  entity.SupplierCode = row.SupplierCode;
				  entity.SupplierShortName = row.SupplierShortName;
				  entity.SupplierName = row.SupplierName;
				  entity.SupplierType = row.SupplierType;
				  entity.LinkMan = row.LinkMan;
				  entity.LinkManTel = row.LinkManTel;
				  entity.LinkManAddress = row.LinkManAddress;
                  entity.MoreAccept = row.MoreAccept;
				  entity.Status = row.Status;
				  entity.Remark = row.Remark;
				  entity.CreatePerson = row.CreatePerson;
				  entity.CreateTime = row.CreateTime;
				  entity.ModifyPerson = row.ModifyPerson;
				  entity.ModifyTime = row.ModifyTime;
 
                //=============================================================================
                if (errorMessage.Length > 0)
                {
                    errors.Add(string.Format(
                        "第 {0} 列发现错误：{1}{2}",
                        rowIndex,
                        errorMessage,
                        "<br/>"));
                }
                list.Add(entity);
                rowIndex += 1;
            }
            if (errors.Count > 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        public virtual void SaveImportData(IEnumerable<WMS_SupplierModel> list)
        {
            try
            {
                using (DBContainer db = new DBContainer())
                {
                    foreach (var model in list)
                    {
                        WMS_Supplier entity = new WMS_Supplier();
                       						entity.Id = 0;
						entity.SupplierCode = model.SupplierCode;
						entity.SupplierShortName = model.SupplierShortName;
						entity.SupplierName = model.SupplierName;
						entity.SupplierType = model.SupplierType;
						entity.LinkMan = model.LinkMan;
						entity.LinkManTel = model.LinkManTel;
						entity.LinkManAddress = model.LinkManAddress;
						entity.Status = model.Status;
                        entity.MoreAccept = "不允许";//默认为不允许超量接收
						entity.Remark = model.Remark;
						entity.CreatePerson = model.CreatePerson;
						entity.CreateTime = ResultHelper.NowTime;
						entity.ModifyPerson = model.ModifyPerson;
						entity.ModifyTime = model.ModifyTime;
 
                        db.WMS_Supplier.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
		public virtual bool Check(ref ValidationErrors errors, object id,int flag)
        {
			return true;
		}

        public virtual bool IsExists(object id)
        {
            return m_Rep.IsExist(id);
        }
		
		public void Dispose()
        { 
            
        }

	}
}
