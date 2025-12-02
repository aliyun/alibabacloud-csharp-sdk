// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListAllSwimmingLanesResponseBody : TeaModel {
        /// <summary>
        /// <para>The interface status or POP error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The request was successful.</description></item>
        /// <item><description><b>3xx</b>: Redirection.</description></item>
        /// <item><description><b>4xx</b>: Request error.</description></item>
        /// <item><description><b>5xx</b>: Server error.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The output parameters of the node.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAllSwimmingLanesResponseBodyData> Data { get; set; }
        public class ListAllSwimmingLanesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Apply ingress rules.</para>
            /// </summary>
            [NameInMap("AppEntryRule")]
            [Validation(Required=false)]
            public ListAllSwimmingLanesResponseBodyDataAppEntryRule AppEntryRule { get; set; }
            public class ListAllSwimmingLanesResponseBodyDataAppEntryRule : TeaModel {
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
                public List<ListAllSwimmingLanesResponseBodyDataAppEntryRuleConditions> Conditions { get; set; }
                public class ListAllSwimmingLanesResponseBodyDataAppEntryRuleConditions : TeaModel {
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
                    /// <para>The match value.</para>
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
            /// <para>The associated application.</para>
            /// </summary>
            [NameInMap("Apps")]
            [Validation(Required=false)]
            public List<ListAllSwimmingLanesResponseBodyDataApps> Apps { get; set; }
            public class ListAllSwimmingLanesResponseBodyDataApps : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8ea0c468-8165-416d-beae-531abb******</para>
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
                /// <para>The ID of the namespace to which the MSE instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>space</para>
                /// </summary>
                [NameInMap("MseNamespaceId")]
                [Validation(Required=false)]
                public string MseNamespaceId { get; set; }

            }

            /// <summary>
            /// <para>Full-link Grayscale Mode:</para>
            /// <list type="bullet">
            /// <item><description>0: The request is routed based on the content of the request.</description></item>
            /// <item><description>1: Proportional routing</description></item>
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
            /// <para>16401</para>
            /// </summary>
            [NameInMap("LaneId")]
            [Validation(Required=false)]
            public long? LaneId { get; set; }

            /// <summary>
            /// <para>The name of the lane group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
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
            /// <para>MSE gateway routing</para>
            /// </summary>
            [NameInMap("MseGatewayEntryRule")]
            [Validation(Required=false)]
            public ListAllSwimmingLanesResponseBodyDataMseGatewayEntryRule MseGatewayEntryRule { get; set; }
            public class ListAllSwimmingLanesResponseBodyDataMseGatewayEntryRule : TeaModel {
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
                public List<ListAllSwimmingLanesResponseBodyDataMseGatewayEntryRuleConditions> Conditions { get; set; }
                public class ListAllSwimmingLanesResponseBodyDataMseGatewayEntryRuleConditions : TeaModel {
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
                /// <para>The IDs of the route tables.</para>
                /// </summary>
                [NameInMap("RouteIds")]
                [Validation(Required=false)]
                public List<long?> RouteIds { get; set; }

                /// <summary>
                /// <para>The detailed configuration of the routing rule.</para>
                /// </summary>
                [NameInMap("Routes")]
                [Validation(Required=false)]
                public List<ListAllSwimmingLanesResponseBodyDataMseGatewayEntryRuleRoutes> Routes { get; set; }
                public class ListAllSwimmingLanesResponseBodyDataMseGatewayEntryRuleRoutes : TeaModel {
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
                    public ListAllSwimmingLanesResponseBodyDataMseGatewayEntryRuleRoutesRoutePredicate RoutePredicate { get; set; }
                    public class ListAllSwimmingLanesResponseBodyDataMseGatewayEntryRuleRoutesRoutePredicate : TeaModel {
                        /// <summary>
                        /// <para>The path matching rule.</para>
                        /// </summary>
                        [NameInMap("PathPredicate")]
                        [Validation(Required=false)]
                        public ListAllSwimmingLanesResponseBodyDataMseGatewayEntryRuleRoutesRoutePredicatePathPredicate PathPredicate { get; set; }
                        public class ListAllSwimmingLanesResponseBodyDataMseGatewayEntryRuleRoutesRoutePredicatePathPredicate : TeaModel {
                            /// <summary>
                            /// <para>The path.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>/Path</para>
                            /// </summary>
                            [NameInMap("path")]
                            [Validation(Required=false)]
                            public string Path { get; set; }

                            /// <summary>
                            /// <para>The matching rule.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Header</para>
                            /// </summary>
                            [NameInMap("type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                    }

                }

            }

        }

        /// <summary>
        /// <para>Error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the request is successful, no <b>ErrorCode</b> fields are returned.</description></item>
        /// <item><description>Request failed: <b>ErrorCode</b> fields are returned. For more information, see <b>Error codes</b>.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Additional information. Valid values:</para>
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
        /// <para>B4D805CA-926D-41B1-8E63-7AD0C1ED****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the data is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The application instances were restarted.</description></item>
        /// <item><description><b>false</b>: Restart failed.</description></item>
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
