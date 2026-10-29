// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class GetRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Success</b>: The request is successful.</description></item>
        /// <item><description><b>Other values</b>: The error code. For more information, see Error codes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRuleResponseBodyData Data { get; set; }
        public class GetRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The creation timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1607071602000</para>
            /// </summary>
            [NameInMap("CreatedTimestamp")]
            [Validation(Required=false)]
            public long? CreatedTimestamp { get; set; }

            /// <summary>
            /// <para>The description of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the event bus.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Housekeeping-Bus</para>
            /// </summary>
            [NameInMap("EventBusName")]
            [Validation(Required=false)]
            public string EventBusName { get; set; }

            /// <summary>
            /// <para>The event pattern in JSON format. The following rules apply:</para>
            /// <list type="bullet">
            /// <item><description><b>stringEqual mode</b>: A maximum of five expressions are allowed for each field (map structure).</description></item>
            /// <item><description><b>stringExpression mode</b>: A maximum of five expressions are allowed for each field (map structure).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;source\&quot;:[\&quot;acs.oss\&quot;],\&quot;type\&quot;:[\&quot;oss:BucketQueried:GetBucketStat\&quot;]}</para>
            /// </summary>
            [NameInMap("FilterPattern")]
            [Validation(Required=false)]
            public string FilterPattern { get; set; }

            /// <summary>
            /// <para>The ARN of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:eventbridge:cn-hangzhou:123456789098****:eventbus/default/rule/myRule3</para>
            /// </summary>
            [NameInMap("RuleARN")]
            [Validation(Required=false)]
            public string RuleARN { get; set; }

            /// <summary>
            /// <para>The name of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ramrolechange-fc</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The status of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ENABLE</b>: The rule is enabled. This is the default status.</description></item>
            /// <item><description><b>DISABLE</b>: The rule is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ENABLE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of event targets.</para>
            /// </summary>
            [NameInMap("Targets")]
            [Validation(Required=false)]
            public List<GetRuleResponseBodyDataTargets> Targets { get; set; }
            public class GetRuleResponseBodyDataTargets : TeaModel {
                /// <summary>
                /// <para>The concurrency configuration.</para>
                /// </summary>
                [NameInMap("ConcurrentConfig")]
                [Validation(Required=false)]
                public GetRuleResponseBodyDataTargetsConcurrentConfig ConcurrentConfig { get; set; }
                public class GetRuleResponseBodyDataTargetsConcurrentConfig : TeaModel {
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
                /// <para>The dead-letter queue.</para>
                /// </summary>
                [NameInMap("DeadLetterQueue")]
                [Validation(Required=false)]
                public GetRuleResponseBodyDataTargetsDeadLetterQueue DeadLetterQueue { get; set; }
                public class GetRuleResponseBodyDataTargetsDeadLetterQueue : TeaModel {
                    /// <summary>
                    /// <para>The Alibaba Cloud Resource Name (ARN) of the queried dead-letter queue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acs:eventbridge:cn-hangzhou:164901546557****:eventbus/my-event-bus/eventsource/myRocketMQ.source</para>
                    /// </summary>
                    [NameInMap("Arn")]
                    [Validation(Required=false)]
                    public string Arn { get; set; }

                    /// <summary>
                    /// <para>The network type of the dead-letter queue.</para>
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
                    /// <para>sg-2v****</para>
                    /// </summary>
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// <para>The vSwitch IDs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-m5e****</para>
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
                /// <para>The detailed information.</para>
                /// </summary>
                [NameInMap("DetailMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> DetailMap { get; set; }

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
                /// <para>The fault tolerance strategy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ALL</b>: Allows fault tolerance. When an exception occurs, the execution is not blocked. If the retry strategy is exhausted, the message is delivered to the dead-letter queue or discarded based on the configuration.</description></item>
                /// <item><description><b>NONE</b>: Disables fault tolerance. When an exception occurs and the retry strategy is exhausted, the execution is blocked.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ALL</para>
                /// </summary>
                [NameInMap("ErrorsTolerance")]
                [Validation(Required=false)]
                public string ErrorsTolerance { get; set; }

                /// <summary>
                /// <para>The ID of the custom event target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Mlm123456JHd2RsRoKw</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The list of parameters for the event target.</para>
                /// </summary>
                [NameInMap("ParamList")]
                [Validation(Required=false)]
                public List<GetRuleResponseBodyDataTargetsParamList> ParamList { get; set; }
                public class GetRuleResponseBodyDataTargetsParamList : TeaModel {
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
                    /// <para>{\&quot;key\&quot;=\&quot;value\&quot;}</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The push retry policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>BACKOFF_RETRY</b>: The backoff retry policy. The system retries three times. The interval between two consecutive retries is a random value between 10 seconds and 20 seconds.</description></item>
                /// <item><description><b>EXPONENTIAL_DECAY_RETRY</b>: The exponential decay retry. The system retries 176 times. The interval between two consecutive retries exponentially increments up to 512 seconds. The total retry time is one day. The specific intervals are 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, and 512 seconds (167 intervals of 512 seconds).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BACKOFF_RETRY</para>
                /// </summary>
                [NameInMap("PushRetryStrategy")]
                [Validation(Required=false)]
                public string PushRetryStrategy { get; set; }

                /// <summary>
                /// <para>The push selector.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PARAM_TRANSFORMER</para>
                /// </summary>
                [NameInMap("PushSelector")]
                [Validation(Required=false)]
                public string PushSelector { get; set; }

                /// <summary>
                /// <para>The type of the event target. For more information, see <a href="https://help.aliyun.com/document_detail/185887.html">Event target parameters</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs.mns.queue</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The event rule not existed!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier generated by Alibaba Cloud for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2BC1857D-E633-5E79-B2C2-43EF5F7730D8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
