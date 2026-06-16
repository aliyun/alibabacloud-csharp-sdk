// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class OperateSupabaseForAdminRequest : TeaModel {
        /// <summary>
        /// <para>The business ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS20250801154628000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <para>The SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>select * from profiles</para>
        /// </summary>
        [NameInMap("ExecuteSql")]
        [Validation(Required=false)]
        public string ExecuteSql { get; set; }

        /// <summary>
        /// <para>The operation type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vul_fix</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// <para>The ORDER BY clause.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("OrderByClause")]
        [Validation(Required=false)]
        public string OrderByClause { get; set; }

        /// <summary>
        /// <para>The field by which to sort the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreationTime</para>
        /// </summary>
        [NameInMap("OrderColumn")]
        [Validation(Required=false)]
        public string OrderColumn { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values: ASC and DESC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default.ai_advertising_material_rec_train_v1103</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The WHERE clause.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("WhereClause")]
        [Validation(Required=false)]
        public string WhereClause { get; set; }

    }

}
