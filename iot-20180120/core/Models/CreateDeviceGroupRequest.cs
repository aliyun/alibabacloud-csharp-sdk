// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateDeviceGroupRequest : TeaModel {
        /// <summary>
        /// The description of the group. The description must be 1 to 100 characters in length.
        /// </summary>
        [NameInMap("GroupDesc")]
        [Validation(Required=false)]
        public string GroupDesc { get; set; }

        /// <summary>
        /// The name of the group. The alias must be 4 to 30 characters in length, and can contain letters, digits, and underscores (\_).
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// The ID of the instance. You can view the instance **ID** on the **Overview** page in the IoT Platform console.
        /// 
        /// 
        /// 
        /// >*   If your instance has an ID, you must configure this parameter. If you do not set this parameter, the call fails.
        /// >*   If your instance has no **Overview** page or ID, you do not need to set this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The ID of the parent group.
        /// 
        /// If you need to create a first-level group, do not specify this parameter.
        /// </summary>
        [NameInMap("SuperGroupId")]
        [Validation(Required=false)]
        public string SuperGroupId { get; set; }

    }

}
