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
        /// <para>The list of granted permissions.</para>
        /// </summary>
        [NameInMap("AccountPrivileges")]
        [Validation(Required=false)]
        public List<ModifyAccountPrivilegesRequestAccountPrivileges> AccountPrivileges { get; set; }
        public class ModifyAccountPrivilegesRequestAccountPrivileges : TeaModel {
            /// <summary>
            /// <para>The privilege object, which is a tuple of database, table, and column.</para>
            /// </summary>
            [NameInMap("PrivilegeObject")]
            [Validation(Required=false)]
            public ModifyAccountPrivilegesRequestAccountPrivilegesPrivilegeObject PrivilegeObject { get; set; }
            public class ModifyAccountPrivilegesRequestAccountPrivilegesPrivilegeObject : TeaModel {
                /// <summary>
                /// <para>The column to which permissions are granted. This parameter is required when the privilege level is column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>column1</para>
                /// </summary>
                [NameInMap("Column")]
                [Validation(Required=false)]
                public string Column { get; set; }

                /// <summary>
                /// <para>The database to which permissions are granted. This parameter is required when the privilege level is database, table, or column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tsdb1</para>
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// <para>The table to which permissions are granted. This parameter is required when the privilege level is table or column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table1</para>
                /// </summary>
                [NameInMap("Table")]
                [Validation(Required=false)]
                public string Table { get; set; }

            }

            /// <summary>
            /// <para>The privilege level, obtained from the <c>DescribeEnabledPrivileges</c> operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Global</para>
            /// </summary>
            [NameInMap("PrivilegeType")]
            [Validation(Required=false)]
            public string PrivilegeType { get; set; }

            /// <summary>
            /// <para>The list of granted permissions.</para>
            /// </summary>
            [NameInMap("Privileges")]
            [Validation(Required=false)]
            public List<string> Privileges { get; set; }

        }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The cluster ID of the Enterprise Edition, Basic Edition, or Data Lakehouse Edition cluster.
        /// &lt;props=&quot;intl&quot;&gt;The cluster ID of the Data Lakehouse Edition cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1k5p066e1a****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("PromqlInsertPrivileges")]
        [Validation(Required=false)]
        public List<string> PromqlInsertPrivileges { get; set; }

        [NameInMap("PromqlSelectNodePercentage")]
        [Validation(Required=false)]
        public double? PromqlSelectNodePercentage { get; set; }

        [NameInMap("PromqlSelectPrivileges")]
        [Validation(Required=false)]
        public List<string> PromqlSelectPrivileges { get; set; }

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

        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

    }

}
