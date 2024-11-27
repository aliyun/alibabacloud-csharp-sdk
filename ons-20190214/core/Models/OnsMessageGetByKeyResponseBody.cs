// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsMessageGetByKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of returned results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsMessageGetByKeyResponseBodyData Data { get; set; }
        public class OnsMessageGetByKeyResponseBodyData : TeaModel {
            [NameInMap("OnsRestMessageDo")]
            [Validation(Required=false)]
            public List<OnsMessageGetByKeyResponseBodyDataOnsRestMessageDo> OnsRestMessageDo { get; set; }
            public class OnsMessageGetByKeyResponseBodyDataOnsRestMessageDo : TeaModel {
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
                /// <para>The timestamp that indicates when the message was produced.</para>
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
                public OnsMessageGetByKeyResponseBodyDataOnsRestMessageDoPropertyList PropertyList { get; set; }
                public class OnsMessageGetByKeyResponseBodyDataOnsRestMessageDoPropertyList : TeaModel {
                    [NameInMap("MessageProperty")]
                    [Validation(Required=false)]
                    public List<OnsMessageGetByKeyResponseBodyDataOnsRestMessageDoPropertyListMessageProperty> MessageProperty { get; set; }
                    public class OnsMessageGetByKeyResponseBodyDataOnsRestMessageDoPropertyListMessageProperty : TeaModel {
                        /// <summary>
                        /// <para>The name of the attribute. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>TRACE_ON</b>: indicates whether the message trace exists.</para>
                        /// </description></item>
                        /// <item><description><para><b>KEYS</b>: indicates the key of the message.</para>
                        /// </description></item>
                        /// <item><description><para><b>TAGS</b>: indicates the tag that is attached to the message.</para>
                        /// </description></item>
                        /// <item><description><para><b>INSTANCE_ID</b>: indicates the ID of the instance that contains the message.</para>
                        /// </description></item>
                        /// </list>
                        /// <para>For information about the terms that are used in ApsaraMQ for RocketMQ, see <a href="https://help.aliyun.com/document_detail/29533.html">Terms</a>.</para>
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
                /// <para>The size of the message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>406</para>
                /// </summary>
                [NameInMap("StoreSize")]
                [Validation(Required=false)]
                public int? StoreSize { get; set; }

                /// <summary>
                /// <para>The timestamp that indicates when the ApsaraMQ for RocketMQ broker stored the message.</para>
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
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A07E3902-B92E-44A6-B6C5-6AA111111****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
