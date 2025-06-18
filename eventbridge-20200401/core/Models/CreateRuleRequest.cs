// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateRuleRequest : TeaModel {
        /// <summary>
        /// <para>The description of the event bus.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the event bus.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyEventBus</para>
        /// </summary>
        [NameInMap("EventBusName")]
        [Validation(Required=false)]
        public string EventBusName { get; set; }

        /// <summary>
        /// <para>The event targets.</para>
        /// </summary>
        [NameInMap("EventTargets")]
        [Validation(Required=false)]
        public List<CreateRuleRequestEventTargets> EventTargets { get; set; }
        public class CreateRuleRequestEventTargets : TeaModel {
            /// <summary>
            /// <para>The concurrency configuration.</para>
            /// </summary>
            [NameInMap("ConcurrentConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestEventTargetsConcurrentConfig ConcurrentConfig { get; set; }
            public class CreateRuleRequestEventTargetsConcurrentConfig : TeaModel {
                /// <summary>
                /// <para>The concurrency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Concurrency")]
                [Validation(Required=false)]
                public long? Concurrency { get; set; }

            }

            /// <summary>
            /// <para>The dead-letter queue. Events that are not processed or whose maximum number of retries is exceeded are written to the dead-letter queue. You can use queues in ApsaraMQ for RocketMQ, Simple Message Queue (SMQ, formerly MNS), and ApsaraMQ for Kafka as dead-letter queues. You can also use event buses in EventBridge as dead-letter queues.</para>
            /// </summary>
            [NameInMap("DeadLetterQueue")]
            [Validation(Required=false)]
            public CreateRuleRequestEventTargetsDeadLetterQueue DeadLetterQueue { get; set; }
            public class CreateRuleRequestEventTargetsDeadLetterQueue : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of the dead-letter queue. Events that are not processed or whose maximum number of retries is exceeded are written to the dead-letter queue. Queues in SMQ and ApsaraMQ for RocketMQ can be used as dead-letter queues.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:mns:cn-hangzhou:123456789098****:/queues/rule-deadletterqueue</para>
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                [NameInMap("Network")]
                [Validation(Required=false)]
                public string Network { get; set; }

                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public string VSwitchIds { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The endpoint of the event target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:mns:cn-hangzhou:123456789098****:queues/myqueue</para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The fault tolerance policy. Valid values: ALL and NONE. The value ALL specifies that fault tolerance is allowed. If an error occurs in an event, event processing is not blocked. If the event fails to be sent after the maximum number of retries specified by the retry policy is reached, the event is delivered to the dead-letter queue or discarded based on your configurations. The value NONE specifies that fault tolerance is not allowed. If an error occurs in an event and the event fails to be sent after the maximum number of retries specified by the retry policy is reached, event processing is blocked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("ErrorsTolerance")]
            [Validation(Required=false)]
            public string ErrorsTolerance { get; set; }

            /// <summary>
            /// <para>The ID of the event target.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12021</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The parameters that are configured for the event target.</para>
            /// </summary>
            [NameInMap("ParamList")]
            [Validation(Required=false)]
            public List<CreateRuleRequestEventTargetsParamList> ParamList { get; set; }
            public class CreateRuleRequestEventTargetsParamList : TeaModel {
                /// <summary>
                /// <para>The format of input parameters for the event target. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TEMPLATE</para>
                /// </summary>
                [NameInMap("Form")]
                [Validation(Required=false)]
                public string Form { get; set; }

                /// <summary>
                /// <para>The resource key of the event target. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>body</para>
                /// </summary>
                [NameInMap("ResourceKey")]
                [Validation(Required=false)]
                public string ResourceKey { get; set; }

                /// <summary>
                /// <para>The structure of the template for the event target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The value of ${key} is ${value}!</para>
                /// </summary>
                [NameInMap("Template")]
                [Validation(Required=false)]
                public string Template { get; set; }

                /// <summary>
                /// <para>The value of the event target parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;key\&quot;=\&quot;value\&quot;}</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The retry policy that you want to use to push failed events. Valid values: BACKOFF_RETRY and EXPONENTIAL_DECAY_RETRY. BACKOFF_RETRY: A failed event can be retried up to three times. The interval between two consecutive retries is a random value from 10 seconds to 20 seconds. EXPONENTIAL_DECAY_RETRY: A failed event can be retried up to 176 times. The interval between two consecutive retries exponentially increases to a maximum of 512 seconds. The total retry time is 1 day. The specific retry intervals are 1, 2, 4, 8, 16, 32, 64, 128, 256, and 512 seconds. The interval of 512 seconds is used for 167 retries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BACKOFF_RETRY</para>
            /// </summary>
            [NameInMap("PushRetryStrategy")]
            [Validation(Required=false)]
            public string PushRetryStrategy { get; set; }

            /// <summary>
            /// <para>The type of the event target. For more information, see <a href="https://help.aliyun.com/document_detail/185887.html">Event target parameters</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs.mns.queue</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The event pattern, in JSON format. Valid values: stringEqual and stringExpression. You can specify up to five expressions in the map data structure in each field.</para>
        /// <para>You can specify up to five expressions in the map data structure in each field.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;source\&quot;: [{\&quot;prefix\&quot;: \&quot;acs.\&quot;}],\&quot;type\&quot;: [{\&quot;prefix\&quot;:\&quot;oss:ObjectReplication\&quot;}],\&quot;subject\&quot;:[{\&quot;prefix\&quot;:\&quot;acs:oss:cn-hangzhou:123456789098****:my-movie-bucket/\&quot;, \&quot;suffix\&quot;:\&quot;.txt\&quot;}]}</para>
        /// </summary>
        [NameInMap("FilterPattern")]
        [Validation(Required=false)]
        public string FilterPattern { get; set; }

        /// <summary>
        /// <para>The name of the event rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MNSRule</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The status of the event rule. Valid values: ENABLE: enables the event rule. It is the default status of the event rule. DISABLE: disables the event rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENABLE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
