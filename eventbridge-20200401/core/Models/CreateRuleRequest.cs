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
            [NameInMap("ConcurrentConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestEventTargetsConcurrentConfig ConcurrentConfig { get; set; }
            public class CreateRuleRequestEventTargetsConcurrentConfig : TeaModel {
                [NameInMap("Concurrency")]
                [Validation(Required=false)]
                public long? Concurrency { get; set; }

            }

            /// <summary>
            /// <para>The dead-letter queue. Events that are not processed or whose maximum retries are exceeded are written to the dead-letter queue. The dead-letter queue feature is supported by the following queue types: Message Queue for Apache RocketMQ, Message Service (MNS), Message Queue for Apache Kafka, and EventBridge.</para>
            /// </summary>
            [NameInMap("DeadLetterQueue")]
            [Validation(Required=false)]
            public CreateRuleRequestEventTargetsDeadLetterQueue DeadLetterQueue { get; set; }
            public class CreateRuleRequestEventTargetsDeadLetterQueue : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of the dead-letter queue. Events that are not processed or whose maximum retries are exceeded are written to the dead-letter queue. The ARN feature is supported by the following queue types: MNS and Message Queue for Apache RocketMQ.</para>
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
            /// <para>The fault tolerance policy. Valid values: ALL: allows fault tolerance. If an error occurs, the event processing is not blocked. If the message fails to be sent after the maximum number of retries specified by the retry policy is reached, the message is delivered to the dead-letter queue or discarded based on your configurations. NONE: does not allow fault tolerance. If an error occurs and the message fails to be sent after the maximum number of retries specified by the retry policy is reached, the event processing is blocked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("ErrorsTolerance")]
            [Validation(Required=false)]
            public string ErrorsTolerance { get; set; }

            /// <summary>
            /// <para>The ID of the custom event target.</para>
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
                /// <para>The format that is used by the event target parameter. For more information, see <a href="https://www.alibabacloud.com/help/en/eventbridge/latest/limits">Limits.</a></para>
                /// 
                /// <b>Example:</b>
                /// <para>TEMPLATE</para>
                /// </summary>
                [NameInMap("Form")]
                [Validation(Required=false)]
                public string Form { get; set; }

                /// <summary>
                /// <para>The resource parameter of the event target. For more information, see <a href="https://www.alibabacloud.com/help/en/eventbridge/latest/limits">Limits</a></para>
                /// 
                /// <b>Example:</b>
                /// <para>body</para>
                /// </summary>
                [NameInMap("ResourceKey")]
                [Validation(Required=false)]
                public string ResourceKey { get; set; }

                /// <summary>
                /// <para>The template that is used by the event target parameter.</para>
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
            /// <para>The retry policy that is used to push events. Valid values: BACKOFF_RETRY: backoff retry. If an event failed to be pushed, it can be retried up to three times. The interval between two consecutive retries is a random value between 10 and 20 seconds. EXPONENTIAL_DECAY_RETRY: exponential decay retry. If an event failed to be pushed, it can be retried up to 176 times. The interval between two consecutive retries exponentially increases to 512 seconds, and the total retry time is one day. The specific retry intervals are 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 512, ..., and 512 seconds. The interval of 512 seconds is used for 167 retries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BACKOFF_RETRY</para>
            /// </summary>
            [NameInMap("PushRetryStrategy")]
            [Validation(Required=false)]
            public string PushRetryStrategy { get; set; }

            /// <summary>
            /// <para>The type of the event target. For more information, see <a href="https://www.alibabacloud.com/help/en/eventbridge/latest/event-target-parameters">Event target parameters.</a></para>
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
