// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsConsumerResetOffsetRequest : TeaModel {
        /// <summary>
        /// The ID of the consumer group whose dead-letter message you want to query.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The ID of the instance to which the consumer group belongs.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The timestamp to which you want to reset the consumer offset. This parameter takes effect only when the **Type** parameter is set to **1**. Unit: milliseconds.
        /// </summary>
        [NameInMap("ResetTimestamp")]
        [Validation(Required=false)]
        public long? ResetTimestamp { get; set; }

        /// <summary>
        /// The name of the topic for which you want to reset the consumer offset.
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        /// <summary>
        /// The method that you want to use to clear accumulated messages. Valid values:
        /// 
        /// *   **0:** All accumulated messages are cleared. Messages that are not consumed are ignored. Consumers in the specified consumer group consume only messages that are published to the topic after the specified point in time.
        /// 
        /// If "reconsumeLater" is returned, the accumulated messages are not cleared because the system is retrying to resend the messages to consumers.
        /// 
        /// *   **1:** The messages that were published to the topic before the specified point in time are cleared. You must specify a point in time. Consumers in the specified consumer group consume only the messages that are published to the topic after the specified point in time.
        /// 
        /// You can specify a point in time from the earliest point in time when a message was published to the topic to the most recent point in time when a message was published to the topic. Points in time that are not within the allowed time range are invalid.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
