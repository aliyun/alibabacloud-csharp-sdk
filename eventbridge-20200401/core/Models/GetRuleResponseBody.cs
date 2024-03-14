// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class GetRuleResponseBody : TeaModel {
        /// <summary>
        /// The response code. The value Success indicates that the request is successful. Other values indicate that the request failed. For a list of error codes, see Error codes.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRuleResponseBodyData Data { get; set; }
        public class GetRuleResponseBodyData : TeaModel {
            /// <summary>
            /// The timestamp that indicates when the event rule was created.
            /// </summary>
            [NameInMap("CreatedTimestamp")]
            [Validation(Required=false)]
            public long? CreatedTimestamp { get; set; }

            /// <summary>
            /// The description of the event rule.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The name of the event bus.
            /// </summary>
            [NameInMap("EventBusName")]
            [Validation(Required=false)]
            public string EventBusName { get; set; }

            /// <summary>
            /// The event pattern, in JSON format. Valid values: stringEqual and stringExpression. You can specify up to five expressions in the map data structure in each field.
            /// 
            /// You can specify up to five expressions in the map data structure in each field.
            /// </summary>
            [NameInMap("FilterPattern")]
            [Validation(Required=false)]
            public string FilterPattern { get; set; }

            /// <summary>
            /// The Alibaba Cloud Resource Name (ARN) of the event rule.
            /// </summary>
            [NameInMap("RuleARN")]
            [Validation(Required=false)]
            public string RuleARN { get; set; }

            /// <summary>
            /// The name of the event rule.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The status of the event rule. Valid values: ENABLE (default): The event rule is enabled. DISABLE: The event rule is disabled.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The event targets.
            /// </summary>
            [NameInMap("Targets")]
            [Validation(Required=false)]
            public List<GetRuleResponseBodyDataTargets> Targets { get; set; }
            public class GetRuleResponseBodyDataTargets : TeaModel {
                /// <summary>
                /// The dead-letter queue.
                /// </summary>
                [NameInMap("DeadLetterQueue")]
                [Validation(Required=false)]
                public GetRuleResponseBodyDataTargetsDeadLetterQueue DeadLetterQueue { get; set; }
                public class GetRuleResponseBodyDataTargetsDeadLetterQueue : TeaModel {
                    /// <summary>
                    /// The Alibaba Cloud Resource Name (ARN) of the dead-letter queue.
                    /// </summary>
                    [NameInMap("Arn")]
                    [Validation(Required=false)]
                    public string Arn { get; set; }

                }

                /// <summary>
                /// The information about the event target.
                /// </summary>
                [NameInMap("DetailMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> DetailMap { get; set; }

                /// <summary>
                /// The endpoint of the event target.
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// The fault tolerance policy. Valid values: ALL: Fault tolerance is allowed. If an error occurs in an event, event processing is not blocked. If the event fails to be sent after the maximum number of retries specified by the retry policy is reached, the event is delivered to the dead-letter queue or discarded based on your configurations. NONE: Fault tolerance is not allowed. If an error occurs in an event and the event fails to be sent after the maximum number of retries specified by the retry policy is reached, event processing is blocked.
                /// </summary>
                [NameInMap("ErrorsTolerance")]
                [Validation(Required=false)]
                public string ErrorsTolerance { get; set; }

                /// <summary>
                /// The ID of the event target.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The parameters that are configured for the event target.
                /// </summary>
                [NameInMap("ParamList")]
                [Validation(Required=false)]
                public List<GetRuleResponseBodyDataTargetsParamList> ParamList { get; set; }
                public class GetRuleResponseBodyDataTargetsParamList : TeaModel {
                    /// <summary>
                    /// The method that is used to deliver events to the event target. For more information, see [Limits](~~163289~~).
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// The resource key of the event target. For more information, see [Limits](~~163289~~).
                    /// </summary>
                    [NameInMap("ResourceKey")]
                    [Validation(Required=false)]
                    public string ResourceKey { get; set; }

                    /// <summary>
                    /// The template based on which events are delivered to the event target.
                    /// </summary>
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public string Template { get; set; }

                    /// <summary>
                    /// The event target.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The retry policy that is used to push failed events. Valid values: BACKOFF_RETRY: backoff retry. A failed event can be retried up to three times. The interval between two consecutive retries is a random value between 10 seconds and 20 seconds. EXPONENTIAL_DECAY_RETRY: exponential decay retry. A failed event can be retried up to 176 times. The interval between two consecutive retries exponentially increases to a maximum of 512 seconds. The total retry time is 1 day. The specific retry intervals are 1, 2, 4, 8, 16, 32, 64, 128, 256, and 512 seconds. The interval of 512 seconds is used for 167 retries.
                /// </summary>
                [NameInMap("PushRetryStrategy")]
                [Validation(Required=false)]
                public string PushRetryStrategy { get; set; }

                /// <summary>
                /// The transformer that is used to push events.
                /// </summary>
                [NameInMap("PushSelector")]
                [Validation(Required=false)]
                public string PushSelector { get; set; }

                /// <summary>
                /// The type of the event target. For more information, see [Event target parameters](~~185887~~).
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The returned error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the operation is successful. If the operation is successful, the value true is returned.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
