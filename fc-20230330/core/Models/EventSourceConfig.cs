// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class EventSourceConfig : TeaModel {
        /// <summary>
        /// <para>The event source. Custom event sources include Message Service (MNS), ApsaraMQ for RocketMQ, ApsaraMQ for RabbitMQ, ApsaraMQ for Kafka, ApsaraMQ for MQTT, and Data Transmission Service (DTS).</para>
        /// </summary>
        [NameInMap("eventSourceParameters")]
        [Validation(Required=false)]
        public EventSourceParameters EventSourceParameters { get; set; }

        /// <summary>
        /// <para>The event source type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Default</b>: Alibaba Cloud EventBridge sources</description></item>
        /// <item><description><b>MNS</b>: Message Service (MNS)</description></item>
        /// <item><description><b>RocketMQ</b>: ApsaraMQ for RocketMQ</description></item>
        /// <item><description><b>RabbitMQ</b>: ApsaraMQ for RabbitMQ</description></item>
        /// <item><description><b>Kafka</b>: ApsaraMQ for Kafka</description></item>
        /// <item><description><b>MQTT</b>: ApsaraMQ for MQTT</description></item>
        /// <item><description><b>DTS</b>: DTS</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter cannot be updated. If you specify this parameter when you update the configurations, it does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MNS</para>
        /// </summary>
        [NameInMap("eventSourceType")]
        [Validation(Required=false)]
        public string EventSourceType { get; set; }

    }

}
