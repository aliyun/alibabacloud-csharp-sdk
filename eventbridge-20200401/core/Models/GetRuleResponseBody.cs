// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class GetRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The value Success indicates that the request is successful. Other values indicate that the request failed. For a list of error codes, see Error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRuleResponseBodyData Data { get; set; }
        public class GetRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The timestamp that indicates when the event rule was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1607071602000</para>
            /// </summary>
            [NameInMap("CreatedTimestamp")]
            [Validation(Required=false)]
            public long? CreatedTimestamp { get; set; }

            /// <summary>
            /// <para>The description of the event rule.</para>
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
            /// <para>The event pattern, in JSON format. Valid values: stringEqual and stringExpression. You can specify up to five expressions in the map data structure in each field.</para>
            /// <para>You can specify up to five expressions in the map data structure in each field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;source\&quot;:[\&quot;acs.oss\&quot;],\&quot;type\&quot;:[\&quot;oss:BucketQueried:GetBucketStat\&quot;]}</para>
            /// </summary>
            [NameInMap("FilterPattern")]
            [Validation(Required=false)]
            public string FilterPattern { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the event rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:eventbridge:cn-hangzhou:123456789098****:eventbus/default/rule/myRule3</para>
            /// </summary>
            [NameInMap("RuleARN")]
            [Validation(Required=false)]
            public string RuleARN { get; set; }

            /// <summary>
            /// <para>The name of the event rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ramrolechange-fc</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The status of the event rule. Valid values: ENABLE (default): The event rule is enabled. DISABLE: The event rule is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ENABLE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The event targets.</para>
            /// </summary>
            [NameInMap("Targets")]
            [Validation(Required=false)]
            public List<GetRuleResponseBodyDataTargets> Targets { get; set; }
            public class GetRuleResponseBodyDataTargets : TeaModel {
                [NameInMap("ConcurrentConfig")]
                [Validation(Required=false)]
                public GetRuleResponseBodyDataTargetsConcurrentConfig ConcurrentConfig { get; set; }
                public class GetRuleResponseBodyDataTargetsConcurrentConfig : TeaModel {
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
                /// <para>The information about the event target.</para>
                /// </summary>
                [NameInMap("DetailMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> DetailMap { get; set; }

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
                /// <para>The fault tolerance policy. Valid values: ALL and NONE. ALL: Fault tolerance is allowed. If an error occurs in an event, event processing is not blocked. If the event fails to be sent after the maximum number of retries specified by the retry policy is reached, the event is delivered to the dead-letter queue or discarded based on your configurations. NONE: Fault tolerance is not allowed. If an error occurs in an event and the event fails to be sent after the maximum number of retries specified by the retry policy is reached, event processing is blocked.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALL</para>
                /// </summary>
                [NameInMap("ErrorsTolerance")]
                [Validation(Required=false)]
                public string ErrorsTolerance { get; set; }

                /// <summary>
                /// <para>The ID of the event target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The parameters that are configured for the event target.</para>
                /// </summary>
                [NameInMap("ParamList")]
                [Validation(Required=false)]
                public List<GetRuleResponseBodyDataTargetsParamList> ParamList { get; set; }
                public class GetRuleResponseBodyDataTargetsParamList : TeaModel {
                    /// <summary>
                    /// <para>The format that is used by the event target parameter. For more information, see <a href="https://help.aliyun.com/document_detail/163289.html">Limits</a>.</para>
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
                    /// <para>The template based on which events are delivered to the event target.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The value of ${key} is ${value}!</para>
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// <para>The event target.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{\&quot;key\&quot;=\&quot;value\&quot;}</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The retry policy that is used to push failed events. Valid values: BACKOFF_RETRY and EXPONENTIAL_DECAY_RETRY. BACKOFF_RETRY: backoff retry. A failed event can be retried up to three times. The interval between two consecutive retries is a random value between 10 seconds and 20 seconds. EXPONENTIAL_DECAY_RETRY: exponential decay retry. A failed event can be retried up to 176 times. The interval between two consecutive retries exponentially increases to a maximum of 512 seconds. The total retry time is 1 day. The specific retry intervals are 1, 2, 4, 8, 16, 32, 64, 128, 256, and 512 seconds. The interval of 512 seconds is used for 167 retries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BACKOFF_RETRY</para>
                /// </summary>
                [NameInMap("PushRetryStrategy")]
                [Validation(Required=false)]
                public string PushRetryStrategy { get; set; }

                /// <summary>
                /// <para>The transformer that is used to push events.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MATCHED_EVENT</para>
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
        /// <para>The returned error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The event rule not existed!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2BC1857D-E633-5E79-B2C2-43EF5F7730D8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation is successful. If the operation is successful, the value true is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
