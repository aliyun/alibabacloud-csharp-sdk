// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeSwimmingLaneResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: Success.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: Redirection.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: Client error.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: Server error.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSwimmingLaneResponseBodyData Data { get; set; }
        public class DescribeSwimmingLaneResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application entry rule.</para>
            /// </summary>
            [NameInMap("AppEntryRule")]
            [Validation(Required=false)]
            public DescribeSwimmingLaneResponseBodyDataAppEntryRule AppEntryRule { get; set; }
            public class DescribeSwimmingLaneResponseBodyDataAppEntryRule : TeaModel {
                /// <summary>
                /// <para>The logical operator that joins conditions. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>AND</c>: All conditions must be met.</para>
                /// </description></item>
                /// <item><description><para><c>OR</c>: At least one of the conditions must be met.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AND</para>
                /// </summary>
                [NameInMap("ConditionJoiner")]
                [Validation(Required=false)]
                public string ConditionJoiner { get; set; }

                /// <summary>
                /// <para>The match conditions.</para>
                /// </summary>
                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public List<DescribeSwimmingLaneResponseBodyDataAppEntryRuleConditions> Conditions { get; set; }
                public class DescribeSwimmingLaneResponseBodyDataAppEntryRuleConditions : TeaModel {
                    /// <summary>
                    /// <para>The match operator.</para>
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
                    /// <para>The type of the parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Header</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The value to match.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>g1</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    /// <summary>
                    /// <para>The values to match.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether percentage-based canary release is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IndependentPercentageEnable")]
                [Validation(Required=false)]
                public bool? IndependentPercentageEnable { get; set; }

                /// <summary>
                /// <para>The request paths.</para>
                /// </summary>
                [NameInMap("Paths")]
                [Validation(Required=false)]
                public List<string> Paths { get; set; }

                /// <summary>
                /// <para>The traffic percentage for percentage-based routing. Valid values: 0 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Percentage")]
                [Validation(Required=false)]
                public int? Percentage { get; set; }

                /// <summary>
                /// <para>An object that maps paths to traffic percentages.</para>
                /// </summary>
                [NameInMap("PercentageByPath")]
                [Validation(Required=false)]
                public Dictionary<string, int?> PercentageByPath { get; set; }

            }

            /// <summary>
            /// <para>A list of associated applications.</para>
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
            /// <para>The mode for the end-to-end canary release. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>0</c>: content-based routing</para>
            /// </description></item>
            /// <item><description><para><c>1</c>: percentage-based routing</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CanaryModel")]
            [Validation(Required=false)]
            public int? CanaryModel { get; set; }

            /// <summary>
            /// <para>Indicates whether the lane is enabled.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: enabled</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: disabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>Indicates whether traffic rules are enabled.</para>
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
            /// <para>The name of the lane.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-test</para>
            /// </summary>
            [NameInMap("LaneName")]
            [Validation(Required=false)]
            public string LaneName { get; set; }

            /// <summary>
            /// <para>The tag of the lane.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;alicloud.service.tag&quot;:&quot;g1&quot;}</para>
            /// </summary>
            [NameInMap("LaneTag")]
            [Validation(Required=false)]
            public string LaneTag { get; set; }

            /// <summary>
            /// <para>The entry rule for the MSE Gateway.</para>
            /// </summary>
            [NameInMap("MseGatewayEntryRule")]
            [Validation(Required=false)]
            public DescribeSwimmingLaneResponseBodyDataMseGatewayEntryRule MseGatewayEntryRule { get; set; }
            public class DescribeSwimmingLaneResponseBodyDataMseGatewayEntryRule : TeaModel {
                /// <summary>
                /// <para>The logical operator that joins conditions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AND</para>
                /// </summary>
                [NameInMap("ConditionJoiner")]
                [Validation(Required=false)]
                public string ConditionJoiner { get; set; }

                /// <summary>
                /// <para>The match conditions.</para>
                /// </summary>
                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public List<DescribeSwimmingLaneResponseBodyDataMseGatewayEntryRuleConditions> Conditions { get; set; }
                public class DescribeSwimmingLaneResponseBodyDataMseGatewayEntryRuleConditions : TeaModel {
                    /// <summary>
                    /// <para>The match operator.</para>
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
                    /// <para>The type of the parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Header</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The value to match.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>g1</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether percentage-based canary release is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IndependentPercentageEnable")]
                [Validation(Required=false)]
                public bool? IndependentPercentageEnable { get; set; }

                /// <summary>
                /// <para>The traffic percentage for the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Percentage")]
                [Validation(Required=false)]
                public int? Percentage { get; set; }

                /// <summary>
                /// <para>An object that maps route IDs to traffic percentages.</para>
                /// </summary>
                [NameInMap("PercentageByRoute")]
                [Validation(Required=false)]
                public Dictionary<string, int?> PercentageByRoute { get; set; }

                /// <summary>
                /// <para>A list of route IDs.</para>
                /// </summary>
                [NameInMap("RouteIds")]
                [Validation(Required=false)]
                public List<long?> RouteIds { get; set; }

                /// <summary>
                /// <para>The route configurations.</para>
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
                    /// <para>The route predicate.</para>
                    /// </summary>
                    [NameInMap("RoutePredicate")]
                    [Validation(Required=false)]
                    public DescribeSwimmingLaneResponseBodyDataMseGatewayEntryRuleRoutesRoutePredicate RoutePredicate { get; set; }
                    public class DescribeSwimmingLaneResponseBodyDataMseGatewayEntryRuleRoutesRoutePredicate : TeaModel {
                        /// <summary>
                        /// <para>The path-based match rule.</para>
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
                            /// <para>The match type.</para>
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
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is returned only if the request fails.</para>
        /// </description></item>
        /// <item><description><para>For more information, see the <b>Error codes</b> section in this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The message returned with the response.</para>
        /// <list type="bullet">
        /// <item><description><para><b>success</b> is returned if the request is successful.</para>
        /// </description></item>
        /// <item><description><para>An error code is returned if the request fails.</para>
        /// </description></item>
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
        /// <para>Indicates whether the request was successful.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The query was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The query failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID. You can use this ID to query the details of a call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
