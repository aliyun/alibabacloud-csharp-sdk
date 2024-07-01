// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyAccountPrivilegesRequest : TeaModel {
        /// <summary>
        /// The name of the database account.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The permissions that you want to grant to the database account.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccountPrivileges")]
        [Validation(Required=false)]
        public List<ModifyAccountPrivilegesRequestAccountPrivileges> AccountPrivileges { get; set; }
        public class ModifyAccountPrivilegesRequestAccountPrivileges : TeaModel {
            /// <summary>
            /// The objects on which you want to grant permissions, including databases, tables, and columns.
            /// </summary>
            [NameInMap("PrivilegeObject")]
            [Validation(Required=false)]
            public ModifyAccountPrivilegesRequestAccountPrivilegesPrivilegeObject PrivilegeObject { get; set; }
            public class ModifyAccountPrivilegesRequestAccountPrivilegesPrivilegeObject : TeaModel {
                /// <summary>
                /// The columns on which you want to grant permissions. This parameter must be specified when the PrivilegeType parameter is set to Column.
                /// </summary>
                [NameInMap("Column")]
                [Validation(Required=false)]
                public string Column { get; set; }

                /// <summary>
                /// The databases on which you want to grant permissions. This parameter must be specified when the PrivilegeType parameter is set to Database, Table, or Column.
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// The tables on which you want to grant permissions. This parameter must be specified when the PrivilegeType parameter is set to Table or Column.
                /// </summary>
                [NameInMap("Table")]
                [Validation(Required=false)]
                public string Table { get; set; }

            }

            /// <summary>
            /// The permission level that you want to assign to the database account. You can call the `DescribeEnabledPrivileges` operation to query the permission level that can be assigned to the database account.
            /// </summary>
            [NameInMap("PrivilegeType")]
            [Validation(Required=false)]
            public string PrivilegeType { get; set; }

            /// <summary>
            /// The permissions that you want to grant to the database account.
            /// </summary>
            [NameInMap("Privileges")]
            [Validation(Required=false)]
            public List<string> Privileges { get; set; }

        }

        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
