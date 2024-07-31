// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreatePermissionApplyOrderRequest : TeaModel {
        /// <summary>
        /// The objects on which you want to request permissions.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApplyObject")]
        [Validation(Required=false)]
        public List<CreatePermissionApplyOrderRequestApplyObject> ApplyObject { get; set; }
        public class CreatePermissionApplyOrderRequestApplyObject : TeaModel {
            /// <summary>
            /// The permission that you want to request. If you want to request multiple permissions at the same time, separate them with commas (,). You can request only the following permissions: Select, Describe, Drop, Alter, Update, and Download.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Actions")]
            [Validation(Required=false)]
            public string Actions { get; set; }

            /// <summary>
            /// The fields on which you want to request permissions.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ColumnMetaList")]
            [Validation(Required=false)]
            public List<CreatePermissionApplyOrderRequestApplyObjectColumnMetaList> ColumnMetaList { get; set; }
            public class CreatePermissionApplyOrderRequestApplyObjectColumnMetaList : TeaModel {
                /// <summary>
                /// The field on which you want to request permissions. If you want to request permissions on an entire table, enter all fields in the table. You can request permissions on specific fields of a table in a MaxCompute project only after LabelSecurity is enabled for this project. If LabelSecurity is disabled, you can request permissions only on an entire table.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// The name of the object on which you want to request permissions. You can request permissions only on MaxCompute tables. Set this parameter to the name of the table on which you want to request permissions.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// The reason for your request. The administrator determines whether to approve the request based on the reason.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApplyReason")]
        [Validation(Required=false)]
        public string ApplyReason { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account for which you want to request permissions. If you want to request permissions for multiple Alibaba Cloud accounts, separate the IDs of the accounts with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApplyUserIds")]
        [Validation(Required=false)]
        public string ApplyUserIds { get; set; }

        /// <summary>
        /// The expiration time of the permissions that you request. This value is a UNIX timestamp. The default value is January 1, 2065. If LabelSecurity is disabled for the MaxCompute project in which you want to request permissions on the fields of a table, or the security level of the fields is 0 or is lower than or equal to the security level of the Alibaba Cloud account for which you want to request permissions, you can request only permanent permissions. You can go to the Workspace Management page in the DataWorks console, click MaxCompute Management in the left-side navigation pane, and then check whether column-level access control is enabled. You can go to your DataWorks workspace, view the security level of the fields in Data Map, and then view the security level of the Alibaba Cloud account on the User Management page.
        /// </summary>
        [NameInMap("Deadline")]
        [Validation(Required=false)]
        public long? Deadline { get; set; }

        /// <summary>
        /// The type of the compute engine in which you want to request permissions on the fields of a table. The parameter value is odps and cannot be changed. This value indicates that you can request permissions only on fields of tables in the MaxCompute compute engine.
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// The name of the MaxCompute project in which you request permissions on the fields of a table.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MaxComputeProjectName")]
        [Validation(Required=false)]
        public string MaxComputeProjectName { get; set; }

        /// <summary>
        /// The type of the permission request order. The parameter value is 1 and cannot be changed. This value indicates ACL-based authorization.
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public int? OrderType { get; set; }

        /// <summary>
        /// The ID of the DataWorks workspace that is associated with the MaxCompute project in which you want to request permissions on the fields of a table. You can go to the SettingCenter page in the DataWorks console to view the workspace ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public int? WorkspaceId { get; set; }

    }

}
