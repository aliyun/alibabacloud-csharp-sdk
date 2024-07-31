// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class RevokeTablePermissionRequest : TeaModel {
        /// <summary>
        /// The permissions that you want to revoke. Separate multiple permissions with commas (,). You can revoke only the SELECT, DESCRIBE, and DOWNLOAD permissions on MaxCompute tables.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Actions")]
        [Validation(Required=false)]
        public string Actions { get; set; }

        /// <summary>
        /// The name of the MaxCompute project to which the table belongs. You can log on to the DataWorks console and go to the SettingCenter page to obtain the name of the MaxCompute project that you associate with the workspace.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MaxComputeProjectName")]
        [Validation(Required=false)]
        public string MaxComputeProjectName { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account from which you want to revoke permissions. You can log on to the DataWorks console and go to the Security Settings page to obtain the ID. You must specify either this parameter or the RevokeUserName parameter. If you specify both this parameter and the RevokeUserName parameter and the parameter values are different, the value of this parameter prevails.
        /// </summary>
        [NameInMap("RevokeUserId")]
        [Validation(Required=false)]
        public string RevokeUserId { get; set; }

        /// <summary>
        /// The Alibaba Cloud account from which you want to revoke permissions. Specify this parameter in the format that is the same as the format of the account used to access the MaxCompute project.
        /// 
        /// *   If the account is an Alibaba Cloud account, the value is in the ALIYUN$+Account name format.
        /// *   If the account is a RAM user, the value is in the RAM$+Account name format.
        /// 
        /// You must specify either this parameter or the RevokeUserId parameter. If you specify both this parameter and the RevokeUserId parameter and the parameter values are different, the value of the RevokeUserId parameter prevails.
        /// </summary>
        [NameInMap("RevokeUserName")]
        [Validation(Required=false)]
        public string RevokeUserName { get; set; }

        /// <summary>
        /// The name of the MaxCompute table. You can call the [SearchMetaTables](https://help.aliyun.com/document_detail/173919.html) operation to query the name of the MaxCompute table.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// The ID of the DataWorks workspace with which the MaxCompute project is associated. You can log on to the DataWorks console and go to the Workspace page to obtain the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public long? WorkspaceId { get; set; }

    }

}
