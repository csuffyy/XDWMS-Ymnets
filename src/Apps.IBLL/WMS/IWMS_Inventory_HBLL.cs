﻿using System.Collections.Generic;
using Apps.Common;
using Apps.Models.WMS;

namespace Apps.IBLL.WMS
{
    public partial interface IWMS_Inventory_HBLL
    {
         /// <summary>
         /// 导入Excel文件，当发生导入错误时，回写错误信息，并且全部回滚。
         /// </summary>
         /// <param name="oper">操作员ID</param>
         /// <param name="filePath"></param>
         /// <param name="errors"></param>
         /// <returns></returns>
         bool ImportExcelData(string oper, string filePath, ref ValidationErrors errors);
    
         /// <summary>
         /// 对导入进行附加的校验，例如物料编码是否存在等。
         /// </summary>
         /// <param name="model"></param>
         void AdditionalCheckExcelData(ref WMS_Inventory_HModel model);
    
         /// <summary>
         /// 根据where字符串获取列表数据。
         /// </summary>
         /// <param name="pager"></param>
         /// <param name="whereStr"></param>
         List<WMS_Inventory_HModel> GetListByWhere(ref GridPager pager, string where);

        /// <summary>
        /// 创建盘点表的行
        /// </summary>
        /// <param name="oper"></param>
        /// <param name="headId"></param>
        /// <param name="invList"></param>
        /// <returns></returns>
        bool CreateInventoryD(ref ValidationErrors errors, string oper, int headId, string invList);

        /// <summary>
        /// 盘点调整
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="oper"></param>
        /// <param name="headId"></param>
        /// <returns></returns>
        bool ConfirmInventory(ref ValidationErrors errors, string oper, int headId);
    }
}
