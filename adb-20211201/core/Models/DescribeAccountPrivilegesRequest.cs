// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAccountPrivilegesRequest : TeaModel {
        /// <summary>
        /// The name of the database account.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The columns that you want to query. You can use this parameter to query the permissions of the database account on specific columns. This parameter is available only if the PrivilegeType parameter is set to Column.
        /// </summary>
        [NameInMap("ColumnPrivilegeObject")]
        [Validation(Required=false)]
        public string ColumnPrivilegeObject { get; set; }

        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The databases that you want to query. You can use this parameter to query the permissions of the database account on specific databases. This parameter is available only if the PrivilegeType parameter is set to Database, Table, or Column.
        /// </summary>
        [NameInMap("DatabasePrivilegeObject")]
        [Validation(Required=false)]
        public string DatabasePrivilegeObject { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 20.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The permission level that you want to query. You can call the `DescribeEnabledPrivileges` operation to query the permission level of the database account.
        /// </summary>
        [NameInMap("PrivilegeType")]
        [Validation(Required=false)]
        public string PrivilegeType { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The tables that you want to query. You can use this parameter to query the permissions of the database account on specific tables. This parameter can be used together with the DatabasePrivilegeObject parameter. This parameter is available only if the PrivilegeType parameter is set to Table or Column.
        /// </summary>
        [NameInMap("TablePrivilegeObject")]
        [Validation(Required=false)]
        public string TablePrivilegeObject { get; set; }

    }

}
