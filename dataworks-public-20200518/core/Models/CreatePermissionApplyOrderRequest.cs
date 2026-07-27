// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreatePermissionApplyOrderRequest : TeaModel {
        /// <summary>
        /// <para>The list of objects for which permissions are requested.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApplyObject")]
        [Validation(Required=false)]
        public List<CreatePermissionApplyOrderRequestApplyObject> ApplyObject { get; set; }
        public class CreatePermissionApplyOrderRequestApplyObject : TeaModel {
            /// <summary>
            /// <para>The permission types to request. Separate multiple permission types with commas (,). Only Select, Describe, Drop, Alter, Update, and Download types are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Select,Describe</para>
            /// </summary>
            [NameInMap("Actions")]
            [Validation(Required=false)]
            public string Actions { get; set; }

            /// <summary>
            /// <para>The list of column objects.</para>
            /// </summary>
            [NameInMap("ColumnMetaList")]
            [Validation(Required=false)]
            public List<CreatePermissionApplyOrderRequestApplyObjectColumnMetaList> ColumnMetaList { get; set; }
            public class CreatePermissionApplyOrderRequestApplyObjectColumnMetaList : TeaModel {
                /// <summary>
                /// <para>The permission types to request. Separate multiple permission types with commas (,). Only Select, Describe, and Download types are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Select</para>
                /// </summary>
                [NameInMap("Actions")]
                [Validation(Required=false)]
                public string Actions { get; set; }

                /// <summary>
                /// <para>The name of the column for which permissions are requested. To request permissions on the entire table, enter all column names of the table.
                /// You can request permissions on specific columns only if LabelSecurity is enabled for the MaxCompute project. If LabelSecurity is not enabled, you can request permissions only on the entire table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aColumnName</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The object for which permissions are requested. Only MaxCompute table permissions are supported. Enter the name of the target table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aTableName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The reason for the request. This is used by the administrator for evaluation and approval.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>I need to use this table</para>
        /// </summary>
        [NameInMap("ApplyReason")]
        [Validation(Required=false)]
        public string ApplyReason { get; set; }

        /// <summary>
        /// <para>The type of the request order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MaxComputeTable: MaxCompute table permission request order.</description></item>
        /// <item><description>MaxComputeFunction: MaxCompute function permission request order.</description></item>
        /// <item><description>MaxComputeResource: MaxCompute resource permission request order.</description></item>
        /// <item><description>DLFSchema: Data Lake Formation (DLF) 1.0 schema permission request order.</description></item>
        /// <item><description>DLFTable: DLF 1.0 table permission request order.</description></item>
        /// <item><description>DLFColumn: DLF 1.0 column permission request order.</description></item>
        /// <item><description>DsApiDeploy: Data service publication permission request order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MaxComputeTable</para>
        /// </summary>
        [NameInMap("ApplyType")]
        [Validation(Required=false)]
        public string ApplyType { get; set; }

        /// <summary>
        /// <para>The UIDs of the Alibaba Cloud accounts for which permissions are requested. Separate multiple account UIDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>26784260040899****,26784260040899****</para>
        /// </summary>
        [NameInMap("ApplyUserIds")]
        [Validation(Required=false)]
        public string ApplyUserIds { get; set; }

        /// <summary>
        /// <para>The name of the data catalog to query. Go to the <a href="https://dlf.console.aliyun.com/ap-southeast-1/metadata/catalog?spm=a2c4g.11186623.0.0.5a225658pT4Dkr">Data Lake Formation console</a> to view the data catalog name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hive</para>
        /// </summary>
        [NameInMap("CatalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        /// <summary>
        /// <para>The expiration time of the requested permissions. Specify a UNIX timestamp. If you do not specify this parameter, the default expiration time is January 1, 2065.
        /// If LabelSecurity is not enabled for the MaxCompute project, or the security level of the requested table field is 0 or less than or equal to the security level of the requesting account, you can request only permanent permissions.
        /// Go to the management page of the DataWorks workspace and check the advanced configuration page of the MaxCompute engine to verify whether column-level access control is enabled.
        /// Go to the DataWorks workspace to view the security level of fields in Data Map and the security level of accounts on the Member Management page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1617115071885</para>
        /// </summary>
        [NameInMap("Deadline")]
        [Validation(Required=false)]
        public long? Deadline { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This field is deprecated. Set it to empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        [Obsolete]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>The name of the MaxCompute project for which permissions are requested.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aMaxcomputeProjectName</para>
        /// </summary>
        [NameInMap("MaxComputeProjectName")]
        [Validation(Required=false)]
        public string MaxComputeProjectName { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This field is deprecated. Set it to empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        [Obsolete]
        public int? OrderType { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace to which the MaxCompute project belongs. Go to the DataWorks workspace configuration page to obtain the workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public int? WorkspaceId { get; set; }

    }

}
