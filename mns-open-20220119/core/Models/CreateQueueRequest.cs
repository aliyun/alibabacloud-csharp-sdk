// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class CreateQueueRequest : TeaModel {
        /// <summary>
        /// <para>The delay time for all messages sent to the queue. A message can be consumed only after the specified delay time elapses from the time it is sent to the queue. Valid values: 0 to 604800. Unit: seconds. Default value: 0.</para>
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
            /// <para>The destination queue for dead-letter messages.</para>
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
            /// <para>The maximum number of receive attempts for a message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MaxReceiveCount")]
            [Validation(Required=false)]
            public int? MaxReceiveCount { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable the Log Management feature. Valid values:</para>
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

        /// <summary>
        /// <para>Specifies whether log broker encryption is enabled. Valid values: true and false.</para>
        /// </summary>
        [NameInMap("EnableSSE")]
        [Validation(Required=false)]
        public bool? EnableSSE { get; set; }

        /// <summary>
        /// <para>The KMS key ID. This parameter is required only when SseType is set to KMS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key-xxx</para>
        /// </summary>
        [NameInMap("KmsKeyId")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// <para>The maximum size of a message body that can be sent to the queue. Valid values: 1024 to 65536. Unit: bytes. Default value: 65536.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65536</para>
        /// </summary>
        [NameInMap("MaximumMessageSize")]
        [Validation(Required=false)]
        public long? MaximumMessageSize { get; set; }

        /// <summary>
        /// <para>The maximum retention period of a message in the queue. After the specified period elapses from the time the message is sent to the queue, the message is deleted regardless of whether it has been received. Valid values: 60 to 604800. Unit: seconds. Default value: 345600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>345600</para>
        /// </summary>
        [NameInMap("MessageRetentionPeriod")]
        [Validation(Required=false)]
        public long? MessageRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The maximum wait time for a ReceiveMessage request when no messages are available in the queue. Valid values: 0 to 30. Unit: seconds. Default value: 0.</para>
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
        /// <para>The storage encryption algorithm. AES-256-GCM is supported. If you do not specify this parameter, the default algorithm is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AES-256-GCM</para>
        /// </summary>
        [NameInMap("SseAlgorithm")]
        [Validation(Required=false)]
        public string SseAlgorithm { get; set; }

        /// <summary>
        /// <para>The storage encryption method. Valid values: SMQ and KMS.</para>
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
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateQueueRequestTag> Tag { get; set; }
        public class CreateQueueRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The throttling policy.</para>
        /// </summary>
        [NameInMap("TenantRateLimitPolicy")]
        [Validation(Required=false)]
        public CreateQueueRequestTenantRateLimitPolicy TenantRateLimitPolicy { get; set; }
        public class CreateQueueRequestTenantRateLimitPolicy : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable throttling. Valid values:</para>
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
        /// <para>The duration for which a message remains in the inactive state after it is received from the queue. Valid values: 1 to 43200. Unit: seconds. Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("VisibilityTimeout")]
        [Validation(Required=false)]
        public long? VisibilityTimeout { get; set; }

    }

}
