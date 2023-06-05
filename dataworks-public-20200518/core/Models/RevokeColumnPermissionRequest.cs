// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class RevokeColumnPermissionRequest : TeaModel {
        /// <summary>
        /// The Alibaba Cloud account of the user from whom you want to revoke permissions. Specify this parameter in the format that is the same as the format of the account used to access the MaxCompute project.
        /// 
        /// *   If you want to revoke permissions from an Alibaba Cloud account, specify this parameter in the ALIYUN$+Alibaba Cloud account format.
        /// *   If you want to revoke permissions from a Resource Access Management (RAM) user, specify this parameter in the RAM$+RAM user format.
        /// 
        /// You must specify either this parameter or RevokeUserId. If you specify both this parameter and RevokeUserId, the value of RevokeUserId prevails.
        /// </summary>
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public string Columns { get; set; }

        /// <summary>
        /// The name of the MaxCompute table to which the destination fields belong. You can call the [SearchMetaTables](~~173919~~) operation to query the name.
        /// </summary>
        [NameInMap("MaxComputeProjectName")]
        [Validation(Required=false)]
        public string MaxComputeProjectName { get; set; }

        /// <summary>
        /// Indicates whether the permissions on table fields are revoked.
        /// </summary>
        [NameInMap("RevokeUserId")]
        [Validation(Required=false)]
        public string RevokeUserId { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account of the user from whom you want to revoke permissions. You can log on to the DataWorks console and go to the Security Settings page to obtain the ID.
        /// 
        /// You must specify either this parameter or RevokeUserName. If you specify both this parameter and RevokeUserName, the value of this parameter prevails.
        /// </summary>
        [NameInMap("RevokeUserName")]
        [Validation(Required=false)]
        public string RevokeUserName { get; set; }

        /// <summary>
        /// The fields for which you want to revoke permissions from a user. Separate multiple fields with commas (,).
        /// 
        /// You can revoke the permissions on the fields only in MaxCompute tables.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// The name of the MaxCompute project to which the destination fields belong. You can log on to the DataWorks console and go to the Workspace Management page to obtain the name of the MaxCompute project that is associated with the workspace.
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public long? WorkspaceId { get; set; }

    }

}
