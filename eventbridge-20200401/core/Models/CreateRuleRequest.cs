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
        /// 
        /// <b>Example:</b>
        /// <para>Filter rule for Simple Message Queue (formerly MNS) (SMQ)</para>
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
        /// <para>The list of event targets.</para>
        /// </summary>
        [NameInMap("EventTargets")]
        [Validation(Required=false)]
        public List<CreateRuleRequestEventTargets> EventTargets { get; set; }
        public class CreateRuleRequestEventTargets : TeaModel {
            /// <summary>
            /// <para>The concurrency control configuration.</para>
            /// </summary>
            [NameInMap("ConcurrentConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestEventTargetsConcurrentConfig ConcurrentConfig { get; set; }
            public class CreateRuleRequestEventTargetsConcurrentConfig : TeaModel {
                /// <summary>
                /// <para>The number of concurrent executions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Concurrency")]
                [Validation(Required=false)]
                public long? Concurrency { get; set; }

            }

            /// <summary>
            /// <para>The dead-letter queue. Unprocessed events or events that exceed the retry limit are written to the dead-letter queue. Supported queue types include ApsaraMQ for RocketMQ, Simple Message Queue (formerly MNS), ApsaraMQ for Kafka, and EventBridge event buses.</para>
            /// </summary>
            [NameInMap("DeadLetterQueue")]
            [Validation(Required=false)]
            public CreateRuleRequestEventTargetsDeadLetterQueue DeadLetterQueue { get; set; }
            public class CreateRuleRequestEventTargetsDeadLetterQueue : TeaModel {
                /// <summary>
                /// <para>The ARN of the dead-letter queue. Unprocessed events or events that exceed the retry limit are written to the dead-letter queue. Simple Message Queue (formerly MNS) and ApsaraMQ for RocketMQ are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:mns:cn-hangzhou:123456789098****:/queues/deadletterqueue</para>
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// <para>The network type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PrivateNetwork</para>
                /// </summary>
                [NameInMap("Network")]
                [Validation(Required=false)]
                public string Network { get; set; }

                /// <summary>
                /// <para>The security group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-2d****</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-m12345****</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public string VSwitchIds { get; set; }

                /// <summary>
                /// <para>The ID of the VPC where the dead-letter queue resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2z****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The endpoint URL for delivery.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:mns:cn-hangzhou:123456789098****:queues/myqueue</para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The fault tolerance strategy. Valid values:
            /// ALL: Fault tolerance is allowed. Exceptions are tolerated and do not block execution. If the retry strategy is exhausted, messages are delivered to the dead-letter queue or discarded based on the configuration.
            /// NONE: Fault tolerance is disabled. Exceptions are not tolerated. If an exception occurs and the retry strategy is exhausted, execution is blocked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("ErrorsTolerance")]
            [Validation(Required=false)]
            public string ErrorsTolerance { get; set; }

            /// <summary>
            /// <para>The custom ID of the event target.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Mlm123456JHd2RsRoKw</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The parameters of the event target.</para>
            /// </summary>
            [NameInMap("ParamList")]
            [Validation(Required=false)]
            public List<CreateRuleRequestEventTargetsParamList> ParamList { get; set; }
            public class CreateRuleRequestEventTargetsParamList : TeaModel {
                /// <summary>
                /// <para>The format of the event target parameter. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TEMPLATE</para>
                /// </summary>
                [NameInMap("Form")]
                [Validation(Required=false)]
                public string Form { get; set; }

                /// <summary>
                /// <para>The resource parameter of the event target. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>body</para>
                /// </summary>
                [NameInMap("ResourceKey")]
                [Validation(Required=false)]
                public string ResourceKey { get; set; }

                /// <summary>
                /// <para>The style of the event target parameter template.</para>
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
                /// <para>{&quot;key&quot;=&quot;value&quot;}</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The push retry policy. Valid values:
            /// BACKOFF_RETRY: The backoff retry policy. The system retries 3 times. The interval between two consecutive retries is a random value between 10 and 20 seconds.
            /// EXPONENTIAL_DECAY_RETRY: The exponential decay retry. The system retries 176 times. The intervals between consecutive retries exponentially increment up to 512 seconds. The total retry time is 1 day. The specific intervals are 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 512...512 seconds (167 intervals of 512 seconds in total).</para>
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
        /// <para>The event pattern in JSON format. Valid values:
        /// stringEqual mode.
        /// stringExpression mode.
        /// Up to 5 expressions are supported for each field (map structure).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;source&quot;: [
        ///     {
        ///       &quot;prefix&quot;: &quot;acs.&quot;
        ///     }
        ///   ],
        ///   &quot;type&quot;: [
        ///     {
        ///       &quot;prefix&quot;: &quot;oss:ObjectReplication&quot;
        ///     }
        ///   ],
        ///   &quot;subject&quot;: [
        ///     {
        ///       &quot;prefix&quot;: &quot;acs:oss:cn-hangzhou:123456789098****:my-movie-bucket/&quot;,
        ///       &quot;suffix&quot;: &quot;.txt&quot;
        ///     }
        ///   ]
        /// }</para>
        /// </summary>
        [NameInMap("FilterPattern")]
        [Validation(Required=false)]
        public string FilterPattern { get; set; }

        /// <summary>
        /// <para>The name of the event rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMQRule</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The status of the rule. Valid values:
        /// ENABLE: The rule is enabled. This is the default status.
        /// DISABLE: The rule is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENABLE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
