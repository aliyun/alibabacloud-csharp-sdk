// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateOrUpdateSwimmingLaneRequest : TeaModel {
        [NameInMap("AppEntryRule")]
        [Validation(Required=false)]
        public CreateOrUpdateSwimmingLaneRequestAppEntryRule AppEntryRule { get; set; }
        public class CreateOrUpdateSwimmingLaneRequestAppEntryRule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>AND</para>
            /// </summary>
            [NameInMap("ConditionJoiner")]
            [Validation(Required=false)]
            public string ConditionJoiner { get; set; }

            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public List<CreateOrUpdateSwimmingLaneRequestAppEntryRuleConditions> Conditions { get; set; }
            public class CreateOrUpdateSwimmingLaneRequestAppEntryRuleConditions : TeaModel {
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
        /// <para>b2a8a925-477a-eswa-b823-d5e22500****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13857</para>
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
        public CreateOrUpdateSwimmingLaneRequestMseGatewayEntryRule MseGatewayEntryRule { get; set; }
        public class CreateOrUpdateSwimmingLaneRequestMseGatewayEntryRule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>AND</para>
            /// </summary>
            [NameInMap("ConditionJoiner")]
            [Validation(Required=false)]
            public string ConditionJoiner { get; set; }

            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public List<CreateOrUpdateSwimmingLaneRequestMseGatewayEntryRuleConditions> Conditions { get; set; }
            public class CreateOrUpdateSwimmingLaneRequestMseGatewayEntryRuleConditions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>==</para>
                /// </summary>
                [NameInMap("Condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>header</para>
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

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

    }

}
