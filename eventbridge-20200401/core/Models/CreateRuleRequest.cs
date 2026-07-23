// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateRuleRequest : TeaModel {
        /// <summary>
        /// <para>The description of the event rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMQ filter rule</para>
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
        /// <para>A list of event targets.</para>
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
                /// <para>The maximum number of concurrent executions for the event target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Concurrency")]
                [Validation(Required=false)]
                public long? Concurrency { get; set; }

            }

            /// <summary>
            /// <para>The dead-letter queue. If an event fails to be processed or exceeds the retry limit, it is sent to the dead-letter queue. Supported services for the dead-letter queue include Message Queue for Apache RocketMQ, Message Service (MNS), Message Queue for Apache Kafka, and EventBridge event buses.</para>
            /// </summary>
            [NameInMap("DeadLetterQueue")]
            [Validation(Required=false)]
            public CreateRuleRequestEventTargetsDeadLetterQueue DeadLetterQueue { get; set; }
            public class CreateRuleRequestEventTargetsDeadLetterQueue : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of the dead-letter queue. Events that fail to be processed or exceed the retry limit are sent to this ARN. Supported services for this parameter include Message Service (MNS) and Message Queue for Apache RocketMQ.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:mns:cn-hangzhou:123456789098****:/queues/deadletterqueue</para>
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// <para>The network type.</para>
                /// </summary>
                [NameInMap("Network")]
                [Validation(Required=false)]
                public string Network { get; set; }

                /// <summary>
                /// <para>The security group ID.</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public string VSwitchIds { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The delivery endpoint for events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:mns:cn-hangzhou:123456789098****:queues/myqueue</para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The fault tolerance policy. Valid values:<br><c>ALL</c>: Enables fault tolerance. Execution continues even if an error occurs. After all retry attempts fail, the event is sent to the dead-letter queue (if configured) or discarded.<br><c>NONE</c>: Disables fault tolerance. Execution is blocked if an error occurs and all retry attempts fail.<br><br></para>
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
            /// <para>The parameters for the event target.</para>
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
                /// <para>The name of the target parameter. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>body</para>
                /// </summary>
                [NameInMap("ResourceKey")]
                [Validation(Required=false)]
                public string ResourceKey { get; set; }

                /// <summary>
                /// <para>The template for the event target parameter.</para>
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
            /// <para>The push retry strategy. Valid values:<br><c>BACKOFF_RETRY</c>: A backoff retry strategy where the system makes three retry attempts at random intervals of 10 to 20 seconds.<br><c>EXPONENTIAL_DECAY_RETRY</c>: An exponential decay retry strategy where the system makes 176 retry attempts over 24 hours. The interval starts at 1 second and doubles with each of the first 10 attempts (up to 512 seconds). Subsequent retries occur every 512 seconds.<br><br></para>
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
        /// <para>The event pattern, in JSON format. Supported pattern types are <c>stringEqual</c> and <c>stringExpression</c>. Each field can contain a maximum of five expressions in a map structure.</para>
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
        /// <para>The status of the event rule. Valid values: <c>ENABLE</c>: The rule is enabled. This is the default value. <c>DISABLE</c>: The rule is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENABLE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
