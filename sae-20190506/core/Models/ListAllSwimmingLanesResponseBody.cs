// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListAllSwimmingLanesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAllSwimmingLanesResponseBodyData> Data { get; set; }
        public class ListAllSwimmingLanesResponseBodyData : TeaModel {
            [NameInMap("AppEntryRule")]
            [Validation(Required=false)]
            public ListAllSwimmingLanesResponseBodyDataAppEntryRule AppEntryRule { get; set; }
            public class ListAllSwimmingLanesResponseBodyDataAppEntryRule : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>AND</para>
                /// </summary>
                [NameInMap("ConditionJoiner")]
                [Validation(Required=false)]
                public string ConditionJoiner { get; set; }

                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public List<ListAllSwimmingLanesResponseBodyDataAppEntryRuleConditions> Conditions { get; set; }
                public class ListAllSwimmingLanesResponseBodyDataAppEntryRuleConditions : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>==</para>
                    /// </summary>
                    [NameInMap("Condition")]
                    [Validation(Required=false)]
                    public string Condition { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>t</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Header</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>g1</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IndependentPercentageEnable")]
                [Validation(Required=false)]
                public bool? IndependentPercentageEnable { get; set; }

                [NameInMap("Paths")]
                [Validation(Required=false)]
                public List<string> Paths { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Percentage")]
                [Validation(Required=false)]
                public int? Percentage { get; set; }

                [NameInMap("PercentageByPath")]
                [Validation(Required=false)]
                public Dictionary<string, int?> PercentageByPath { get; set; }

            }

            [NameInMap("Apps")]
            [Validation(Required=false)]
            public List<ListAllSwimmingLanesResponseBodyDataApps> Apps { get; set; }
            public class ListAllSwimmingLanesResponseBodyDataApps : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>8ea0c468-8165-416d-beae-531abb******</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mse-cn-53y49******</para>
                /// </summary>
                [NameInMap("MseAppId")]
                [Validation(Required=false)]
                public string MseAppId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sae-test</para>
                /// </summary>
                [NameInMap("MseAppName")]
                [Validation(Required=false)]
                public string MseAppName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>space</para>
                /// </summary>
                [NameInMap("MseNamespaceId")]
                [Validation(Required=false)]
                public string MseNamespaceId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CanaryModel")]
            [Validation(Required=false)]
            public int? CanaryModel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableRules")]
            [Validation(Required=false)]
            public bool? EnableRules { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>16401</para>
            /// </summary>
            [NameInMap("LaneId")]
            [Validation(Required=false)]
            public long? LaneId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("LaneName")]
            [Validation(Required=false)]
            public string LaneName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;alicloud.service.tag&quot;:&quot;g1&quot;}</para>
            /// </summary>
            [NameInMap("LaneTag")]
            [Validation(Required=false)]
            public string LaneTag { get; set; }

            [NameInMap("MseGatewayEntryRule")]
            [Validation(Required=false)]
            public ListAllSwimmingLanesResponseBodyDataMseGatewayEntryRule MseGatewayEntryRule { get; set; }
            public class ListAllSwimmingLanesResponseBodyDataMseGatewayEntryRule : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>AND</para>
                /// </summary>
                [NameInMap("ConditionJoiner")]
                [Validation(Required=false)]
                public string ConditionJoiner { get; set; }

                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public List<ListAllSwimmingLanesResponseBodyDataMseGatewayEntryRuleConditions> Conditions { get; set; }
                public class ListAllSwimmingLanesResponseBodyDataMseGatewayEntryRuleConditions : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>==</para>
                    /// </summary>
                    [NameInMap("Condition")]
                    [Validation(Required=false)]
                    public string Condition { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>t</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Header</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>g1</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IndependentPercentageEnable")]
                [Validation(Required=false)]
                public bool? IndependentPercentageEnable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Percentage")]
                [Validation(Required=false)]
                public int? Percentage { get; set; }

                [NameInMap("PercentageByRoute")]
                [Validation(Required=false)]
                public Dictionary<string, int?> PercentageByRoute { get; set; }

                [NameInMap("RouteIds")]
                [Validation(Required=false)]
                public List<long?> RouteIds { get; set; }

                [NameInMap("Routes")]
                [Validation(Required=false)]
                public List<ListAllSwimmingLanesResponseBodyDataMseGatewayEntryRuleRoutes> Routes { get; set; }
                public class ListAllSwimmingLanesResponseBodyDataMseGatewayEntryRuleRoutes : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>9504</para>
                    /// </summary>
                    [NameInMap("RouteId")]
                    [Validation(Required=false)]
                    public long? RouteId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("RouteName")]
                    [Validation(Required=false)]
                    public string RouteName { get; set; }

                    [NameInMap("RoutePredicate")]
                    [Validation(Required=false)]
                    public ListAllSwimmingLanesResponseBodyDataMseGatewayEntryRuleRoutesRoutePredicate RoutePredicate { get; set; }
                    public class ListAllSwimmingLanesResponseBodyDataMseGatewayEntryRuleRoutesRoutePredicate : TeaModel {
                        [NameInMap("PathPredicate")]
                        [Validation(Required=false)]
                        public ListAllSwimmingLanesResponseBodyDataMseGatewayEntryRuleRoutesRoutePredicatePathPredicate PathPredicate { get; set; }
                        public class ListAllSwimmingLanesResponseBodyDataMseGatewayEntryRuleRoutesRoutePredicatePathPredicate : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>/Path</para>
                            /// </summary>
                            [NameInMap("path")]
                            [Validation(Required=false)]
                            public string Path { get; set; }

                            /// <summary>
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

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B4D805CA-926D-41B1-8E63-7AD0C1ED****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
