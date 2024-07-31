// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class AddProjectMemberToRoleRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. We recommend that you set this parameter to a UUID. This parameter is used to uniquely identify the API operation call.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The DataWorks workspace ID. You can call the [ListProjects](https://help.aliyun.com/document_detail/2780068.html) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The code of the role that you want to assign to a member of the DataWorks workspace. You can call the [ListProjectRoles](https://help.aliyun.com/document_detail/2780079.html) operation to query the codes of all roles in a DataWorks workspace.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RoleCode")]
        [Validation(Required=false)]
        public string RoleCode { get; set; }

        /// <summary>
        /// The Alibaba Cloud account ID. You can log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and move the pointer over the profile picture in the upper-right corner to view the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
