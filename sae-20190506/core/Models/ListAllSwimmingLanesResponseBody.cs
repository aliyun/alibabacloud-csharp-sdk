// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListAllSwimmingLanesResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: The request is successful.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: The request is redirected.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: The request is invalid.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: A server error occurs.</para>
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
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAllSwimmingLanesResponseBodyData> Data { get; set; }
        public class ListAllSwimmingLanesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application entry rule.</para>
            /// </summary>
            [NameInMap("AppEntryRule")]
            [Validation(Required=false)]
            public ListAllSwimmingLanesResponseBodyDataAppEntryRule AppEntryRule { get; set; }
            public class ListAllSwimmingLanesResponseBodyDataAppEntryRule : TeaModel {
                /// <summary>
                /// <para>The logical operator used to join conditions:</para>
                /// <list type="bullet">
                /// <item><description><para>AND: All conditions must be met.</para>
                /// </description></item>
                /// <item><description><para>OR: One of the conditions must be met.</para>
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
                /// <para>The matching conditions.</para>
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
                    /// <para>The parameter type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Header</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The value to match in the condition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>g1</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    /// <summary>
                    /// <para>The values to match in the condition.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether to enable canary release by percentage.</para>
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
                /// <para>The percentage of traffic (0-100) to be routed when the route by percentage model is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Percentage")]
                [Validation(Required=false)]
                public int? Percentage { get; set; }

                /// <summary>
                /// <para>A map of paths to their corresponding traffic percentages.</para>
                /// </summary>
                [NameInMap("PercentageByPath")]
                [Validation(Required=false)]
                public Dictionary<string, int?> PercentageByPath { get; set; }

            }

            /// <summary>
            /// <para>The applications associated with the swimming lane.</para>
            /// </summary>
            [NameInMap("Apps")]
            [Validation(Required=false)]
            public List<ListAllSwimmingLanesResponseBodyDataApps> Apps { get; set; }
            public class ListAllSwimmingLanesResponseBodyDataApps : TeaModel {
                /// <summary>
                /// <para>The application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8ea0c468-8165-416d-beae-531abb******</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The MSE instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mse-cn-53y49******</para>
                /// </summary>
                [NameInMap("MseAppId")]
                [Validation(Required=false)]
                public string MseAppId { get; set; }

                /// <summary>
                /// <para>The MSE instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sae-test</para>
                /// </summary>
                [NameInMap("MseAppName")]
                [Validation(Required=false)]
                public string MseAppName { get; set; }

                /// <summary>
                /// <para>The ID of the namespace in which the MSE instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sae-ent</para>
                /// </summary>
                [NameInMap("MseNamespaceId")]
                [Validation(Required=false)]
                public string MseNamespaceId { get; set; }

            }

            /// <summary>
            /// <para>The canary model for the end-to-end canary release:</para>
            /// <list type="bullet">
            /// <item><description><para>0: Route by request content.</para>
            /// </description></item>
            /// <item><description><para>1: Route by percentage.</para>
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
            /// <para>Indicates whether the swimming lane is enabled.</para>
            /// <list type="bullet">
            /// <item><description><para>true: enabled</para>
            /// </description></item>
            /// <item><description><para>false: disabled</para>
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
            /// <para>The swimming lane ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16401</para>
            /// </summary>
            [NameInMap("LaneId")]
            [Validation(Required=false)]
            public long? LaneId { get; set; }

            /// <summary>
            /// <para>The swimming lane name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("LaneName")]
            [Validation(Required=false)]
            public string LaneName { get; set; }

            /// <summary>
            /// <para>The swimming lane tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>g1</para>
            /// </summary>
            [NameInMap("LaneTag")]
            [Validation(Required=false)]
            public string LaneTag { get; set; }

            /// <summary>
            /// <para>The MSE gateway route.</para>
            /// </summary>
            [NameInMap("MseGatewayEntryRule")]
            [Validation(Required=false)]
            public ListAllSwimmingLanesResponseBodyDataMseGatewayEntryRule MseGatewayEntryRule { get; set; }
            public class ListAllSwimmingLanesResponseBodyDataMseGatewayEntryRule : TeaModel {
                /// <summary>
                /// <para>The logical operator used to join conditions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AND</para>
                /// </summary>
                [NameInMap("ConditionJoiner")]
                [Validation(Required=false)]
                public string ConditionJoiner { get; set; }

                /// <summary>
                /// <para>The matching conditions.</para>
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
                    /// <para>The parameter type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Header</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The value to match in the condition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>g1</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether to enable canary release by percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IndependentPercentageEnable")]
                [Validation(Required=false)]
                public bool? IndependentPercentageEnable { get; set; }

                /// <summary>
                /// <para>The percentage of traffic for the path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Percentage")]
                [Validation(Required=false)]
                public int? Percentage { get; set; }

                /// <summary>
                /// <para>A map of route IDs to their corresponding traffic percentages.</para>
                /// </summary>
                [NameInMap("PercentageByRoute")]
                [Validation(Required=false)]
                public Dictionary<string, int?> PercentageByRoute { get; set; }

                /// <summary>
                /// <para>The route IDs.</para>
                /// </summary>
                [NameInMap("RouteIds")]
                [Validation(Required=false)]
                public List<long?> RouteIds { get; set; }

                /// <summary>
                /// <para>The route configurations.</para>
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
                    /// <para>The route name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("RouteName")]
                    [Validation(Required=false)]
                    public string RouteName { get; set; }

                    /// <summary>
                    /// <para>The route\&quot;s matching rule.</para>
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
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description><para>The <b>ErrorCode</b> parameter is omitted if the request is successful.</para>
        /// </description></item>
        /// <item><description><para>The <b>ErrorCode</b> parameter is returned if the request fails. For details, see the <b>Error codes</b> section in this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The response message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Returns <b>success</b> if the request is successful.</para>
        /// </description></item>
        /// <item><description><para>Returns a specific error code if the request fails.</para>
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
        /// <para>B4D805CA-926D-41B1-8E63-7AD0C1ED****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request is successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request fails.</para>
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
        /// <para>The trace ID used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
