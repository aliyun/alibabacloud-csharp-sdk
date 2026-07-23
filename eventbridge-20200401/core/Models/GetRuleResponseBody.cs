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
        /// <item><description><para><b>Success</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>Other values</b>: The request returned an error code. For more information, see Error codes.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRuleResponseBodyData Data { get; set; }
        public class GetRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The creation timestamp of the rule.</para>
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
            /// <para>The event pattern in JSON format. The following modes are supported:</para>
            /// <list type="bullet">
            /// <item><description><para><b>stringEqual mode</b>: In the map structure, each field can contain up to five expressions.</para>
            /// </description></item>
            /// <item><description><para><b>stringExpression mode</b>: In the map structure, each field can contain up to five expressions.</para>
            /// </description></item>
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
            /// <item><description><para><b>ENABLE</b>: The rule is enabled. This is the default.</para>
            /// </description></item>
            /// <item><description><para><b>DISABLE</b>: The rule is disabled.</para>
            /// </description></item>
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
                /// <para>The concurrency settings.</para>
                /// </summary>
                [NameInMap("ConcurrentConfig")]
                [Validation(Required=false)]
                public GetRuleResponseBodyDataTargetsConcurrentConfig ConcurrentConfig { get; set; }
                public class GetRuleResponseBodyDataTargetsConcurrentConfig : TeaModel {
                    /// <summary>
                    /// <para>The maximum number of concurrent pushes.</para>
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
                    /// <para>The Alibaba Cloud Resource Name (ARN) of the dead-letter queue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acs:eventbridge:cn-hangzhou:164901546557****:eventbus/my-event-bus/eventsource/myRocketMQ.source</para>
                    /// </summary>
                    [NameInMap("Arn")]
                    [Validation(Required=false)]
                    public string Arn { get; set; }

                    /// <summary>
                    /// <para>The network type of the dead-letter queue.</para>
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
                    /// <para>The vSwitch IDs.</para>
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
                /// <para>The details of the event target.</para>
                /// </summary>
                [NameInMap("DetailMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> DetailMap { get; set; }

                /// <summary>
                /// <para>The delivery endpoint for the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:mns:cn-hangzhou:123456789098****:queues/myqueue</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The fault tolerance policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>ALL</b>: Enables fault tolerance. Errors do not block event delivery. If all retries fail, the system sends the event to the specified dead-letter queue or discards it.</para>
                /// </description></item>
                /// <item><description><para><b>NONE</b>: Disables fault tolerance. If an error persists after all retries, the system blocks event delivery.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ALL</para>
                /// </summary>
                [NameInMap("ErrorsTolerance")]
                [Validation(Required=false)]
                public string ErrorsTolerance { get; set; }

                /// <summary>
                /// <para>The custom ID of the event target.</para>
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
                    /// <para>The resource key of the event target. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>body</para>
                    /// </summary>
                    [NameInMap("ResourceKey")]
                    [Validation(Required=false)]
                    public string ResourceKey { get; set; }

                    /// <summary>
                    /// <para>The template of the event target parameter.</para>
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
                /// <para>The retry policy for pushing events. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>BACKOFF_RETRY</b>: A backoff retry policy. The event is retried 3 times at a random interval between 10 and 20 seconds.</para>
                /// </description></item>
                /// <item><description><para><b>EXPONENTIAL_DECAY_RETRY</b>: An exponential decay retry policy. The event is retried 176 times over one day. The retry interval starts at 1 second and exponentially increases to a maximum of 512 seconds. The specific retry intervals are 1, 2, 4, 8, 16, 32, 64, 128, 256, and then 512 for the remaining 167 retries.</para>
                /// </description></item>
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
        /// <para>The unique request ID generated by Alibaba Cloud.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2BC1857D-E633-5E79-B2C2-43EF5F7730D8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. A value of <c>true</c> indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
