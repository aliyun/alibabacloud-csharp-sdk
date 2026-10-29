// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class UpdateEventSourceShrinkRequest : TeaModel {
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
        /// <para>The name of the associated event bus.</para>
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
        /// <para>myrabbitmq.source</para>
        /// </summary>
        [NameInMap("EventSourceName")]
        [Validation(Required=false)]
        public string EventSourceName { get; set; }

        /// <summary>
        /// <para>The external data source configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;ConsumePosition\&quot;:\&quot;end\&quot;,\&quot;LogStore\&quot;:\&quot;oss_log\&quot;,\&quot;Project\&quot;:\&quot;slsaudit-center-5795350335281001-cn-beijing\&quot;,\&quot;RoleName\&quot;:\&quot;sls-beijing-tf\&quot;}</para>
        /// </summary>
        [NameInMap("ExternalSourceConfig")]
        [Validation(Required=false)]
        public string ExternalSourceConfigShrink { get; set; }

        /// <summary>
        /// <para>The type of the external data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SLS</para>
        /// </summary>
        [NameInMap("ExternalSourceType")]
        [Validation(Required=false)]
        public string ExternalSourceType { get; set; }

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
        /// <para>The SourceHttpEventParameters request parameter.</para>
        /// </summary>
        [NameInMap("SourceHttpEventParameters")]
        [Validation(Required=false)]
        public string SourceHttpEventParametersShrink { get; set; }

        /// <summary>
        /// <para>The SourceKafkaParameters request parameter.</para>
        /// </summary>
        [NameInMap("SourceKafkaParameters")]
        [Validation(Required=false)]
        public string SourceKafkaParametersShrink { get; set; }

        /// <summary>
        /// <para>The parameters for a Simple Message Queue (formerly MNS) event source.</para>
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
        /// <para>The SourceRabbitMQParameters request parameter.</para>
        /// </summary>
        [NameInMap("SourceRabbitMQParameters")]
        [Validation(Required=false)]
        public string SourceRabbitMQParametersShrink { get; set; }

        /// <summary>
        /// <para>The SourceRocketMQParameters request parameter.</para>
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
        /// <para>The SourceScheduledEventParameters request parameter.</para>
        /// </summary>
        [NameInMap("SourceScheduledEventParameters")]
        [Validation(Required=false)]
        public string SourceScheduledEventParametersShrink { get; set; }

    }

}
