// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class GetQueueAttributesResponseBody : TeaModel {
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
        public GetQueueAttributesResponseBodyData Data { get; set; }
        public class GetQueueAttributesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The approximate total number of messages in the Active state in the queue.</para>
            /// <para><warning>This field will be deprecated and default to 0. We recommend that you use the CloudMonitor API to obtain metrics.</warning></para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ActiveMessages")]
            [Validation(Required=false)]
            public long? ActiveMessages { get; set; }

            /// <summary>
            /// <para>The time when the queue was created. The value is a UNIX timestamp in seconds in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1250700999</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The approximate total number of messages in the Delayed state in the queue.</para>
            /// <para><warning>This field will be deprecated and default to 0. We recommend that you use the CloudMonitor API to obtain metrics.</warning></para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DelayMessages")]
            [Validation(Required=false)]
            public long? DelayMessages { get; set; }

            /// <summary>
            /// <para>The delay time for all messages sent to the queue. Messages sent to the queue can be consumed only after the delay time specified by this parameter elapses. Unit: seconds.</para>
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
            public GetQueueAttributesResponseBodyDataDlqPolicy DlqPolicy { get; set; }
            public class GetQueueAttributesResponseBodyDataDlqPolicy : TeaModel {
                /// <summary>
                /// <para>The destination queue for dead-letter message delivery.</para>
                /// 
                /// <b>Example:</b>
                /// <para>deadLetterTargetQueue</para>
                /// </summary>
                [NameInMap("DeadLetterTargetQueue")]
                [Validation(Required=false)]
                public string DeadLetterTargetQueue { get; set; }

                /// <summary>
                /// <para>Specifies whether dead-letter message delivery is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The maximum number of delivery attempts for a message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("MaxReceiveCount")]
                [Validation(Required=false)]
                public string MaxReceiveCount { get; set; }

            }

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
            /// <para>Specifies whether server-side encryption is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EncryptionEnabled")]
            [Validation(Required=false)]
            public bool? EncryptionEnabled { get; set; }

            /// <summary>
            /// <para>The approximate total number of messages in the Inactive state in the queue.</para>
            /// <para><warning>This field will be deprecated and default to 0. We recommend that you use the CloudMonitor API to obtain metrics.</warning></para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InactiveMessages")]
            [Validation(Required=false)]
            public long? InactiveMessages { get; set; }

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
            /// <para>The time when the queue attributes were last modified. The value is a UNIX timestamp in seconds in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1250700999</para>
            /// </summary>
            [NameInMap("LastModifyTime")]
            [Validation(Required=false)]
            public long? LastModifyTime { get; set; }

            /// <summary>
            /// <para>Specifies whether the log management feature is enabled.</para>
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
            /// <para>The maximum length of the message body that can be sent to the queue. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>65536</para>
            /// </summary>
            [NameInMap("MaximumMessageSize")]
            [Validation(Required=false)]
            public long? MaximumMessageSize { get; set; }

            /// <summary>
            /// <para>The maximum retention period of messages in the queue. After the time specified by this parameter elapses from the time when a message is sent to the queue, the message is deleted regardless of whether it has been consumed. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>65536</para>
            /// </summary>
            [NameInMap("MessageRetentionPeriod")]
            [Validation(Required=false)]
            public long? MessageRetentionPeriod { get; set; }

            /// <summary>
            /// <para>The maximum waiting time for a ReceiveMessage request when the queue is empty. Unit: seconds.</para>
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
            /// <para>The queue type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>normal: Standard queue.</description></item>
            /// <item><description>fifo: FIFO queue.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("QueueType")]
            [Validation(Required=false)]
            public string QueueType { get; set; }

            /// <summary>
            /// <para>The server-side encryption algorithm. Currently, only AES-256-GCM is supported. If this parameter is not specified, the default algorithm is used.</para>
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
            public List<GetQueueAttributesResponseBodyDataTags> Tags { get; set; }
            public class GetQueueAttributesResponseBodyDataTags : TeaModel {
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
            /// <para>The throttling policy.</para>
            /// </summary>
            [NameInMap("TenantRateLimitPolicy")]
            [Validation(Required=false)]
            public GetQueueAttributesResponseBodyDataTenantRateLimitPolicy TenantRateLimitPolicy { get; set; }
            public class GetQueueAttributesResponseBodyDataTenantRateLimitPolicy : TeaModel {
                /// <summary>
                /// <para>Specifies whether throttling is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The maximum number of receives per second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("MaxReceivesPerSecond")]
                [Validation(Required=false)]
                public int? MaxReceivesPerSecond { get; set; }

            }

            /// <summary>
            /// <para>The duration for which a message remains in the Inactive state after it is consumed from the queue.
            /// Valid values: 1 to 43200. Unit: seconds.
            /// Default value: 30.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("VisibilityTimeout")]
            [Validation(Required=false)]
            public long? VisibilityTimeout { get; set; }

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
        /// <para>The response status.</para>
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
