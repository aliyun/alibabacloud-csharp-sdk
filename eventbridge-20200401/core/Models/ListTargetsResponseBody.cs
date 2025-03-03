// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListTargetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned response code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Success: The request is successful.</description></item>
        /// <item><description>Other codes: The request failed. For a list of error codes, see Error codes.</description></item>
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
        public ListTargetsResponseBodyData Data { get; set; }
        public class ListTargetsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>If excess return values exist, this parameter is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The event targets.</para>
            /// </summary>
            [NameInMap("Targets")]
            [Validation(Required=false)]
            public List<ListTargetsResponseBodyDataTargets> Targets { get; set; }
            public class ListTargetsResponseBodyDataTargets : TeaModel {
                [NameInMap("ConcurrentConfig")]
                [Validation(Required=false)]
                public ListTargetsResponseBodyDataTargetsConcurrentConfig ConcurrentConfig { get; set; }
                public class ListTargetsResponseBodyDataTargetsConcurrentConfig : TeaModel {
                    [NameInMap("Concurrency")]
                    [Validation(Required=false)]
                    public long? Concurrency { get; set; }

                }

                /// <summary>
                /// <para>The endpoint of the event target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:fc:cn-hangzhou:123456789098****:services/guide.LATEST/functions/HelloFC</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The fault tolerance policy. Valid values: ALL and NONE. </para>
                /// <list type="bullet">
                /// <item><description><b>ALL</b>: Fault tolerance is allowed. If an error occurs in an event, event processing is not blocked. If the event fails to be sent after the maximum number of retries specified by the retry policy is reached, the event is delivered to the dead-letter queue or discarded based on your configurations. </description></item>
                /// <item><description><b>NONE</b>: Fault tolerance is not allowed. If an error occurs in an event and the event fails to be sent after the maximum number of retries specified by the retry policy is reached, event processing is blocked.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ALL</para>
                /// </summary>
                [NameInMap("ErrorsTolerance")]
                [Validation(Required=false)]
                public string ErrorsTolerance { get; set; }

                /// <summary>
                /// <para>The name of the event bus.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sls-beijing-one1-tf</para>
                /// </summary>
                [NameInMap("EventBusName")]
                [Validation(Required=false)]
                public string EventBusName { get; set; }

                /// <summary>
                /// <para>The ID of the event target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1453</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The parameters that are configured for the event target.</para>
                /// </summary>
                [NameInMap("ParamList")]
                [Validation(Required=false)]
                public List<ListTargetsResponseBodyDataTargetsParamList> ParamList { get; set; }
                public class ListTargetsResponseBodyDataTargetsParamList : TeaModel {
                    /// <summary>
                    /// <para>The format that is used by the event target parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TEMPLATE</para>
                    /// </summary>
                    [NameInMap("Form")]
                    [Validation(Required=false)]
                    public string Form { get; set; }

                    /// <summary>
                    /// <para>The resource parameter of the event target.</para>
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
                /// <para>The name of the event rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule-uKAK2</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The type of the event target. For more information, see <a href="https://help.aliyun.com/document_detail/183698.html">Event target parameters</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs.fc.function</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The returned error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EventRuleNotExisted</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5DAF96FB-A4B6-548C-B999-0BFDCB2261B9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
