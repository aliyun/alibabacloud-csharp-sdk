// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class CreateGroupIdRequest : TeaModel {
        /// <summary>
        /// The ID of the group that you want to create. The group ID must meet the following conventions:
        /// 
        /// *   The ID must be 7 to 64 characters in length. It must start with GID_ or GID- and can contain only letters, digits, hyphens (-), and underscores (_).
        /// *   The ID cannot be changed after the group is created. For more information, see [Terms](https://help.aliyun.com/document_detail/42420.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The ID of the ApsaraMQ for MQTT instance to which the group belongs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
