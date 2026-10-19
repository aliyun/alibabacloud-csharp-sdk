// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class GetTopicAttributesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTopicAttributesResponseBodyData Data { get; set; }
        public class GetTopicAttributesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the topic was created. The value is a UNIX timestamp in seconds in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1449554277</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether storage encryption is enabled. Valid values: true and false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableSSE")]
            [Validation(Required=false)]
            public bool? EnableSSE { get; set; }

            /// <summary>
            /// <para>Indicates whether storage encryption is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EncryptionEnabled")]
            [Validation(Required=false)]
            public bool? EncryptionEnabled { get; set; }

            /// <summary>
            /// <para>The KMS key ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key-xxx</para>
            /// </summary>
            [NameInMap("KmsKeyId")]
            [Validation(Required=false)]
            public string KmsKeyId { get; set; }

            /// <summary>
            /// <para>The time when the topic attributes were last modified. The value is a UNIX timestamp in seconds in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1449554460</para>
            /// </summary>
            [NameInMap("LastModifyTime")]
            [Validation(Required=false)]
            public long? LastModifyTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the log management feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>True: Enabled.</description></item>
            /// <item><description>False: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("LoggingEnabled")]
            [Validation(Required=false)]
            public bool? LoggingEnabled { get; set; }

            /// <summary>
            /// <para>The maximum size of a message body sent to the topic. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>65536</para>
            /// </summary>
            [NameInMap("MaxMessageSize")]
            [Validation(Required=false)]
            public long? MaxMessageSize { get; set; }

            /// <summary>
            /// <para>The number of messages in the topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MessageCount")]
            [Validation(Required=false)]
            public long? MessageCount { get; set; }

            /// <summary>
            /// <para>The maximum retention period of a message in the topic. After the specified period elapses from the time the message is sent to the topic, the message is deleted regardless of whether it was successfully pushed to users. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("MessageRetentionPeriod")]
            [Validation(Required=false)]
            public long? MessageRetentionPeriod { get; set; }

            /// <summary>
            /// <para>The storage encryption algorithm. Currently, only AES-256-GCM is supported. If this parameter is not specified, the default algorithm is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AES-256-GCM</para>
            /// </summary>
            [NameInMap("SseAlgorithm")]
            [Validation(Required=false)]
            public string SseAlgorithm { get; set; }

            /// <summary>
            /// <para>The storage encryption type. Valid values: SMQ and KMS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KMS</para>
            /// </summary>
            [NameInMap("SseType")]
            [Validation(Required=false)]
            public string SseType { get; set; }

            /// <summary>
            /// <para>The list of resource tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetTopicAttributesResponseBodyDataTags> Tags { get; set; }
            public class GetTopicAttributesResponseBodyDataTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag1</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The internal access URL of the topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://111111111****.mns.us-west-1-internal.aliyuncs.com/topics/testTopic">http://111111111****.mns.us-west-1-internal.aliyuncs.com/topics/testTopic</a></para>
            /// </summary>
            [NameInMap("TopicInnerUrl")]
            [Validation(Required=false)]
            public string TopicInnerUrl { get; set; }

            /// <summary>
            /// <para>The name of the topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo-topic</para>
            /// </summary>
            [NameInMap("TopicName")]
            [Validation(Required=false)]
            public string TopicName { get; set; }

            /// <summary>
            /// <para>The topic type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>normal: Normal topic.</description></item>
            /// <item><description>fifo: FIFO topic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("TopicType")]
            [Validation(Required=false)]
            public string TopicType { get; set; }

            /// <summary>
            /// <para>The public network access URL of the topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://111111111****.mns.us-west-1.aliyuncs.com/topics/testTopic">http://111111111****.mns.us-west-1.aliyuncs.com/topics/testTopic</a></para>
            /// </summary>
            [NameInMap("TopicUrl")]
            [Validation(Required=false)]
            public string TopicUrl { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06273500-249F-5863-121D-74D51123****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
