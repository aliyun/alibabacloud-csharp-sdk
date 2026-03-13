// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class EventSourceParameters : TeaModel {
        /// <summary>
        /// <para>The custom configurations when the event source is Data Transmission Service (DTS).</para>
        /// </summary>
        [NameInMap("sourceDTSParameters")]
        [Validation(Required=false)]
        public SourceDTSParameters SourceDTSParameters { get; set; }

        /// <summary>
        /// <para>The custom configurations when the event source is ApsaraMQ for Kafka.</para>
        /// </summary>
        [NameInMap("sourceKafkaParameters")]
        [Validation(Required=false)]
        public SourceKafkaParameters SourceKafkaParameters { get; set; }

        /// <summary>
        /// <para>The custom configurations when the event source is Simple Message Queue (formerly MNS).</para>
        /// </summary>
        [NameInMap("sourceMNSParameters")]
        [Validation(Required=false)]
        public SourceMNSParameters SourceMNSParameters { get; set; }

        /// <summary>
        /// <para>The custom configurations when the event source is ApsaraMQ for MQTT.</para>
        /// </summary>
        [NameInMap("sourceMQTTParameters")]
        [Validation(Required=false)]
        public SourceMQTTParameters SourceMQTTParameters { get; set; }

        /// <summary>
        /// <para>The custom configurations when the event source is ApsaraMQ for RabbitMQ.</para>
        /// </summary>
        [NameInMap("sourceRabbitMQParameters")]
        [Validation(Required=false)]
        public SourceRabbitMQParameters SourceRabbitMQParameters { get; set; }

        /// <summary>
        /// <para>The custom configurations when the event source is ApsaraMQ for RocketMQ.</para>
        /// </summary>
        [NameInMap("sourceRocketMQParameters")]
        [Validation(Required=false)]
        public SourceRocketMQParameters SourceRocketMQParameters { get; set; }

    }

}
