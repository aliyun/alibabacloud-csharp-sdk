// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAccountPrivilegeObjectsRequest : TeaModel {
        /// <summary>
        /// The name of the database account.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The column name that is used to filter columns.
        /// </summary>
        [NameInMap("ColumnPrivilegeObject")]
        [Validation(Required=false)]
        public string ColumnPrivilegeObject { get; set; }

        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The database name that is used to filter databases.
        /// </summary>
        [NameInMap("DatabasePrivilegeObject")]
        [Validation(Required=false)]
        public string DatabasePrivilegeObject { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 20.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The permission level. Valid values: Database, Table, and Column. Global is not supported.
        /// </summary>
        [NameInMap("PrivilegeType")]
        [Validation(Required=false)]
        public string PrivilegeType { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The table name that is used to filter tables.
        /// </summary>
        [NameInMap("TablePrivilegeObject")]
        [Validation(Required=false)]
        public string TablePrivilegeObject { get; set; }

    }

}
