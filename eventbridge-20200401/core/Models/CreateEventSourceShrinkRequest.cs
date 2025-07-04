// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateEventSourceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the event source.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the event bus with which the event source is associated.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-event-bus</para>
        /// </summary>
        [NameInMap("EventBusName")]
        [Validation(Required=false)]
        public string EventBusName { get; set; }

        /// <summary>
        /// <para>The name of the event source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myrabbitmq.sourc</para>
        /// </summary>
        [NameInMap("EventSourceName")]
        [Validation(Required=false)]
        public string EventSourceName { get; set; }

        /// <summary>
        /// <para>The configurations of the external data source.</para>
        /// </summary>
        [NameInMap("ExternalSourceConfig")]
        [Validation(Required=false)]
        public string ExternalSourceConfigShrink { get; set; }

        /// <summary>
        /// <para>The type of the external data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RabbitMQ</para>
        /// </summary>
        [NameInMap("ExternalSourceType")]
        [Validation(Required=false)]
        public byte[] ExternalSourceType { get; set; }

        /// <summary>
        /// <para>Specify whether to connect to an external data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("LinkedExternalSource")]
        [Validation(Required=false)]
        public bool? LinkedExternalSource { get; set; }

        /// <summary>
        /// <para>The parameters that are configured if the event source is HTTP events.</para>
        /// </summary>
        [NameInMap("SourceHttpEventParameters")]
        [Validation(Required=false)]
        public string SourceHttpEventParametersShrink { get; set; }

        /// <summary>
        /// <para>The parameters that are configured if the event source is Message Queue for Apache Kafka.</para>
        /// </summary>
        [NameInMap("SourceKafkaParameters")]
        [Validation(Required=false)]
        public string SourceKafkaParametersShrink { get; set; }

        /// <summary>
        /// <para>The parameters that are configured if you specify Simple Message Queue (formerly MNS) (SMQ) as the event source. If you specify SMQ as the event source, you must configure RegionId, IsBase64Decode, and QueueName.</para>
        /// </summary>
        [NameInMap("SourceMNSParameters")]
        [Validation(Required=false)]
        public string SourceMNSParametersShrink { get; set; }

        /// <summary>
        /// <para>The parameters that are configured if the event source is Message Queue for RabbitMQ.</para>
        /// </summary>
        [NameInMap("SourceRabbitMQParameters")]
        [Validation(Required=false)]
        public string SourceRabbitMQParametersShrink { get; set; }

        /// <summary>
        /// <para>The parameters that are configured if the event source is Message Queue for Apache RocketMQ.</para>
        /// </summary>
        [NameInMap("SourceRocketMQParameters")]
        [Validation(Required=false)]
        public string SourceRocketMQParametersShrink { get; set; }

        /// <summary>
        /// <para>The parameters that are configured if the event source is Log Service.</para>
        /// </summary>
        [NameInMap("SourceSLSParameters")]
        [Validation(Required=false)]
        public string SourceSLSParametersShrink { get; set; }

        /// <summary>
        /// <para>The parameters that are configured if you specify scheduled events as the event source.</para>
        /// </summary>
        [NameInMap("SourceScheduledEventParameters")]
        [Validation(Required=false)]
        public string SourceScheduledEventParametersShrink { get; set; }

    }

}
