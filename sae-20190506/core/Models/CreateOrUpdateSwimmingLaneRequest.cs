// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateOrUpdateSwimmingLaneRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the gateway route.</para>
        /// <remarks>
        /// <para>This parameter is required if the gateway entry application for the swimlane group is a Java application.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AppEntryRule")]
        [Validation(Required=false)]
        public CreateOrUpdateSwimmingLaneRequestAppEntryRule AppEntryRule { get; set; }
        public class CreateOrUpdateSwimmingLaneRequestAppEntryRule : TeaModel {
            /// <summary>
            /// <para>The logical operator used to combine conditions.</para>
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
            public List<CreateOrUpdateSwimmingLaneRequestAppEntryRuleConditions> Conditions { get; set; }
            public class CreateOrUpdateSwimmingLaneRequestAppEntryRuleConditions : TeaModel {
                /// <summary>
                /// <para>The matching rule.</para>
                /// <list type="bullet">
                /// <item><description><para><c>==</c>: Exact match. The attribute\&quot;s value must be identical to the value specified.</para>
                /// </description></item>
                /// <item><description><para><c>!=</c>: Negated exact match. The attribute\&quot;s value must not be identical to the value specified.</para>
                /// </description></item>
                /// <item><description><para><c>in</c>: Inclusion match. The attribute\&quot;s value must be present in the specified comma-separated list of values.</para>
                /// </description></item>
                /// <item><description><para><c>percentage</c>: Percentage-based match. The expression <c>hash(get(key)) % 100 &lt; value</c> must be true.</para>
                /// </description></item>
                /// <item><description><para><c>regex</c>: Regular expression match. The attribute\&quot;s value must match the specified regular expression.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>==</para>
                /// </summary>
                [NameInMap("Condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                /// <summary>
                /// <para>The name of the header, parameter, or cookie.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the request attribute to match.</para>
                /// <list type="bullet">
                /// <item><description><para><c>header</c>: A request header.</para>
                /// </description></item>
                /// <item><description><para><c>param</c>: A request parameter.</para>
                /// </description></item>
                /// <item><description><para><c>cookie</c>: A request cookie.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Header</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The value to match against the request attribute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>g1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable percentage-based routing.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enables percentage-based routing. You must also configure the <c>PercentageByPath</c> parameter.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disables percentage-based routing.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IndependentPercentageEnable")]
            [Validation(Required=false)]
            public bool? IndependentPercentageEnable { get; set; }

            /// <summary>
            /// <para>The request paths to match.</para>
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
            /// <para>An object that maps request paths to traffic percentages.</para>
            /// </summary>
            [NameInMap("PercentageByPath")]
            [Validation(Required=false)]
            public Dictionary<string, int?> PercentageByPath { get; set; }

        }

        /// <summary>
        /// <para>The end-to-end canary release mode.</para>
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
        /// <para>The status of the swimlane.</para>
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
        /// <para>The ID of the swimlane group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b2a8a925-477a-eswa-b823-d5e22500****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the swimlane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13857</para>
        /// </summary>
        [NameInMap("LaneId")]
        [Validation(Required=false)]
        public long? LaneId { get; set; }

        /// <summary>
        /// <para>The name of the swimlane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("LaneName")]
        [Validation(Required=false)]
        public string LaneName { get; set; }

        /// <summary>
        /// <para>The tag of the swimlane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>g1</para>
        /// </summary>
        [NameInMap("LaneTag")]
        [Validation(Required=false)]
        public string LaneTag { get; set; }

        /// <summary>
        /// <para>Configuration for the MSE gateway route.</para>
        /// <remarks>
        /// <para>This parameter is required if the <b>EntryAppType</b> parameter is set to <b>apig</b> or <b>mse-gw</b>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("MseGatewayEntryRule")]
        [Validation(Required=false)]
        public CreateOrUpdateSwimmingLaneRequestMseGatewayEntryRule MseGatewayEntryRule { get; set; }
        public class CreateOrUpdateSwimmingLaneRequestMseGatewayEntryRule : TeaModel {
            /// <summary>
            /// <para>The logical operator used to combine conditions.</para>
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
            public List<CreateOrUpdateSwimmingLaneRequestMseGatewayEntryRuleConditions> Conditions { get; set; }
            public class CreateOrUpdateSwimmingLaneRequestMseGatewayEntryRuleConditions : TeaModel {
                /// <summary>
                /// <para>The matching rule.</para>
                /// <list type="bullet">
                /// <item><description><para><c>==</c>: Exact match. The attribute\&quot;s value must be identical to the value specified.</para>
                /// </description></item>
                /// <item><description><para><c>!=</c>: Negated exact match. The attribute\&quot;s value must not be identical to the value specified.</para>
                /// </description></item>
                /// <item><description><para><c>in</c>: Inclusion match. The attribute\&quot;s value must be present in the specified comma-separated list of values.</para>
                /// </description></item>
                /// <item><description><para><c>percentage</c>: Percentage-based match. The expression <c>hash(get(key)) % 100 &lt; value</c> must be true.</para>
                /// </description></item>
                /// <item><description><para><c>regex</c>: Regular expression match. The attribute\&quot;s value must match the specified regular expression.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>==</para>
                /// </summary>
                [NameInMap("Condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                /// <summary>
                /// <para>The name of the header, parameter, or cookie.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the request attribute to match.</para>
                /// <list type="bullet">
                /// <item><description><para><c>header</c>: A request header.</para>
                /// </description></item>
                /// <item><description><para><c>param</c>: A request parameter.</para>
                /// </description></item>
                /// <item><description><para><c>cookie</c>: A request cookie.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>header</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The value to match against the request attribute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>g1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable percentage-based routing.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Enables percentage-based routing. You must also configure the <c>PercentageByRoute</c> parameter.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Disables percentage-based routing.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IndependentPercentageEnable")]
            [Validation(Required=false)]
            public bool? IndependentPercentageEnable { get; set; }

            /// <summary>
            /// <para>The traffic mirroring percentage. Valid values: 0 to 100.</para>
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
            /// <para>The route IDs.</para>
            /// </summary>
            [NameInMap("RouteIds")]
            [Validation(Required=false)]
            public List<long?> RouteIds { get; set; }

        }

        /// <summary>
        /// <para>The ID of the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

    }

}
