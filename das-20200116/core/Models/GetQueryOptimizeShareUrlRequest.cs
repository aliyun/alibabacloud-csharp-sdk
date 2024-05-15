// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetQueryOptimizeShareUrlRequest : TeaModel {
        /// <summary>
        /// Specifies whether to sort the returned entries in ascending order. Default value: **true**. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Asc")]
        [Validation(Required=false)]
        public bool? Asc { get; set; }

        /// <summary>
        /// The name of the database to be queried.
        /// </summary>
        [NameInMap("DbNames")]
        [Validation(Required=false)]
        public string DbNames { get; set; }

        /// <summary>
        /// The database engine. Valid values:
        /// 
        /// *   **MySQL**: ApsaraDB RDS for MySQL
        /// *   **PolarDBMySQL**: PolarDB for MySQL
        /// *   **PostgreSQL**: ApsaraDB RDS for PostgreSQL
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
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("OnlyOptimizedSql")]
        [Validation(Required=false)]
        public bool? OnlyOptimizedSql { get; set; }

        /// <summary>
        /// The field by which to sort the returned entries. Default value: **count**. Valid values:
        /// 
        /// *   **count**: the number of executions.
        /// *   **maxQueryTime**: the longest execution duration.
        /// *   **avgQueryTime**: the average execution duration.
        /// *   **maxLockTime**: the longest lock wait duration.
        /// *   **avgLockTime**: the average lock wait duration.
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
        public int? PageNo { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region in which the instance resides. Valid values:
        /// 
        /// *   **cn-china**: Chinese mainland
        /// *   **cn-hongkong**: China (Hong Kong)
        /// *   **ap-southeast-1**: Singapore
        /// 
        /// This parameter takes effect only if **InstanceIds** is left empty. If you leave **InstanceIds** empty, the system obtains data from the region set by **Region**. By default, Region is set to **cn-china**. If you specify **InstanceIds**, **Region** does not take effect and the system obtains data from the region in which the first specified instance resides.****
        /// 
        /// >  If your instances reside in the regions in the Chinese mainland, set this parameter to **cn-china**.
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
        /// The SQL template IDs. You can call the [GetQueryOptimizeExecErrorStats](https://help.aliyun.com/document_detail/405261.html) operation to obtain the SQL template IDs.
        /// </summary>
        [NameInMap("SqlIds")]
        [Validation(Required=false)]
        public string SqlIds { get; set; }

        /// <summary>
        /// A reserved parameter.
        /// </summary>
        [NameInMap("TagNames")]
        [Validation(Required=false)]
        public string TagNames { get; set; }

        /// <summary>
        /// The date to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        /// <summary>
        /// The account of the database to be queried.
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
