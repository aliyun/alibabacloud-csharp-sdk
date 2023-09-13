// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListRulesResponseBody : TeaModel {
        /// <summary>
        /// The error code. The value Success indicates that the request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRulesResponseBodyData Data { get; set; }
        public class ListRulesResponseBodyData : TeaModel {
            /// <summary>
            /// If excess return values exist, this parameter is returned.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// The rules.
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<ListRulesResponseBodyDataRules> Rules { get; set; }
            public class ListRulesResponseBodyDataRules : TeaModel {
                /// <summary>
                /// The creation timestamp.
                /// </summary>
                [NameInMap("CreatedTimestamp")]
                [Validation(Required=false)]
                public long? CreatedTimestamp { get; set; }

                /// <summary>
                /// The rule description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The details of the event rule.
                /// </summary>
                [NameInMap("DetailMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> DetailMap { get; set; }

                /// <summary>
                /// The name of the event bus.
                /// </summary>
                [NameInMap("EventBusName")]
                [Validation(Required=false)]
                public string EventBusName { get; set; }

                /// <summary>
                /// The event pattern, in JSON format. Valid values: stringEqual pattern stringExpression pattern Each field can have a maximum of five expressions in the map data structure.
                /// 
                /// Each field can have a maximum of five expressions in the map data structure.
                /// </summary>
                [NameInMap("FilterPattern")]
                [Validation(Required=false)]
                public string FilterPattern { get; set; }

                /// <summary>
                /// The Alibaba Cloud Resource Name (ARN) of the rule.
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
                /// The status of the event rule. Valid values: ENABLE: The event rule is enabled. It is the default state of the event rule. DISABLE: The event rule is disabled.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The event targets.
                /// </summary>
                [NameInMap("Targets")]
                [Validation(Required=false)]
                public List<ListRulesResponseBodyDataRulesTargets> Targets { get; set; }
                public class ListRulesResponseBodyDataRulesTargets : TeaModel {
                    /// <summary>
                    /// The endpoint of the event target.
                    /// </summary>
                    [NameInMap("Endpoint")]
                    [Validation(Required=false)]
                    public string Endpoint { get; set; }

                    [NameInMap("ErrorsTolerance")]
                    [Validation(Required=false)]
                    public string ErrorsTolerance { get; set; }

                    /// <summary>
                    /// The ID of the custom event target.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// The transformer that is used to push events.
                    /// </summary>
                    [NameInMap("PushSelector")]
                    [Validation(Required=false)]
                    public string PushSelector { get; set; }

                    /// <summary>
                    /// The type of the event target. For more information, see [Event target parameters.](https://www.alibabacloud.com/help/en/eventbridge/latest/event-target-parameters)
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// The total number of entries.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// The error message that is returned if the request failed.
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
        /// Indicates whether the request was successful. Valid values: true and false.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
