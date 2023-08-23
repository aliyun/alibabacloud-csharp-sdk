// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsGroupConsumerUpdateRequest : TeaModel {
        /// <summary>
        /// The ID of the consumer group for which you want to configure read permissions.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The ID of the instance to which the consumer group you want to configure belongs.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Specifies whether to authorize the consumer group to read messages. Valid values:
        /// 
        /// *   **true**: The consumer group can read messages.
        /// *   **false**: The consumer group cannot read messages.
        /// 
        /// Default value: **true**.
        /// </summary>
        [NameInMap("ReadEnable")]
        [Validation(Required=false)]
        public bool? ReadEnable { get; set; }

    }

}
