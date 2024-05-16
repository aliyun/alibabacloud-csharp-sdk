// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class UpdateConsumerOffsetShrinkRequest : TeaModel {
        /// <summary>
        /// The name of the consumer group.
        /// 
        /// *   The name can contain letters, digits, hyphens (-), and underscores (_).
        /// *   The name must be **3 to 64** characters in length. If a name contains more than **64** characters, the name is automatically truncated.
        /// *   The name of a consumer group cannot be changed after the consumer group is created.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConsumerId")]
        [Validation(Required=false)]
        public string ConsumerId { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// If you set resetType to offset, you can use this parameter to reset the consumer offset of each partition of a specific topic in the consumer group.
        /// </summary>
        [NameInMap("Offsets")]
        [Validation(Required=false)]
        public string OffsetsShrink { get; set; }

        /// <summary>
        /// The region ID of the instance to which the consumer group belongs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The method that is used to reset the consumer offsets of the subscribed topics of a consumer group. Valid values:
        /// 
        /// *   **timestamp** (default)
        /// *   **offset**
        /// </summary>
        [NameInMap("ResetType")]
        [Validation(Required=false)]
        public string ResetType { get; set; }

        /// <summary>
        /// The point in time when message consumption starts. The value of this parameter is a UNIX timestamp in milliseconds. The value of this parameter must be **less than 0** or **within the retention period of the consumer offset**. This parameter takes effect only if you set resetType to timestamp.
        /// 
        /// *   If you want to reset the consumer offset to the latest offset, set this parameter to -1.
        /// *   If you want to reset the consumer offset to the earliest offset, set this parameter to -2.
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public string Time { get; set; }

        /// <summary>
        /// The topic name.
        /// 
        /// *   The name can contain letters, digits, underscores (_), and hyphens (-).
        /// *   The name must be **3 to 64** characters in length. If a name contains more than **64** characters, the name is automatically truncated.
        /// *   The name of a topic cannot be changed after the topic is created.
        /// 
        /// **If you want to reset the consumer offsets of all topics to which the consumer subscribes, specify an empty string.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
