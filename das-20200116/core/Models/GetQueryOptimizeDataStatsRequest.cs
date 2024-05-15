// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetQueryOptimizeDataStatsRequest : TeaModel {
        /// <summary>
        /// Specifies whether to sort the returned entries in ascending order. Default value: **true**. Valid values:
        /// 
        /// *   **true**: sorts the returned entries in ascending order.
        /// *   **false**: does not sort the returned entries in ascending order.
        /// </summary>
        [NameInMap("Asc")]
        [Validation(Required=false)]
        public string Asc { get; set; }

        /// <summary>
        /// The name of the database to be queried.
        /// </summary>
        [NameInMap("DbNames")]
        [Validation(Required=false)]
        public string DbNames { get; set; }

        /// <summary>
        /// The database engine. Valid values:
        /// 
        /// *   **MySQL**
        /// *   **PolarDBMySQL**
        /// *   **PostgreSQL**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The instance IDs. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// The keywords of the SQL template. Separate multiple keywords with spaces.
        /// </summary>
        [NameInMap("Keywords")]
        [Validation(Required=false)]
        public string Keywords { get; set; }

        /// <summary>
        /// The logical relationship between multiple keywords. Valid values:
        /// 
        /// *   **or**
        /// *   **and**
        /// </summary>
        [NameInMap("LogicalOperator")]
        [Validation(Required=false)]
        public string LogicalOperator { get; set; }

        /// <summary>
        /// Specifies whether to query only SQL templates that need to be optimized. Default value: **false**. Valid values:
        /// 
        /// *   **true**: queries only SQL templates that need to be optimized.
        /// *   **false**: does not query only SQL statements that need to be optimized.
        /// </summary>
        [NameInMap("OnlyOptimizedSql")]
        [Validation(Required=false)]
        public string OnlyOptimizedSql { get; set; }

        /// <summary>
        /// The field by which to sort the returned entries. Default value: **count**. Valid values:
        /// 
        /// *   **count**: the number of executions.
        /// *   **maxQueryTime**: the longest execution time.
        /// *   **avgQueryTime**: the average execution time.
        /// *   **maxLockTime**: the longest lock wait time.
        /// *   **avgLockTime**: the longest lock wait time.
        /// *   **maxRowsExamined**: the largest number of scanned rows.
        /// *   **avgRowsExamined**: the average number of scanned rows.
        /// *   **maxRowsSent**: the largest number of returned rows.
        /// *   **avgRowsSent**: the average number of returned rows.
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The region in which the instance resides. Valid values:
        /// 
        /// *   **cn-china**: Chinese mainland
        /// *   **cn-hongkong**: China (Hong Kong)
        /// *   **ap-southeast-1**: Singapore
        /// 
        /// This parameter takes effect only if **InstanceIds** is left empty. If you leave **InstanceIds** empty, the system obtains data from the region set by **Region**. By default, Region is set to **cn-china**. If you specify **InstanceIds**, **Region** does not take effect and the system obtains data from the region in which the first specified instance resides.****
        /// 
        /// >  Set this parameter to **cn-china** for the instances that are created in the regions in the Chinese mainland.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The tags that are used to filter SQL templates. Separate multiple tags with commas (,). For more information, see [Query governance](https://help.aliyun.com/document_detail/290038.html).
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string Rules { get; set; }

        /// <summary>
        /// The SQL template ID. You can query the ID of a template by calling the [GetQueryOptimizeExecErrorStats](https://help.aliyun.com/document_detail/405235.html) operation.
        /// </summary>
        [NameInMap("SqlIds")]
        [Validation(Required=false)]
        public string SqlIds { get; set; }

        /// <summary>
        /// The reserved parameter.
        /// </summary>
        [NameInMap("TagNames")]
        [Validation(Required=false)]
        public string TagNames { get; set; }

        /// <summary>
        /// The time range to query. Specify the time in the UNIX timestamp format. Unit: milliseconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public string Time { get; set; }

        /// <summary>
        /// The account of the database to be queried.
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
