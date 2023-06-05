// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class AddProjectMemberToRoleRequest : TeaModel {
        /// <summary>
        /// The ID of the request. You can use the ID to search for logs and troubleshoot issues based on the logs.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of your Alibaba Cloud account. To view the ID, log on to [the DataWorks console](https://workbench.data.aliyun.com/console) and move the pointer over the profile picture in the upper-right corner.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The client token. It is a field with the idempotence property. We recommend that you use a universally unique identifier (UUID). This parameter is used to uniquely identify the API operation call.
        /// </summary>
        [NameInMap("RoleCode")]
        [Validation(Required=false)]
        public string RoleCode { get; set; }

        /// <summary>
        /// The region of the workspace. For example, the ID of the China (Shanghai) region is cn-shanghai, and that of the China (Zhangjiakou) region is cn-zhangjiakou. The system automatically determines the value of this parameter based on the endpoint used to call the operation.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
