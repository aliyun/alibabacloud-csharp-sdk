// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsMessageTraceResponseBody : TeaModel {
        /// <summary>
        /// The information about the message that is queried.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsMessageTraceResponseBodyData Data { get; set; }
        public class OnsMessageTraceResponseBodyData : TeaModel {
            [NameInMap("MessageTrack")]
            [Validation(Required=false)]
            public List<OnsMessageTraceResponseBodyDataMessageTrack> MessageTrack { get; set; }
            public class OnsMessageTraceResponseBodyDataMessageTrack : TeaModel {
                /// <summary>
                /// The ID of the consumer group that subscribes to the topic.
                /// </summary>
                [NameInMap("ConsumerGroup")]
                [Validation(Required=false)]
                public string ConsumerGroup { get; set; }

                /// <summary>
                /// The ID of the instance where the message that you want to query resides.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The status of the message. Valid values:
                /// 
                /// *   **CONSUMED**: The message is consumed.
                /// *   **CONSUMED_BUT_FILTERED:** No consumer groups subscribe to the message. The message is filtered out and not consumed.
                /// *   **NOT_CONSUME_YET**: The message is pending to be consumed.
                /// *   **NOT_ONLINE**: The consumer group is offline.
                /// *   **UNKNOWN**: The message is not consumed due to unknown reasons.
                /// </summary>
                [NameInMap("TrackType")]
                [Validation(Required=false)]
                public string TrackType { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
