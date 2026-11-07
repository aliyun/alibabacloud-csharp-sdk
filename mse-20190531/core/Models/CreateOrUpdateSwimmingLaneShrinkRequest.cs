// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreateOrUpdateSwimmingLaneShrinkRequest : TeaModel {
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
        public List<CreateOrUpdateSwimmingLaneShrinkRequestEntryRules> EntryRules { get; set; }
        public class CreateOrUpdateSwimmingLaneShrinkRequestEntryRules : TeaModel {
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
            public List<CreateOrUpdateSwimmingLaneShrinkRequestEntryRulesRestItems> RestItems { get; set; }
            public class CreateOrUpdateSwimmingLaneShrinkRequestEntryRulesRestItems : TeaModel {
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
        public string GatewaySwimmingLaneRouteJsonShrink { get; set; }

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
