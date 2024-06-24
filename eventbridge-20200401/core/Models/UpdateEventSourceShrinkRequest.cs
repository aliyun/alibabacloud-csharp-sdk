// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class UpdateEventSourceShrinkRequest : TeaModel {
        /// <summary>
        /// The description of the event source.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The event bus with which the event source is associated.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EventBusName")]
        [Validation(Required=false)]
        public string EventBusName { get; set; }

        /// <summary>
        /// The name of the event source.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EventSourceName")]
        [Validation(Required=false)]
        public string EventSourceName { get; set; }

        [NameInMap("ExternalSourceConfig")]
        [Validation(Required=false)]
        public string ExternalSourceConfigShrink { get; set; }

        [NameInMap("ExternalSourceType")]
        [Validation(Required=false)]
        public string ExternalSourceType { get; set; }

        [NameInMap("LinkedExternalSource")]
        [Validation(Required=false)]
        public bool? LinkedExternalSource { get; set; }

        /// <summary>
        /// The parameters that are configured if the event source is HTTP events.
        /// </summary>
        [NameInMap("SourceHttpEventParameters")]
        [Validation(Required=false)]
        public string SourceHttpEventParametersShrink { get; set; }

        /// <summary>
        /// The parameters that are configured if the event source is Message Queue for Apache Kafka.
        /// </summary>
        [NameInMap("SourceKafkaParameters")]
        [Validation(Required=false)]
        public string SourceKafkaParametersShrink { get; set; }

        /// <summary>
        /// The parameters that are configured if the event source is Message Service (MNS).
        /// </summary>
        [NameInMap("SourceMNSParameters")]
        [Validation(Required=false)]
        public string SourceMNSParametersShrink { get; set; }

        /// <summary>
        /// The parameters that are configured if the event source is Message Queue for RabbitMQ.
        /// </summary>
        [NameInMap("SourceRabbitMQParameters")]
        [Validation(Required=false)]
        public string SourceRabbitMQParametersShrink { get; set; }

        /// <summary>
        /// The parameters that are configured if the event source is Message Queue for Apache RocketMQ.
        /// </summary>
        [NameInMap("SourceRocketMQParameters")]
        [Validation(Required=false)]
        public string SourceRocketMQParametersShrink { get; set; }

        /// <summary>
        /// SourceSLSParameters
        /// </summary>
        [NameInMap("SourceSLSParameters")]
        [Validation(Required=false)]
        public string SourceSLSParametersShrink { get; set; }

        /// <summary>
        /// The parameters that are configured if you specify scheduled events as the event source.
        /// </summary>
        [NameInMap("SourceScheduledEventParameters")]
        [Validation(Required=false)]
        public string SourceScheduledEventParametersShrink { get; set; }

    }

}
