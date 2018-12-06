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
using Apps.IDAL.Sys;
using Apps.Models.Sys;
using Apps.IBLL.Sys;
namespace Apps.BLL.Sys
{
	public partial class SysParamBLL: Virtual_SysParamBLL,ISysParamBLL
	{
        

	}
	public class Virtual_SysParamBLL
	{
        [Dependency]
        public ISysParamRepository m_Rep { get; set; }

		public virtual List<SysParamModel> GetList(ref GridPager pager, string queryStr)
        {

            IQueryable<SysParam> queryData = null;
            if (!string.IsNullOrWhiteSpace(queryStr))
            {
                queryData = m_Rep.GetList(
								
								a=>a.TypeCode.Contains(queryStr)
								|| a.TypeName.Contains(queryStr)
								|| a.ParamCode.Contains(queryStr)
								|| a.ParamName.Contains(queryStr)
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

		public virtual List<SysParamModel> GetListByUserId(ref GridPager pager, string userId,string queryStr)
		{
			return new List<SysParamModel>();
		}
		
		public virtual List<SysParamModel> GetListByParentId(ref GridPager pager, string queryStr,object parentId)
        {
			return new List<SysParamModel>();
		}

        public virtual List<SysParamModel> CreateModelList(ref IQueryable<SysParam> queryData)
        {

            List<SysParamModel> modelList = (from r in queryData
                                              select new SysParamModel
                                              {
													Id = r.Id,
													TypeCode = r.TypeCode,
													TypeName = r.TypeName,
													ParamCode = r.ParamCode,
													ParamName = r.ParamName,
													CreatePerson = r.CreatePerson,
													CreateTime = r.CreateTime,
													ModifyPerson = r.ModifyPerson,
													ModifyTime = r.ModifyTime,
													Sort = r.Sort,
													Enable = r.Enable,
          
                                              }).ToList();

            return modelList;
        }

        public virtual bool Create(ref ValidationErrors errors, SysParamModel model)
        {
            try
            {
                SysParam entity = m_Rep.GetById(model.Id);
                if (entity != null)
                {
                    errors.Add(Resource.PrimaryRepeat);
                    return false;
                }
                entity = new SysParam();
               				entity.Id = model.Id;
				entity.TypeCode = model.TypeCode;
				entity.TypeName = model.TypeName;
				entity.ParamCode = model.ParamCode;
				entity.ParamName = model.ParamName;
				entity.CreatePerson = model.CreatePerson;
				entity.CreateTime = model.CreateTime;
				entity.ModifyPerson = model.ModifyPerson;
				entity.ModifyTime = model.ModifyTime;
				entity.Sort = model.Sort;
				entity.Enable = model.Enable;
  

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

		
       

        public virtual bool Edit(ref ValidationErrors errors, SysParamModel model)
        {
            try
            {
                SysParam entity = m_Rep.GetById(model.Id);
                if (entity == null)
                {
                    errors.Add(Resource.Disable);
                    return false;
                }
                              				entity.Id = model.Id;
				entity.TypeCode = model.TypeCode;
				entity.TypeName = model.TypeName;
				entity.ParamCode = model.ParamCode;
				entity.ParamName = model.ParamName;
				entity.CreatePerson = model.CreatePerson;
				entity.CreateTime = model.CreateTime;
				entity.ModifyPerson = model.ModifyPerson;
				entity.ModifyTime = model.ModifyTime;
				entity.Sort = model.Sort;
				entity.Enable = model.Enable;
 


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

      

        public virtual SysParamModel GetById(object id)
        {
            if (IsExists(id))
            {
                SysParam entity = m_Rep.GetById(id);
                SysParamModel model = new SysParamModel();
                              				model.Id = entity.Id;
				model.TypeCode = entity.TypeCode;
				model.TypeName = entity.TypeName;
				model.ParamCode = entity.ParamCode;
				model.ParamName = entity.ParamName;
				model.CreatePerson = entity.CreatePerson;
				model.CreateTime = entity.CreateTime;
				model.ModifyPerson = entity.ModifyPerson;
				model.ModifyTime = entity.ModifyTime;
				model.Sort = entity.Sort;
				model.Enable = entity.Enable;
 
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
        public virtual bool CheckImportData(string fileName, List<SysParamModel> list,ref ValidationErrors errors )
        {
          
            var targetFile = new FileInfo(fileName);

            if (!targetFile.Exists)
            {

                errors.Add("导入的数据文件不存在");
                return false;
            }

            var excelFile = new ExcelQueryFactory(fileName);

            //对应列头
			 				 excelFile.AddMapping<SysParamModel>(x => x.TypeCode, "参数类别编码");
				 excelFile.AddMapping<SysParamModel>(x => x.TypeName, "参数类别名称");
				 excelFile.AddMapping<SysParamModel>(x => x.ParamCode, "参数值编码");
				 excelFile.AddMapping<SysParamModel>(x => x.ParamName, "参数值名称");
				 excelFile.AddMapping<SysParamModel>(x => x.CreatePerson, "创建人");
				 excelFile.AddMapping<SysParamModel>(x => x.CreateTime, "创建时间");
				 excelFile.AddMapping<SysParamModel>(x => x.ModifyPerson, "修改人");
				 excelFile.AddMapping<SysParamModel>(x => x.ModifyTime, "修改时间");
				 excelFile.AddMapping<SysParamModel>(x => x.Sort, "排序");
				 excelFile.AddMapping<SysParamModel>(x => x.Enable, "是否启用");
 
            //SheetName
            var excelContent = excelFile.Worksheet<SysParamModel>(0);
            int rowIndex = 1;
            //检查数据正确性
            foreach (var row in excelContent)
            {
                var errorMessage = new StringBuilder();
                var entity = new SysParamModel();
						 				  entity.Id = row.Id;
				  entity.TypeCode = row.TypeCode;
				  entity.TypeName = row.TypeName;
				  entity.ParamCode = row.ParamCode;
				  entity.ParamName = row.ParamName;
				  entity.CreatePerson = row.CreatePerson;
				  entity.CreateTime = row.CreateTime;
				  entity.ModifyPerson = row.ModifyPerson;
				  entity.ModifyTime = row.ModifyTime;
				  entity.Sort = row.Sort;
				  entity.Enable = row.Enable;
 
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
        public virtual void SaveImportData(IEnumerable<SysParamModel> list)
        {
            try
            {
                using (DBContainer db = new DBContainer())
                {
                    foreach (var model in list)
                    {
                        SysParam entity = new SysParam();
                       						entity.Id = 0;
						entity.TypeCode = model.TypeCode;
						entity.TypeName = model.TypeName;
						entity.ParamCode = model.ParamCode;
						entity.ParamName = model.ParamName;
						entity.CreatePerson = model.CreatePerson;
						entity.CreateTime = ResultHelper.NowTime;
						entity.ModifyPerson = model.ModifyPerson;
						entity.ModifyTime = model.ModifyTime;
						entity.Sort = model.Sort;
						entity.Enable = model.Enable;
 
                        db.SysParam.Add(entity);
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
