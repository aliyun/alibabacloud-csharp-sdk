// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class ListTopicResponseBody : TeaModel {
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
        public ListTopicResponseBodyData Data { get; set; }
        public class ListTopicResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The results returned on the current page.</para>
            /// </summary>
            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<ListTopicResponseBodyDataPageData> PageData { get; set; }
            public class ListTopicResponseBodyDataPageData : TeaModel {
                /// <summary>
                /// <para>The time when the topic was created. The value is a UTC UNIX timestamp in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1449554962</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>Specifies whether server-side encryption is enabled. Valid values: true and false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableSSE")]
                [Validation(Required=false)]
                public bool? EnableSSE { get; set; }

                /// <summary>
                /// <para>Indicates whether server-side encryption is enabled.</para>
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
                /// <para>The time when the topic attributes were last modified. The value is a UTC UNIX timestamp in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1449554962</para>
                /// </summary>
                [NameInMap("LastModifyTime")]
                [Validation(Required=false)]
                public long? LastModifyTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the log management feature is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>True: enabled</description></item>
                /// <item><description>False: disabled</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("LoggingEnabled")]
                [Validation(Required=false)]
                public bool? LoggingEnabled { get; set; }

                /// <summary>
                /// <para>The maximum length of the message body that can be sent to the topic. Unit: bytes.</para>
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
                /// <para>The maximum retention period of messages in the topic. After the specified period elapses from the time a message is sent to the topic, the message is deleted regardless of whether it is successfully pushed to users. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86400</para>
                /// </summary>
                [NameInMap("MessageRetentionPeriod")]
                [Validation(Required=false)]
                public long? MessageRetentionPeriod { get; set; }

                /// <summary>
                /// <para>The server-side encryption algorithm. Currently, AES-256-GCM is supported. If this parameter is not specified, the default algorithm is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AES-256-GCM</para>
                /// </summary>
                [NameInMap("SseAlgorithm")]
                [Validation(Required=false)]
                public string SseAlgorithm { get; set; }

                /// <summary>
                /// <para>The server-side encryption method. Valid values: SMQ and KMS.</para>
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
                public List<ListTopicResponseBodyDataPageDataTags> Tags { get; set; }
                public class ListTopicResponseBodyDataPageDataTags : TeaModel {
                    /// <summary>
                    /// <para>The key of the tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tag1</para>
                    /// </summary>
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    /// <summary>
                    /// <para>The value of the tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

                /// <summary>
                /// <para>The internal URL of the topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http:// 111111111****.mns.us-west-1-internal.aliyuncs.com/topics/testTopic</para>
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
                /// <para>The type of the topic. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>normal: normal topic</description></item>
                /// <item><description>fifo: FIFO topic</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("TopicType")]
                [Validation(Required=false)]
                public string TopicType { get; set; }

                /// <summary>
                /// <para>The URL of the topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http:// 111111111****.mns.us-west-1.aliyuncs.com/topics/testTopic</para>
                /// </summary>
                [NameInMap("TopicUrl")]
                [Validation(Required=false)]
                public string TopicUrl { get; set; }

            }

            /// <summary>
            /// <para>The page number of the returned results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries returned on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>130</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

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
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
