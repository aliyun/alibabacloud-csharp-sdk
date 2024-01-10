// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateConsumerGroupRequest : TeaModel {
        /// <summary>
        /// The name of the consumer group. The name must be 4 to 30 characters in length and can contain letters, digits, and underscores (\_).
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// The ID of the instance. You can view the instance **ID** on the **Overview** page in the IoT Platform console.
        /// 
        /// >*   If your instance has an ID, you must configure this parameter. If you do not set this parameter, the call fails.
        /// >*   If your instance has no **Overview** page or ID, you do not need to set this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

    }

}
