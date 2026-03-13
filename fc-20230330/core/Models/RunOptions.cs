// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class RunOptions : TeaModel {
        /// <summary>
        /// <para>The batch window configurations.</para>
        /// </summary>
        [NameInMap("batchWindow")]
        [Validation(Required=false)]
        public BatchWindow BatchWindow { get; set; }

        /// <summary>
        /// <para>Whether to enable dead-letter queues. If you configure this parameter, dead-letter queues are enabled. By default, dead-letter queues are not enabled and messages are discarded when the retry policy is exhausted. Queues of Simple Message Queue (formerly MNS), ApsaraMQ for RocketMQ, and ApsaraMQ for Kafka, and EventBridge event buses can be used as dead-letter queues.</para>
        /// </summary>
        [NameInMap("deadLetterQueue")]
        [Validation(Required=false)]
        public DeadLetterQueue DeadLetterQueue { get; set; }

        /// <summary>
        /// <para>The fault tolerance policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NONE</b>: does not tolerate exceptions.</description></item>
        /// <item><description><b>ALL</b>: tolerates all exceptions.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The default value is <b>NONE</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("errorsTolerance")]
        [Validation(Required=false)]
        public string ErrorsTolerance { get; set; }

        /// <summary>
        /// <para>The underlying application mode when message data is pushed to Function Compute. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>event-streaming</b>: the event streaming mode. In this mode, events are pushed in arrays. One or more message events are pushed to the function in batches based on your push configurations. This mode is suitable for end-to-end streaming data processing scenarios. The event streaming mode supports the following event sources: Simple Message Queue (formerly MNS), ApsaraMQ for RocketMQ, ApsaraMQ for RabbitMQ, ApsaraMQ for Kafka, ApsaraMQ for MQTT, and Data Transmission Service (DTS).</description></item>
        /// <item><description><b>event-driven</b>: the event mode. In event mode, a single message is passed to the function as event parameters at a time. Events follow the CloudEvents specifications. The event mode supports the following event sources: Default, Simple Message Queue (formerly MNS), ApsaraMQ for RocketMQ, and ApsaraMQ for RabbitMQ. In this mode, batch configurations are not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>event-streaming</para>
        /// </summary>
        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The retry policy that you want to use if events fail to be pushed.</para>
        /// </summary>
        [NameInMap("retryStrategy")]
        [Validation(Required=false)]
        public RetryStrategy RetryStrategy { get; set; }

    }

}
