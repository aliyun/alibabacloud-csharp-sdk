// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsConsumerTimeSpanResponseBody : TeaModel {
        /// <summary>
        /// The query results.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsConsumerTimeSpanResponseBodyData Data { get; set; }
        public class OnsConsumerTimeSpanResponseBodyData : TeaModel {
            /// <summary>
            /// The most recent point in time when a message in the topic was consumed by the customer group.
            /// </summary>
            [NameInMap("ConsumeTimeStamp")]
            [Validation(Required=false)]
            public long? ConsumeTimeStamp { get; set; }

            /// <summary>
            /// The ID of the instance to which the consumer group belongs.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The earliest point in time when a message was published to the topic.
            /// </summary>
            [NameInMap("MaxTimeStamp")]
            [Validation(Required=false)]
            public long? MaxTimeStamp { get; set; }

            /// <summary>
            /// The most recent point in time when a message was published to the topic.
            /// </summary>
            [NameInMap("MinTimeStamp")]
            [Validation(Required=false)]
            public long? MinTimeStamp { get; set; }

            /// <summary>
            /// The name of the topic that you want to query.
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

        }

        /// <summary>
        /// The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
