// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateOrUpdateSwimmingLaneRequest : TeaModel {
        /// <summary>
        /// <para>The route configuration of the gateway.</para>
        /// <remarks>
        /// <para> This parameter is required if the gateway entry of the lane group is Java.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AppEntryRule")]
        [Validation(Required=false)]
        public CreateOrUpdateSwimmingLaneRequestAppEntryRule AppEntryRule { get; set; }
        public class CreateOrUpdateSwimmingLaneRequestAppEntryRule : TeaModel {
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
            /// <para>The conditions that trigger circuit breaking.</para>
            /// </summary>
            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public List<CreateOrUpdateSwimmingLaneRequestAppEntryRuleConditions> Conditions { get; set; }
            public class CreateOrUpdateSwimmingLaneRequestAppEntryRuleConditions : TeaModel {
                /// <summary>
                /// <para>Matching Rule:</para>
                /// <list type="bullet">
                /// <item><description>The exact match. The condition is met if the traffic value and the condition value are exactly the same.</description></item>
                /// <item><description>The exact match. The condition is met if the traffic value and the condition value are exactly the same.</description></item>
                /// <item><description>The inclusive match. The condition is met if the traffic value is included in the specified list.</description></item>
                /// <item><description>The percentage match. Principle: The condition is met if \&quot;hash(get(<c>key</c>)) % 100 &lt; value\&quot;.</description></item>
                /// <item><description>Regular match: a regular expression match. The condition is met when the match is based on regular expression rules.</description></item>
                /// </list>
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
                /// <para>The parameter type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>header</description></item>
                /// <item><description>param</description></item>
                /// <item><description>Cookie: forwards requests based on cookies.</description></item>
                /// </list>
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
            /// <list type="bullet">
            /// <item><description>true: enabled. After you enable this parameter, you must configure the PercentageByPath.</description></item>
            /// <item><description>false: disables the service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IndependentPercentageEnable")]
            [Validation(Required=false)]
            public bool? IndependentPercentageEnable { get; set; }

            /// <summary>
            /// <para>The matched request path.</para>
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
            /// <para>The traffic configuration.</para>
            /// </summary>
            [NameInMap("PercentageByPath")]
            [Validation(Required=false)]
            public Dictionary<string, int?> PercentageByPath { get; set; }

        }

        /// <summary>
        /// <para>Full-link Grayscale Mode:</para>
        /// <list type="bullet">
        /// <item><description>0: The request is routed based on the content of the request.</description></item>
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
        /// <para>Lane Status</para>
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
        /// <para>The ID of the lane group to which the lane belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b2a8a925-477a-eswa-b823-d5e22500****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the lane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13857</para>
        /// </summary>
        [NameInMap("LaneId")]
        [Validation(Required=false)]
        public long? LaneId { get; set; }

        /// <summary>
        /// <para>The name of the lane.</para>
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
        /// <para>The route configuration of the MSE gateway.</para>
        /// <remarks>
        /// <para> If the <b>EntryAppType</b> is set to <b>apig</b> or <b>mse-gw</b>, it is required.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("MseGatewayEntryRule")]
        [Validation(Required=false)]
        public CreateOrUpdateSwimmingLaneRequestMseGatewayEntryRule MseGatewayEntryRule { get; set; }
        public class CreateOrUpdateSwimmingLaneRequestMseGatewayEntryRule : TeaModel {
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
            /// <para>Routing Condition</para>
            /// </summary>
            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public List<CreateOrUpdateSwimmingLaneRequestMseGatewayEntryRuleConditions> Conditions { get; set; }
            public class CreateOrUpdateSwimmingLaneRequestMseGatewayEntryRuleConditions : TeaModel {
                /// <summary>
                /// <para>The matching rule.</para>
                /// <list type="bullet">
                /// <item><description>\==: exact match.</description></item>
                /// <item><description>! =: exact match.</description></item>
                /// <item><description>in: contains matches.</description></item>
                /// <item><description>Percentage: Percentage matching.</description></item>
                /// <item><description>Regular matching: specifies whether a regular expression is used to search for the original string.</description></item>
                /// </list>
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
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The parameter type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>header</description></item>
                /// <item><description>param</description></item>
                /// <item><description>Cookie: forwards requests based on cookies.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>header</para>
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
            /// <list type="bullet">
            /// <item><description>true: Enabled. After you enable this parameter, you must configure the PercentageByPath.</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IndependentPercentageEnable")]
            [Validation(Required=false)]
            public bool? IndependentPercentageEnable { get; set; }

            /// <summary>
            /// <para>The percentage of traffic replication. Valid values: 0 to 100.</para>
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
            /// <para>The ID of the route.</para>
            /// </summary>
            [NameInMap("RouteIds")]
            [Validation(Required=false)]
            public List<long?> RouteIds { get; set; }

        }

        /// <summary>
        /// <para>The namespace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

    }

}
