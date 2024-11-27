// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsMessageDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsMessageDetailResponseBodyData Data { get; set; }
        public class OnsMessageDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The string that is obtained after the message body is encrypted by using the Base 64 algorithm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aGVsbG8=</para>
            /// </summary>
            [NameInMap("Body")]
            [Validation(Required=false)]
            public string Body { get; set; }

            /// <summary>
            /// <para>The cyclic redundancy check (CRC) value of the message body.</para>
            /// 
            /// <b>Example:</b>
            /// <para>907060870</para>
            /// </summary>
            [NameInMap("BodyCRC")]
            [Validation(Required=false)]
            public int? BodyCRC { get; set; }

            /// <summary>
            /// <para>The information about the message body.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hello</para>
            /// </summary>
            [NameInMap("BodyStr")]
            [Validation(Required=false)]
            public string BodyStr { get; set; }

            /// <summary>
            /// <para>The producer instance that generated the message.</para>
            /// 
            /// <b>Example:</b>
            /// <para><c>42.120.**.**</c>:64646</para>
            /// </summary>
            [NameInMap("BornHost")]
            [Validation(Required=false)]
            public string BornHost { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates the point in time when the message was generated. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1570761026630</para>
            /// </summary>
            [NameInMap("BornTimestamp")]
            [Validation(Required=false)]
            public long? BornTimestamp { get; set; }

            /// <summary>
            /// <para>The ID of the ApsaraMQ for RocketMQ Instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MQ_INST_184681981******_BXig0x6A</para>
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
            public List<OnsMessageDetailResponseBodyDataPropertyList> PropertyList { get; set; }
            public class OnsMessageDetailResponseBodyDataPropertyList : TeaModel {
                /// <summary>
                /// <para>The name of the attribute. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>TRACE_ON</b>: indicates whether the trace of the message exists.</description></item>
                /// <item><description><b>MSG_REGION</b>: The region ID of the instance to which the topic belongs.</description></item>
                /// <item><description><b>__MESSAGE_DECODED_TIME</b>: The time when the message was decoded.</description></item>
                /// <item><description><b>__BORNHOST</b>: The IP address of the producer client.</description></item>
                /// <item><description><b>UNIQ_KEY</b>: The ID of the message.</description></item>
                /// </list>
                /// <para>For information about the terms that are used in ApsaraMQ for RocketMQ, see <a href="https://help.aliyun.com/document_detail/29533.html">Terms</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the attribute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MSG_REGION</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The number of retries that ApsaraMQ for RocketMQ performed to send the message to consumers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ReconsumeTimes")]
            [Validation(Required=false)]
            public int? ReconsumeTimes { get; set; }

            /// <summary>
            /// <para>The ApsaraMQ for RocketMQ broker that stores the message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11.220.<em><b>.</b></em>:10911</para>
            /// </summary>
            [NameInMap("StoreHost")]
            [Validation(Required=false)]
            public string StoreHost { get; set; }

            /// <summary>
            /// <para>The size of the message. Unit: KB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("StoreSize")]
            [Validation(Required=false)]
            public int? StoreSize { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates the point in time when the ApsaraMQ for RocketMQ broker stored the message. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1570761026708</para>
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

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EAE5BE23-37A1-4354-94D6-E44AE17E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
