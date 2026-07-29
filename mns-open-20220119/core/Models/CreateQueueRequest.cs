// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class CreateQueueRequest : TeaModel {
        /// <summary>
        /// <para>The delay period for all messages sent to the queue. A message sent to the queue can be consumed only after the delay period specified by this parameter elapses. Unit: seconds.</para>
        /// <para>Valid values: 0 to 604800.</para>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DelaySeconds")]
        [Validation(Required=false)]
        public long? DelaySeconds { get; set; }

        /// <summary>
        /// <para>The dead-letter policy.</para>
        /// </summary>
        [NameInMap("DlqPolicy")]
        [Validation(Required=false)]
        public CreateQueueRequestDlqPolicy DlqPolicy { get; set; }
        public class CreateQueueRequestDlqPolicy : TeaModel {
            /// <summary>
            /// <para>The target queue for dead-letter message delivery.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deadLetterQueue</para>
            /// </summary>
            [NameInMap("DeadLetterTargetQueue")]
            [Validation(Required=false)]
            public string DeadLetterTargetQueue { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable dead-letter message delivery.</para>
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
            public int? MaxReceiveCount { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable the log management feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enabled.</para>
        /// </description></item>
        /// <item><description><para>false: Disabled.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableLogging")]
        [Validation(Required=false)]
        public bool? EnableLogging { get; set; }

        [NameInMap("EnableSSE")]
        [Validation(Required=false)]
        public bool? EnableSSE { get; set; }

        [NameInMap("KmsKeyId")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// <para>The maximum size of a message body that can be sent to the queue. Unit: bytes.</para>
        /// <para>Valid values: 1024 to 65536.</para>
        /// <para>Default value: 65536.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65536</para>
        /// </summary>
        [NameInMap("MaximumMessageSize")]
        [Validation(Required=false)]
        public long? MaximumMessageSize { get; set; }

        /// <summary>
        /// <para>The maximum duration for which a message is retained in the queue. After the specified duration elapses from the time the message is sent to the queue, the message is deleted regardless of whether it has been consumed. Unit: seconds.</para>
        /// <para>Valid values: 60 to 604800.</para>
        /// <para>Default value: 345600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>345600</para>
        /// </summary>
        [NameInMap("MessageRetentionPeriod")]
        [Validation(Required=false)]
        public long? MessageRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The maximum wait time for a ReceiveMessage request when the queue is empty. Unit: seconds.</para>
        /// <para>Valid values: 0 to 30.</para>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PollingWaitSeconds")]
        [Validation(Required=false)]
        public long? PollingWaitSeconds { get; set; }

        /// <summary>
        /// <para>The name of the queue.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06273500-249F-5863-121D-74D51123****</para>
        /// </summary>
        [NameInMap("QueueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

        /// <summary>
        /// <para>The type of the queue. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>normal: standard queue.</description></item>
        /// <item><description>fifo: FIFO queue.</description></item>
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
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateQueueRequestTag> Tag { get; set; }
        public class CreateQueueRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The rate limiting policy.</para>
        /// </summary>
        [NameInMap("TenantRateLimitPolicy")]
        [Validation(Required=false)]
        public CreateQueueRequestTenantRateLimitPolicy TenantRateLimitPolicy { get; set; }
        public class CreateQueueRequestTenantRateLimitPolicy : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable rate limiting. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
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
        /// <para>The duration for which a consumed message stays in the Inactive state after it is changed from the Active state. Unit: seconds.</para>
        /// <para>Valid values: 1 to 43200.</para>
        /// <para>Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("VisibilityTimeout")]
        [Validation(Required=false)]
        public long? VisibilityTimeout { get; set; }

    }

}
