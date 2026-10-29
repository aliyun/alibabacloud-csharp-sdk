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
        /// 
        /// <b>Example:</b>
        /// <para>Event source of the RabbitMQ type</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the event bus associated with the event source.</para>
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
        /// <para>The external data source configuration.</para>
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
        /// <para>Specifies whether to connect to an external data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("LinkedExternalSource")]
        [Validation(Required=false)]
        public bool? LinkedExternalSource { get; set; }

        /// <summary>
        /// <para>The request parameter SourceHttpEventParameters.</para>
        /// </summary>
        [NameInMap("SourceHttpEventParameters")]
        [Validation(Required=false)]
        public string SourceHttpEventParametersShrink { get; set; }

        /// <summary>
        /// <para>The request parameter SourceKafkaParameters.</para>
        /// </summary>
        [NameInMap("SourceKafkaParameters")]
        [Validation(Required=false)]
        public string SourceKafkaParametersShrink { get; set; }

        /// <summary>
        /// <para>The parameters for a Simple Message Queue (formerly MNS) event source. If you select Simple Message Queue (formerly MNS) as the event source, the RegionId, IsBase64Decode, and QueueName parameters are required.</para>
        /// </summary>
        [NameInMap("SourceMNSParameters")]
        [Validation(Required=false)]
        public string SourceMNSParametersShrink { get; set; }

        /// <summary>
        /// <para>The parameters for an OSS event source.</para>
        /// </summary>
        [NameInMap("SourceOSSEventParameters")]
        [Validation(Required=false)]
        public string SourceOSSEventParametersShrink { get; set; }

        /// <summary>
        /// <para>The request parameter SourceRabbitMQParameters.</para>
        /// </summary>
        [NameInMap("SourceRabbitMQParameters")]
        [Validation(Required=false)]
        public string SourceRabbitMQParametersShrink { get; set; }

        /// <summary>
        /// <para>The request parameter SourceRocketMQParameters.</para>
        /// </summary>
        [NameInMap("SourceRocketMQParameters")]
        [Validation(Required=false)]
        public string SourceRocketMQParametersShrink { get; set; }

        /// <summary>
        /// <para>The parameters for a Simple Log Service event source.</para>
        /// </summary>
        [NameInMap("SourceSLSParameters")]
        [Validation(Required=false)]
        public string SourceSLSParametersShrink { get; set; }

        /// <summary>
        /// <para>The request parameter SourceScheduledEventParameters.</para>
        /// </summary>
        [NameInMap("SourceScheduledEventParameters")]
        [Validation(Required=false)]
        public string SourceScheduledEventParametersShrink { get; set; }

    }

}
