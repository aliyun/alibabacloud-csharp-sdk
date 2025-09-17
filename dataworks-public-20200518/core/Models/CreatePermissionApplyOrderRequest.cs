// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreatePermissionApplyOrderRequest : TeaModel {
        /// <summary>
        /// <para>The list of requested objects.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApplyObject")]
        [Validation(Required=false)]
        public List<CreatePermissionApplyOrderRequestApplyObject> ApplyObject { get; set; }
        public class CreatePermissionApplyOrderRequestApplyObject : TeaModel {
            /// <summary>
            /// <para>The type of permissions requested. Use commas (,) to separate multiple permission types in a single request. Currently only supports Select, Describe, Drop, Alter, Update, and Download permission types.</para>
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
                /// <b>Example:</b>
                /// <para>Select</para>
                /// </summary>
                [NameInMap("Actions")]
                [Validation(Required=false)]
                public string Actions { get; set; }

                /// <summary>
                /// <para>Permissions for the target columns. Enter the column names here. If applying for permissions on the entire table, enter all column names of the table. Permissions for specific columns can only be requested if labelSecurity is enabled for the MaxCompute project. Otherwise, you can only apply for permissions on the entire table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aColumnName</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The object you request access to. Currently, only permission requests for MaxCompute tables are supported. The name of the target table needs to be entered here.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aTableName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The reason for your request. The administrator determines whether to approve the request based on the reason.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>I need to use this table</para>
        /// </summary>
        [NameInMap("ApplyReason")]
        [Validation(Required=false)]
        public string ApplyReason { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MaxComputeTable</para>
        /// </summary>
        [NameInMap("ApplyType")]
        [Validation(Required=false)]
        public string ApplyType { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account for which you want to request permissions. If you want to request permissions for multiple Alibaba Cloud accounts, separate the IDs of the accounts with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>267842600408993176,267842600408993177</para>
        /// </summary>
        [NameInMap("ApplyUserIds")]
        [Validation(Required=false)]
        public string ApplyUserIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hive</para>
        /// </summary>
        [NameInMap("CatalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        /// <summary>
        /// <para>The expiration time of the permissions that you request. This value is a UNIX timestamp. The default value is January 1, 2065. If LabelSecurity is disabled for the MaxCompute project in which you want to request permissions on the fields of a table, or the security level of the fields is 0 or is lower than or equal to the security level of the Alibaba Cloud account for which you want to request permissions, you can request only permanent permissions. You can go to the Workspace Management page in the DataWorks console, click MaxCompute Management in the left-side navigation pane, and then check whether column-level access control is enabled. You can go to your DataWorks workspace, view the security level of the fields in Data Map, and then view the security level of the Alibaba Cloud account on the User Management page.</para>
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
        /// <para>The type of compute engine for permission requests. Currently only supports ODPS, which means only MaxCompute compute engine permissions are supported.</para>
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
        /// <para>The name of the MaxCompute project you request access to.</para>
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
        /// <para>The request type. The only supported value is 1, which represents an object ACL permission request.</para>
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
        /// <para>The DataWorks workspace ID to which the MaxCompute project belongs for permission requests. You can check the workspace ID on the DataWorks workspace configuration page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public int? WorkspaceId { get; set; }

    }

}
