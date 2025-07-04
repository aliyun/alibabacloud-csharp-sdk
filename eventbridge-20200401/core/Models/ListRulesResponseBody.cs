// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description><b>Success</b>: The request was successful.</description></item>
        /// <item><description><b>Other codes</b>: The request failed. For more information about error codes, see Error codes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRulesResponseBodyData Data { get; set; }
        public class ListRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>If excess return values exist, this parameter is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The event rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<ListRulesResponseBodyDataRules> Rules { get; set; }
            public class ListRulesResponseBodyDataRules : TeaModel {
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
                /// <para>The rule description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The details of the event rule.</para>
                /// </summary>
                [NameInMap("DetailMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> DetailMap { get; set; }

                /// <summary>
                /// <para>The name of the event bus.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("EventBusName")]
                [Validation(Required=false)]
                public string EventBusName { get; set; }

                /// <summary>
                /// <para>The event pattern, in JSON format. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>stringEqual</b>: Up to five expressions in the map data structure can be specified in each field.</description></item>
                /// <item><description><b>stringExpression</b>: Up to five expressions in the map data structure can be specified in each field.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;source\&quot;:[\&quot;acs.oss\&quot;],\&quot;type\&quot;:[\&quot;oss:BucketQueried:GetBucketStat\&quot;]}</para>
                /// </summary>
                [NameInMap("FilterPattern")]
                [Validation(Required=false)]
                public string FilterPattern { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of the rule.</para>
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
                /// <para>tf-testacc-rule</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The status of the event rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ENABLE</b> (default)</description></item>
                /// <item><description><b>DISABLE</b></description></item>
                /// </list>
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
                public List<ListRulesResponseBodyDataRulesTargets> Targets { get; set; }
                public class ListRulesResponseBodyDataRulesTargets : TeaModel {
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
                    /// <para>The fault tolerance policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>ALL</b>: Fault tolerance is allowed. If an error occurs in an event, event processing is not blocked. If the event fails to be sent after the maximum number of retries specified by the retry policy is reached, the event is delivered to the dead-letter queue or discarded based on your configurations.</description></item>
                    /// <item><description><b>NONE</b>: Fault tolerance is prohibited. If an error occurs in an event and the event fails to be sent after the maximum number of retries specified by the retry policy is reached, event processing is blocked.</description></item>
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
                    /// <para>177</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

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
                    /// <para>The type of the event target. For more information, see <a href="https://www.alibabacloud.com/help/en/eventbridge/latest/event-target-parameters">Event target parameters.</a></para>
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
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The error message that is returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Specified parameter Limit is not valid.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C7043799-F4DA-5290-9249-97C359876D97</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
