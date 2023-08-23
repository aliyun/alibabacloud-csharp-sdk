// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsMessageDetailResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsMessageDetailResponseBodyData Data { get; set; }
        public class OnsMessageDetailResponseBodyData : TeaModel {
            /// <summary>
            /// The string that is obtained after the message body is encrypted by using the Base 64 algorithm.
            /// </summary>
            [NameInMap("Body")]
            [Validation(Required=false)]
            public string Body { get; set; }

            /// <summary>
            /// The cyclic redundancy check (CRC) value of the message body.
            /// </summary>
            [NameInMap("BodyCRC")]
            [Validation(Required=false)]
            public int? BodyCRC { get; set; }

            /// <summary>
            /// The information about the message body.
            /// </summary>
            [NameInMap("BodyStr")]
            [Validation(Required=false)]
            public string BodyStr { get; set; }

            /// <summary>
            /// The producer instance that generated the message.
            /// </summary>
            [NameInMap("BornHost")]
            [Validation(Required=false)]
            public string BornHost { get; set; }

            /// <summary>
            /// The timestamp that indicates the point in time when the message was generated. Unit: milliseconds.
            /// </summary>
            [NameInMap("BornTimestamp")]
            [Validation(Required=false)]
            public long? BornTimestamp { get; set; }

            /// <summary>
            /// The ID of the ApsaraMQ for RocketMQ Instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The ID of the message.
            /// </summary>
            [NameInMap("MsgId")]
            [Validation(Required=false)]
            public string MsgId { get; set; }

            /// <summary>
            /// The attributes of the message.
            /// </summary>
            [NameInMap("PropertyList")]
            [Validation(Required=false)]
            public List<OnsMessageDetailResponseBodyDataPropertyList> PropertyList { get; set; }
            public class OnsMessageDetailResponseBodyDataPropertyList : TeaModel {
                /// <summary>
                /// The name of the attribute. Valid values:
                /// 
                /// *   **TRACE_ON**: indicates whether the trace of the message exists.
                /// *   **MSG_REGION**: The region ID of the instance to which the topic belongs.
                /// *   **\__MESSAGE_DECODED_TIME**: The time when the message was decoded.
                /// *   **\__BORNHOST**: The IP address of the producer client.
                /// *   **UNIQ_KEY**: The ID of the message.
                /// 
                /// For information about the terms that are used in ApsaraMQ for RocketMQ, see [Terms](~~29533~~).
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The value of the attribute.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The number of retries that ApsaraMQ for RocketMQ performed to send the message to consumers.
            /// </summary>
            [NameInMap("ReconsumeTimes")]
            [Validation(Required=false)]
            public int? ReconsumeTimes { get; set; }

            /// <summary>
            /// The ApsaraMQ for RocketMQ broker that stores the message.
            /// </summary>
            [NameInMap("StoreHost")]
            [Validation(Required=false)]
            public string StoreHost { get; set; }

            /// <summary>
            /// The size of the message. Unit: KB.
            /// </summary>
            [NameInMap("StoreSize")]
            [Validation(Required=false)]
            public int? StoreSize { get; set; }

            /// <summary>
            /// The timestamp that indicates the point in time when the ApsaraMQ for RocketMQ broker stored the message. Unit: milliseconds.
            /// </summary>
            [NameInMap("StoreTimestamp")]
            [Validation(Required=false)]
            public long? StoreTimestamp { get; set; }

            /// <summary>
            /// The topic to which the message belongs.
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
