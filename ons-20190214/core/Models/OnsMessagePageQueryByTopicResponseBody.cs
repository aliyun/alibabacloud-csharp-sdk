// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsMessagePageQueryByTopicResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the message that is queried.</para>
        /// </summary>
        [NameInMap("MsgFoundDo")]
        [Validation(Required=false)]
        public OnsMessagePageQueryByTopicResponseBodyMsgFoundDo MsgFoundDo { get; set; }
        public class OnsMessagePageQueryByTopicResponseBodyMsgFoundDo : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            /// <summary>
            /// <para>The total number of returned pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("MaxPageCount")]
            [Validation(Required=false)]
            public long? MaxPageCount { get; set; }

            /// <summary>
            /// <para>The information about messages on the returned page. The information that is contained in this parameter is the same as the information that is returned by the <a href="https://help.aliyun.com/document_detail/29607.html">OnsMessageGetByMsgId</a> operation.</para>
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
                    /// <para>The cyclic redundancy check (CRC) value of the message body.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>914112295</para>
                    /// </summary>
                    [NameInMap("BodyCRC")]
                    [Validation(Required=false)]
                    public int? BodyCRC { get; set; }

                    /// <summary>
                    /// <para>The producer client that generated the message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>42.120.<em><b>.</b></em>:59270</para>
                    /// </summary>
                    [NameInMap("BornHost")]
                    [Validation(Required=false)]
                    public string BornHost { get; set; }

                    /// <summary>
                    /// <para>The time when the message was generated. The value is a UNIX timestamp that represents the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1570760999721</para>
                    /// </summary>
                    [NameInMap("BornTimestamp")]
                    [Validation(Required=false)]
                    public long? BornTimestamp { get; set; }

                    /// <summary>
                    /// <para>The ID of the instance</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MQ_INST_111111111111_DOxxxxxx</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The ID of the message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1E0578FE110F18B4AAC235C05F2*****</para>
                    /// </summary>
                    [NameInMap("MsgId")]
                    [Validation(Required=false)]
                    public string MsgId { get; set; }

                    /// <summary>
                    /// <para>The attributes of the message.</para>
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
                            /// <para>The name of the attribute. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>TRACE_ON</b>: indicates whether a trace of the message exists.</description></item>
                            /// <item><description><b>KEYS</b>: indicates the key of the message.</description></item>
                            /// <item><description><b>TAGS</b>: indicates the tag of the message.</description></item>
                            /// <item><description><b>INSTANCE_ID</b>: indicates the ID of the instance that contains the message.</description></item>
                            /// </list>
                            /// <para>For information about the terms that are used in ApsaraMQ for RocketMQ see <a href="https://help.aliyun.com/document_detail/29533.html">Terms</a>.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TAGS</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <para>The value of the attribute.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>TagA</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The number of retries that were performed to send the message to consumers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ReconsumeTimes")]
                    [Validation(Required=false)]
                    public int? ReconsumeTimes { get; set; }

                    /// <summary>
                    /// <para>The ApsaraMQ for RocketMQ broker that stores the message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>11.193.<em><b>.</b></em>:10911</para>
                    /// </summary>
                    [NameInMap("StoreHost")]
                    [Validation(Required=false)]
                    public string StoreHost { get; set; }

                    /// <summary>
                    /// <para>The size of the message. Unit: KB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>406</para>
                    /// </summary>
                    [NameInMap("StoreSize")]
                    [Validation(Required=false)]
                    public int? StoreSize { get; set; }

                    /// <summary>
                    /// <para>The time when the ApsaraMQ for RocketMQ broker stored the message. The value is a UNIX timestamp that represents the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1570760999811</para>
                    /// </summary>
                    [NameInMap("StoreTimestamp")]
                    [Validation(Required=false)]
                    public long? StoreTimestamp { get; set; }

                    /// <summary>
                    /// <para>The topic to which the message belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-mq_topic</para>
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }

            }

            /// <summary>
            /// <para>The ID of the query task. The first time you call this operation to query the messages that are sent to a specified consumer group within a specified time range, this parameter is returned. You can use the task ID to query the details of messages on other returned pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0BC1310300002A9F000021E4D7A48346</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5DC2A47E-2B31-4722-96C8-FA59C9*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
