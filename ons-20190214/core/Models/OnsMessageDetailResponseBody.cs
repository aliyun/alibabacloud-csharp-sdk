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
            /// The body of the message.
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
            /// 消息体内容。
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
            /// The ID of the Message Queue for Apache RocketMQ Instance.
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
                /// *   **BODY**: indicates the message body
                /// *   **TRACE_ON**: indicates whether the trace of the message exists.
                /// *   **KEYS**: indicates the key of the message.
                /// *   **TAGS**: indicates the tag that is attached to the message.
                /// *   **INSTANCE_ID**: indicates the ID of the instance that contains the message.
                /// 
                /// For more information about the terms that are used in Message Queue for Apache RocketMQ, see [Terms](~~29533~~).
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
            /// The number of retries that Message Queue for Apache RocketMQ performed to send the message to consumers.
            /// </summary>
            [NameInMap("ReconsumeTimes")]
            [Validation(Required=false)]
            public int? ReconsumeTimes { get; set; }

            /// <summary>
            /// The Message Queue for Apache RocketMQ broker that stores the message.
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
            /// The timestamp that indicates the point in time when the Message Queue for Apache RocketMQ broker stored the message. Unit: milliseconds.
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
