// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeSwimmingLaneResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code or the error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The request was successful.</description></item>
        /// <item><description><b>3xx</b>: The request was redirected.</description></item>
        /// <item><description><b>4xx</b>: The request failed.</description></item>
        /// <item><description><b>5xx</b>: A server error occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Responses.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSwimmingLaneResponseBodyData Data { get; set; }
        public class DescribeSwimmingLaneResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Apply ingress rules.</para>
            /// </summary>
            [NameInMap("AppEntryRule")]
            [Validation(Required=false)]
            public DescribeSwimmingLaneResponseBodyDataAppEntryRule AppEntryRule { get; set; }
            public class DescribeSwimmingLaneResponseBodyDataAppEntryRule : TeaModel {
                /// <summary>
                /// <para>Logical connectors between conditions:</para>
                /// <list type="bullet">
                /// <item><description>AND: All conditions are met at the same time.</description></item>
                /// <item><description>OR: Any condition is met.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AND</para>
                /// </summary>
                [NameInMap("ConditionJoiner")]
                [Validation(Required=false)]
                public string ConditionJoiner { get; set; }

                /// <summary>
                /// <para>The matching condition.</para>
                /// </summary>
                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public List<DescribeSwimmingLaneResponseBodyDataAppEntryRuleConditions> Conditions { get; set; }
                public class DescribeSwimmingLaneResponseBodyDataAppEntryRuleConditions : TeaModel {
                    /// <summary>
                    /// <para>The matching rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>==</para>
                    /// </summary>
                    [NameInMap("Condition")]
                    [Validation(Required=false)]
                    public string Condition { get; set; }

                    /// <summary>
                    /// <para>The name of the parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>t</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Parameter type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Header</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The match value of the condition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>g1</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    /// <summary>
                    /// <para>The match value of the condition.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>Whether to enable proportional grayscale.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IndependentPercentageEnable")]
                [Validation(Required=false)]
                public bool? IndependentPercentageEnable { get; set; }

                /// <summary>
                /// <para>The request path.</para>
                /// </summary>
                [NameInMap("Paths")]
                [Validation(Required=false)]
                public List<string> Paths { get; set; }

                /// <summary>
                /// <para>The traffic ratio. Valid values: 0 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Percentage")]
                [Validation(Required=false)]
                public int? Percentage { get; set; }

                /// <summary>
                /// <para>Traffic matching.</para>
                /// </summary>
                [NameInMap("PercentageByPath")]
                [Validation(Required=false)]
                public Dictionary<string, int?> PercentageByPath { get; set; }

            }

            /// <summary>
            /// <para>The apps.</para>
            /// </summary>
            [NameInMap("Apps")]
            [Validation(Required=false)]
            public List<DescribeSwimmingLaneResponseBodyDataApps> Apps { get; set; }
            public class DescribeSwimmingLaneResponseBodyDataApps : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6b4c0f64-f679-4580-8105-91eac4******</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The ID of the MSE instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mse-cn-53y49******</para>
                /// </summary>
                [NameInMap("MseAppId")]
                [Validation(Required=false)]
                public string MseAppId { get; set; }

                /// <summary>
                /// <para>The name of the MSE instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sae-test</para>
                /// </summary>
                [NameInMap("MseAppName")]
                [Validation(Required=false)]
                public string MseAppName { get; set; }

                /// <summary>
                /// <para>The ID of the MSE namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6733e538-d52f-48e6-91a4-192f91******</para>
                /// </summary>
                [NameInMap("mseNamespaceId")]
                [Validation(Required=false)]
                public string MseNamespaceId { get; set; }

            }

            /// <summary>
            /// <para>The routing mode for end-to-end canary release.</para>
            /// <list type="bullet">
            /// <item><description>0: routing based on request content</description></item>
            /// <item><description>1: routing based on percentages</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CanaryModel")]
            [Validation(Required=false)]
            public int? CanaryModel { get; set; }

            /// <summary>
            /// <para>Lane status:</para>
            /// <list type="bullet">
            /// <item><description>true: enabled</description></item>
            /// <item><description>false: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>Whether the traffic rule is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableRules")]
            [Validation(Required=false)]
            public bool? EnableRules { get; set; }

            /// <summary>
            /// <para>The ID of the lane.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9488</para>
            /// </summary>
            [NameInMap("LaneId")]
            [Validation(Required=false)]
            public long? LaneId { get; set; }

            /// <summary>
            /// <para>The name of the lane group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-test</para>
            /// </summary>
            [NameInMap("LaneName")]
            [Validation(Required=false)]
            public string LaneName { get; set; }

            /// <summary>
            /// <para>The label of the lane.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;alicloud.service.tag&quot;:&quot;g1&quot;}</para>
            /// </summary>
            [NameInMap("LaneTag")]
            [Validation(Required=false)]
            public string LaneTag { get; set; }

            /// <summary>
            /// <para>MSE gateway routes.</para>
            /// </summary>
            [NameInMap("MseGatewayEntryRule")]
            [Validation(Required=false)]
            public DescribeSwimmingLaneResponseBodyDataMseGatewayEntryRule MseGatewayEntryRule { get; set; }
            public class DescribeSwimmingLaneResponseBodyDataMseGatewayEntryRule : TeaModel {
                /// <summary>
                /// <para>The logical connector between conditions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AND</para>
                /// </summary>
                [NameInMap("ConditionJoiner")]
                [Validation(Required=false)]
                public string ConditionJoiner { get; set; }

                /// <summary>
                /// <para>The matching condition.</para>
                /// </summary>
                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public List<DescribeSwimmingLaneResponseBodyDataMseGatewayEntryRuleConditions> Conditions { get; set; }
                public class DescribeSwimmingLaneResponseBodyDataMseGatewayEntryRuleConditions : TeaModel {
                    /// <summary>
                    /// <para>The matching rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>==</para>
                    /// </summary>
                    [NameInMap("Condition")]
                    [Validation(Required=false)]
                    public string Condition { get; set; }

                    /// <summary>
                    /// <para>The parameter name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>t</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The type of the parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Header</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The match value of the condition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>g1</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>Whether to enable proportional grayscale.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IndependentPercentageEnable")]
                [Validation(Required=false)]
                public bool? IndependentPercentageEnable { get; set; }

                /// <summary>
                /// <para>The proportion of path traffic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Percentage")]
                [Validation(Required=false)]
                public int? Percentage { get; set; }

                /// <summary>
                /// <para>The traffic configuration.</para>
                /// </summary>
                [NameInMap("PercentageByRoute")]
                [Validation(Required=false)]
                public Dictionary<string, int?> PercentageByRoute { get; set; }

                /// <summary>
                /// <para>The list of route IDs.</para>
                /// </summary>
                [NameInMap("RouteIds")]
                [Validation(Required=false)]
                public List<long?> RouteIds { get; set; }

                /// <summary>
                /// <para>The detailed configuration of the routing rule.</para>
                /// </summary>
                [NameInMap("Routes")]
                [Validation(Required=false)]
                public List<DescribeSwimmingLaneResponseBodyDataMseGatewayEntryRuleRoutes> Routes { get; set; }
                public class DescribeSwimmingLaneResponseBodyDataMseGatewayEntryRuleRoutes : TeaModel {
                    /// <summary>
                    /// <para>The route ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9504</para>
                    /// </summary>
                    [NameInMap("RouteId")]
                    [Validation(Required=false)]
                    public long? RouteId { get; set; }

                    /// <summary>
                    /// <para>The name of the route.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("RouteName")]
                    [Validation(Required=false)]
                    public string RouteName { get; set; }

                    /// <summary>
                    /// <para>The routing rule.</para>
                    /// </summary>
                    [NameInMap("RoutePredicate")]
                    [Validation(Required=false)]
                    public DescribeSwimmingLaneResponseBodyDataMseGatewayEntryRuleRoutesRoutePredicate RoutePredicate { get; set; }
                    public class DescribeSwimmingLaneResponseBodyDataMseGatewayEntryRuleRoutesRoutePredicate : TeaModel {
                        /// <summary>
                        /// <para>The path matching rule.</para>
                        /// </summary>
                        [NameInMap("PathPredicate")]
                        [Validation(Required=false)]
                        public DescribeSwimmingLaneResponseBodyDataMseGatewayEntryRuleRoutesRoutePredicatePathPredicate PathPredicate { get; set; }
                        public class DescribeSwimmingLaneResponseBodyDataMseGatewayEntryRuleRoutesRoutePredicatePathPredicate : TeaModel {
                            /// <summary>
                            /// <para>The path.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>/Path</para>
                            /// </summary>
                            [NameInMap("Path")]
                            [Validation(Required=false)]
                            public string Path { get; set; }

                            /// <summary>
                            /// <para>The matching rule.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Header</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The status code. Value values:</para>
        /// <list type="bullet">
        /// <item><description>If the request was successful, <b>ErrorCode</b> is not returned.</description></item>
        /// <item><description>If the request failed, <b>ErrorCode</b> is returned. For more information, see <b>Error codes</b> in this topic.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>The error message returned because the request is normal and <b>success</b> is returned.</description></item>
        /// <item><description>If the request is abnormal, the specific exception error code is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30375C38-F4ED-4135-A0AE-5C75DC7F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values: Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The information was queried.</description></item>
        /// <item><description><b>false</b>: Query failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The ID of the trace. This parameter is used to query the exact call information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
