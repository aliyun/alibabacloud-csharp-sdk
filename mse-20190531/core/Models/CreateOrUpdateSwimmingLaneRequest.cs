// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreateOrUpdateSwimmingLaneRequest : TeaModel {
        /// <summary>
        /// <para>The language in which the results are returned. Valid values: zh (Chinese, default) and en (English).</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>Specifies whether the lane is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>Specifies whether to configure routing rules for the lane. Configuration is not required if the ingress is a gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableRules")]
        [Validation(Required=false)]
        public bool? EnableRules { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Priority&quot;:1,&quot;Paths&quot;:[],&quot;Condition&quot;:&quot;AND&quot;,&quot;RestItems&quot;:[{&quot;Type&quot;:&quot;param&quot;,&quot;Name&quot;:&quot;name&quot;,&quot;Value&quot;:&quot;xiaoming&quot;,&quot;Cond&quot;:&quot;==&quot;,&quot;Operator&quot;:&quot;rawvalue&quot;}]}]</para>
        /// </summary>
        [NameInMap("EntryRule")]
        [Validation(Required=false)]
        [Obsolete]
        public string EntryRule { get; set; }

        /// <summary>
        /// <para>The collection of lane rules.</para>
        /// </summary>
        [NameInMap("EntryRules")]
        [Validation(Required=false)]
        public List<CreateOrUpdateSwimmingLaneRequestEntryRules> EntryRules { get; set; }
        public class CreateOrUpdateSwimmingLaneRequestEntryRules : TeaModel {
            /// <summary>
            /// <para>Specifies how RestItems are combined to form the final condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AND</para>
            /// </summary>
            [NameInMap("Condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            /// <summary>
            /// <para>The list of paths.</para>
            /// </summary>
            [NameInMap("Paths")]
            [Validation(Required=false)]
            public List<string> Paths { get; set; }

            /// <summary>
            /// <para>The priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The list of matching items.</para>
            /// </summary>
            [NameInMap("RestItems")]
            [Validation(Required=false)]
            public List<CreateOrUpdateSwimmingLaneRequestEntryRulesRestItems> RestItems { get; set; }
            public class CreateOrUpdateSwimmingLaneRequestEntryRulesRestItems : TeaModel {
                /// <summary>
                /// <para>The match operator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>==</para>
                /// </summary>
                [NameInMap("Cond")]
                [Validation(Required=false)]
                public string Cond { get; set; }

                /// <summary>
                /// <para>The value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>x</para>
                /// </summary>
                [NameInMap("Datum")]
                [Validation(Required=false)]
                public string Datum { get; set; }

                /// <summary>
                /// <para>The divisor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Divisor")]
                [Validation(Required=false)]
                public int? Divisor { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>x-mse-tag</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The list of matching items.</para>
                /// </summary>
                [NameInMap("NameList")]
                [Validation(Required=false)]
                public List<string> NameList { get; set; }

                /// <summary>
                /// <para>The operator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rawvalue</para>
                /// </summary>
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>The percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Rate")]
                [Validation(Required=false)]
                public int? Rate { get; set; }

                /// <summary>
                /// <para>The remainder.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Remainder")]
                [Validation(Required=false)]
                public int? Remainder { get; set; }

                /// <summary>
                /// <para>The match type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>header</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gray</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The gateway routing information. This parameter is used when a cloud-native gateway is used as the ingress.</para>
        /// </summary>
        [NameInMap("GatewaySwimmingLaneRouteJson")]
        [Validation(Required=false)]
        public CreateOrUpdateSwimmingLaneRequestGatewaySwimmingLaneRouteJson GatewaySwimmingLaneRouteJson { get; set; }
        public class CreateOrUpdateSwimmingLaneRequestGatewaySwimmingLaneRouteJson : TeaModel {
            /// <summary>
            /// <para>The end-to-end canary release mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: route by request content</para>
            /// </description></item>
            /// <item><description><para>1: route by percentage</para>
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
            /// <para>The canary release condition. Valid values: AND (all conditions must be met) and OR (any condition must be met).</para>
            /// 
            /// <b>Example:</b>
            /// <para>AND</para>
            /// </summary>
            [NameInMap("Condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            /// <summary>
            /// <para>The list of matching conditions.</para>
            /// </summary>
            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public List<CreateOrUpdateSwimmingLaneRequestGatewaySwimmingLaneRouteJsonConditions> Conditions { get; set; }
            public class CreateOrUpdateSwimmingLaneRequestGatewaySwimmingLaneRouteJsonConditions : TeaModel {
                /// <summary>
                /// <para>If you use the legacy version of end-to-end canary release (swimversion is 0, which uses tag-based routing and canary routing), the following values are supported:</para>
                /// <list type="bullet">
                /// <item><description>PRE: prefix match</description></item>
                /// <item><description>ERGULAR: regular expression match</description></item>
                /// <item><description>EQUAL: exact match</description></item>
                /// </list>
                /// <para>If you use the new version of end-to-end canary release (swimversion is 1 or 2, which uses single-service routing), the following values are supported:</para>
                /// <list type="bullet">
                /// <item><description>PRE: prefix match</description></item>
                /// <item><description>regexp: regular expression match</description></item>
                /// <item><description>==: equal to</description></item>
                /// <item><description>!=: not equal to</description></item>
                /// <item><description>list: in</description></item>
                /// <item><description>%: percentage</description></item>
                /// </list>
                /// <para>The new version of end-to-end canary release provides the same features as the legacy version but delivers better performance and simpler configuration. Migrate to the new version of end-to-end canary release.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PRE</para>
                /// </summary>
                [NameInMap("Cond")]
                [Validation(Required=false)]
                public string Cond { get; set; }

                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the parameter. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>header: header</description></item>
                /// <item><description>param: parameter</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>header</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xiaoming</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public long? GatewayId { get; set; }

            /// <summary>
            /// <para>The unique ID of the gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-84efde2ee1464260bdb17a5b****</para>
            /// </summary>
            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }

            /// <summary>
            /// <para>The traffic percentage. This parameter is used for percentage-based routing. Valid values: 0 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Percentage")]
            [Validation(Required=false)]
            public int? Percentage { get; set; }

            /// <summary>
            /// <para>The list of route IDs.</para>
            /// </summary>
            [NameInMap("RouteIdList")]
            [Validation(Required=false)]
            public List<long?> RouteIdList { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> This parameter is used to specify the percentage-based routing setting by route when an MSE cloud-native gateway is used as the ingress.</para>
            /// </summary>
            [NameInMap("RouteIndependentPercentageEnable")]
            [Validation(Required=false)]
            public bool? RouteIndependentPercentageEnable { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The list of routes for independent percentage-based canary releases by route.</para>
            /// </summary>
            [NameInMap("RouteIndependentPercentageList")]
            [Validation(Required=false)]
            public List<CreateOrUpdateSwimmingLaneRequestGatewaySwimmingLaneRouteJsonRouteIndependentPercentageList> RouteIndependentPercentageList { get; set; }
            public class CreateOrUpdateSwimmingLaneRequestGatewaySwimmingLaneRouteJsonRouteIndependentPercentageList : TeaModel {
                /// <summary>
                /// <para>The traffic percentage. This parameter is used for percentage-based routing. Valid values: 0 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Percentage")]
                [Validation(Required=false)]
                public int? Percentage { get; set; }

                /// <summary>
                /// <para>The route ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("RouteId")]
                [Validation(Required=false)]
                public long? RouteId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the lane group to which the lane belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>115</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The primary key ID. A value of -1 indicates that a lane is created. A value greater than 0 indicates that a specified lane is updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The name of the lane.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gray</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The name of the MSE namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> The Java gateway-related configuration for percentage-based routing by path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PathIndependentPercentageEnable")]
        [Validation(Required=false)]
        public bool? PathIndependentPercentageEnable { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gray</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}
