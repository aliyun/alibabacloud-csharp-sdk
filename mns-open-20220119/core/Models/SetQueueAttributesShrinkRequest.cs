// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class SetQueueAttributesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The delay time for all messages sent to this queue. Messages sent to the queue can be consumed only after the delay time specified by this parameter has elapsed.</para>
        /// <para>Valid values: 0 to 604800. Unit: seconds.</para>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DelaySeconds")]
        [Validation(Required=false)]
        public long? DelaySeconds { get; set; }

        /// <summary>
        /// <para>The dead-letter queue policy.</para>
        /// </summary>
        [NameInMap("DlqPolicy")]
        [Validation(Required=false)]
        public string DlqPolicyShrink { get; set; }

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
        /// <para>The maximum length of the message body sent to this queue.</para>
        /// <para>Valid values: 1024 to 65536. Unit: bytes.</para>
        /// <para>Default value: 65536.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("MaximumMessageSize")]
        [Validation(Required=false)]
        public long? MaximumMessageSize { get; set; }

        /// <summary>
        /// <para>The maximum duration for which a message is retained in this queue. After the time specified by this parameter has elapsed since the message was sent to the queue, the message is deleted regardless of whether it has been consumed.</para>
        /// <para>Valid values: 60 to 604800. Unit: seconds.</para>
        /// <para>Default value: 345600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("MessageRetentionPeriod")]
        [Validation(Required=false)]
        public long? MessageRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The maximum wait time for a ReceiveMessage request on this queue when no messages are available in the queue.</para>
        /// <para>Valid values: 0 to 30. Unit: seconds.</para>
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
        /// <para>testqueue</para>
        /// </summary>
        [NameInMap("QueueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

        [NameInMap("SseAlgorithm")]
        [Validation(Required=false)]
        public string SseAlgorithm { get; set; }

        [NameInMap("SseType")]
        [Validation(Required=false)]
        public string SseType { get; set; }

        [NameInMap("TenantRateLimitPolicy")]
        [Validation(Required=false)]
        public string TenantRateLimitPolicyShrink { get; set; }

        /// <summary>
        /// <para>The duration for which a message stays in the Inactive state after it is consumed from the queue and changes from the Active state to the Inactive state.</para>
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

}
