// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsMessagePageQueryByTopicResponseBody : TeaModel {
        /// <summary>
        /// The information about the message that is queried.
        /// </summary>
        [NameInMap("MsgFoundDo")]
        [Validation(Required=false)]
        public OnsMessagePageQueryByTopicResponseBodyMsgFoundDo MsgFoundDo { get; set; }
        public class OnsMessagePageQueryByTopicResponseBodyMsgFoundDo : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            /// <summary>
            /// The total number of returned pages.
            /// </summary>
            [NameInMap("MaxPageCount")]
            [Validation(Required=false)]
            public long? MaxPageCount { get; set; }

            /// <summary>
            /// The information about messages on the returned page. The information that is contained in this parameter is the same as the information that is returned by the [OnsMessageGetByMsgId](~~29607~~) operation.
            /// </summary>
            [NameInMap("MsgFoundList")]
            [Validation(Required=false)]
            public OnsMessagePageQueryByTopicResponseBodyMsgFoundDoMsgFoundList MsgFoundList { get; set; }
            public class OnsMessagePageQueryByTopicResponseBodyMsgFoundDoMsgFoundList : TeaModel {
                [NameInMap("OnsRestMessageDo")]
                [Validation(Required=false)]
                public List<OnsMessagePageQueryByTopicResponseBodyMsgFoundDoMsgFoundListOnsRestMessageDo> OnsRestMessageDo { get; set; }
                public class OnsMessagePageQueryByTopicResponseBodyMsgFoundDoMsgFoundListOnsRestMessageDo : TeaModel {
                    /// <summary>
                    /// The cyclic redundancy check (CRC) value of the message body.
                    /// </summary>
                    [NameInMap("BodyCRC")]
                    [Validation(Required=false)]
                    public int? BodyCRC { get; set; }

                    /// <summary>
                    /// The producer client that generated the message.
                    /// </summary>
                    [NameInMap("BornHost")]
                    [Validation(Required=false)]
                    public string BornHost { get; set; }

                    /// <summary>
                    /// The time when the message was generated. The value is a UNIX timestamp that represents the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
                    /// </summary>
                    [NameInMap("BornTimestamp")]
                    [Validation(Required=false)]
                    public long? BornTimestamp { get; set; }

                    /// <summary>
                    /// The ID of the instance
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
                    public OnsMessagePageQueryByTopicResponseBodyMsgFoundDoMsgFoundListOnsRestMessageDoPropertyList PropertyList { get; set; }
                    public class OnsMessagePageQueryByTopicResponseBodyMsgFoundDoMsgFoundListOnsRestMessageDoPropertyList : TeaModel {
                        [NameInMap("MessageProperty")]
                        [Validation(Required=false)]
                        public List<OnsMessagePageQueryByTopicResponseBodyMsgFoundDoMsgFoundListOnsRestMessageDoPropertyListMessageProperty> MessageProperty { get; set; }
                        public class OnsMessagePageQueryByTopicResponseBodyMsgFoundDoMsgFoundListOnsRestMessageDoPropertyListMessageProperty : TeaModel {
                            /// <summary>
                            /// The name of the attribute. Valid values:
                            /// 
                            /// *   **TRACE_ON**: indicates whether a trace of the message exists.
                            /// *   **KEYS**: indicates the key of the message.
                            /// *   **TAGS**: indicates the tag of the message.
                            /// *   **INSTANCE_ID**: indicates the ID of the instance that contains the message.
                            /// 
                            /// For information about the terms that are used in ApsaraMQ for RocketMQ see [Terms](~~29533~~).
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

                    }

                    /// <summary>
                    /// The number of retries that were performed to send the message to consumers.
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
                    /// The time when the ApsaraMQ for RocketMQ broker stored the message. The value is a UNIX timestamp that represents the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
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

            }

            /// <summary>
            /// The ID of the query task. The first time you call this operation to query the messages that are sent to a specified consumer group within a specified time range, this parameter is returned. You can use the task ID to query the details of messages on other returned pages.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
