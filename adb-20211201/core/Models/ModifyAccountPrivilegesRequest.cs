// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyAccountPrivilegesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the database account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>account1</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The permissions that you want to grant to the database account.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AccountPrivileges")]
        [Validation(Required=false)]
        public List<ModifyAccountPrivilegesRequestAccountPrivileges> AccountPrivileges { get; set; }
        public class ModifyAccountPrivilegesRequestAccountPrivileges : TeaModel {
            /// <summary>
            /// <para>The objects on which you want to grant permissions, including databases, tables, and columns.</para>
            /// </summary>
            [NameInMap("PrivilegeObject")]
            [Validation(Required=false)]
            public ModifyAccountPrivilegesRequestAccountPrivilegesPrivilegeObject PrivilegeObject { get; set; }
            public class ModifyAccountPrivilegesRequestAccountPrivilegesPrivilegeObject : TeaModel {
                /// <summary>
                /// <para>The columns on which you want to grant permissions. This parameter must be specified when the PrivilegeType parameter is set to Column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>column1</para>
                /// </summary>
                [NameInMap("Column")]
                [Validation(Required=false)]
                public string Column { get; set; }

                /// <summary>
                /// <para>The databases on which you want to grant permissions. This parameter must be specified when the PrivilegeType parameter is set to Database, Table, or Column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tsdb1</para>
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// <para>The tables on which you want to grant permissions. This parameter must be specified when the PrivilegeType parameter is set to Table or Column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table1</para>
                /// </summary>
                [NameInMap("Table")]
                [Validation(Required=false)]
                public string Table { get; set; }

            }

            /// <summary>
            /// <para>The permission level that you want to assign to the database account. You can call the <c>DescribeEnabledPrivileges</c> operation to query the permission level that can be assigned to the database account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Global</para>
            /// </summary>
            [NameInMap("PrivilegeType")]
            [Validation(Required=false)]
            public string PrivilegeType { get; set; }

            /// <summary>
            /// <para>The permissions that you want to grant to the database account.</para>
            /// </summary>
            [NameInMap("Privileges")]
            [Validation(Required=false)]
            public List<string> Privileges { get; set; }

        }

        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1k5p066e1a****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
