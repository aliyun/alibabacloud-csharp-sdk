// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class ListQueueResponseBody : TeaModel {
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
        public ListQueueResponseBodyData Data { get; set; }
        public class ListQueueResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The results returned on the current page.</para>
            /// </summary>
            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<ListQueueResponseBodyDataPageData> PageData { get; set; }
            public class ListQueueResponseBodyDataPageData : TeaModel {
                /// <summary>
                /// <para>The approximate total number of messages in the Active state in this queue.</para>
                /// <para>This field will default to 0 in the future and is not recommended. Use CloudMonitor API to retrieve this metric instead.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ActiveMessages")]
                [Validation(Required=false)]
                public long? ActiveMessages { get; set; }

                /// <summary>
                /// <para>The time when the queue was created. The value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1250700999</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The approximate total number of messages in the Delayed state in this queue.</para>
                /// <para>This field will default to 0 in the future and is not recommended. Use CloudMonitor API to retrieve this metric instead.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DelayMessages")]
                [Validation(Required=false)]
                public long? DelayMessages { get; set; }

                /// <summary>
                /// <para>The delay period after which all messages sent to this queue become consumable. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("DelaySeconds")]
                [Validation(Required=false)]
                public long? DelaySeconds { get; set; }

                /// <summary>
                /// <para>The dead-letter queue policy.</para>
                /// </summary>
                [NameInMap("DlqPolicy")]
                [Validation(Required=false)]
                public ListQueueResponseBodyDataPageDataDlqPolicy DlqPolicy { get; set; }
                public class ListQueueResponseBodyDataPageDataDlqPolicy : TeaModel {
                    /// <summary>
                    /// <para>The target queue for dead-letter message delivery.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>deadLetterTargetQueue</para>
                    /// </summary>
                    [NameInMap("DeadLetterTargetQueue")]
                    [Validation(Required=false)]
                    public string DeadLetterTargetQueue { get; set; }

                    /// <summary>
                    /// <para>Indicates whether dead-letter message delivery is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The maximum number of times a message can be delivered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("MaxReceiveCount")]
                    [Validation(Required=false)]
                    public string MaxReceiveCount { get; set; }

                }

                [NameInMap("EnableSSE")]
                [Validation(Required=false)]
                public bool? EnableSSE { get; set; }

                [NameInMap("EncryptionEnabled")]
                [Validation(Required=false)]
                public bool? EncryptionEnabled { get; set; }

                /// <summary>
                /// <para>The approximate total number of messages in the Inactive state in this queue.</para>
                /// <para>This field will default to 0 in the future and is not recommended. Use CloudMonitor API to retrieve this metric instead.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("InactiveMessages")]
                [Validation(Required=false)]
                public long? InactiveMessages { get; set; }

                [NameInMap("KmsKeyId")]
                [Validation(Required=false)]
                public string KmsKeyId { get; set; }

                /// <summary>
                /// <para>The most recent time when the queue attributes were modified. The value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1250700999</para>
                /// </summary>
                [NameInMap("LastModifyTime")]
                [Validation(Required=false)]
                public long? LastModifyTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the log management feature is enabled.</para>
                /// <list type="bullet">
                /// <item><description><para>True: Enabled.</para>
                /// </description></item>
                /// <item><description><para>False: Disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("LoggingEnabled")]
                [Validation(Required=false)]
                public bool? LoggingEnabled { get; set; }

                /// <summary>
                /// <para>The maximum size of a message body that can be sent to this queue. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65536</para>
                /// </summary>
                [NameInMap("MaximumMessageSize")]
                [Validation(Required=false)]
                public long? MaximumMessageSize { get; set; }

                /// <summary>
                /// <para>The maximum period for which a message can be retained in this queue. After the specified period elapses since a message is sent to the queue, the message is deleted regardless of whether it has been consumed. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65536</para>
                /// </summary>
                [NameInMap("MessageRetentionPeriod")]
                [Validation(Required=false)]
                public long? MessageRetentionPeriod { get; set; }

                /// <summary>
                /// <para>The maximum wait time for a ReceiveMessage request when the queue is empty. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PollingWaitSeconds")]
                [Validation(Required=false)]
                public long? PollingWaitSeconds { get; set; }

                /// <summary>
                /// <para>The name of the queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo-queue</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// <para>The type of the queue. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>normal: standard queue</description></item>
                /// <item><description>fifo: FIFO queue</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("QueueType")]
                [Validation(Required=false)]
                public string QueueType { get; set; }

                [NameInMap("SseAlgorithm")]
                [Validation(Required=false)]
                public string SseAlgorithm { get; set; }

                [NameInMap("SseType")]
                [Validation(Required=false)]
                public string SseType { get; set; }

                /// <summary>
                /// <para>The list of resource tags.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListQueueResponseBodyDataPageDataTags> Tags { get; set; }
                public class ListQueueResponseBodyDataPageDataTags : TeaModel {
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
                /// <para>The duration for which a message stays in the Inactive state after it is consumed from the queue.</para>
                /// <para>Valid values: 1 to 43200. Unit: seconds.</para>
                /// <para>Default value: 30.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("VisibilityTimeout")]
                [Validation(Required=false)]
                public long? VisibilityTimeout { get; set; }

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
            /// <para>The maximum number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Pages")]
            [Validation(Required=false)]
            public long? Pages { get; set; }

            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
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
