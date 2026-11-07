// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryAllSwimmingLaneResponseBody : TeaModel {
        /// <summary>
        /// <para>Data Overview.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{id:100,name:&quot;test&quot;}]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryAllSwimmingLaneResponseBodyData> Data { get; set; }
        public class QueryAllSwimmingLaneResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the lane is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public string Enable { get; set; }

            /// <summary>
            /// <para>The list of rules for the ingress application.</para>
            /// </summary>
            [NameInMap("EntryRules")]
            [Validation(Required=false)]
            public List<QueryAllSwimmingLaneResponseBodyDataEntryRules> EntryRules { get; set; }
            public class QueryAllSwimmingLaneResponseBodyDataEntryRules : TeaModel {
                /// <summary>
                /// <para>The condition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AND</para>
                /// </summary>
                [NameInMap("condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                /// <summary>
                /// <para>The path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/adump/wxb/prod</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The list of paths.</para>
                /// </summary>
                [NameInMap("paths")]
                [Validation(Required=false)]
                public List<string> Paths { get; set; }

                /// <summary>
                /// <para>The list of RESTful matching rules.</para>
                /// </summary>
                [NameInMap("restItems")]
                [Validation(Required=false)]
                public List<QueryAllSwimmingLaneResponseBodyDataEntryRulesRestItems> RestItems { get; set; }
                public class QueryAllSwimmingLaneResponseBodyDataEntryRulesRestItems : TeaModel {
                    /// <summary>
                    /// <para>The matching operator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>==</para>
                    /// </summary>
                    [NameInMap("cond")]
                    [Validation(Required=false)]
                    public string Cond { get; set; }

                    /// <summary>
                    /// <para>The value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>x</para>
                    /// </summary>
                    [NameInMap("datum")]
                    [Validation(Required=false)]
                    public string Datum { get; set; }

                    /// <summary>
                    /// <para>The divisor.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("divisor")]
                    [Validation(Required=false)]
                    public int? Divisor { get; set; }

                    /// <summary>
                    /// <para>The name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The list of items to match.</para>
                    /// </summary>
                    [NameInMap("nameList")]
                    [Validation(Required=false)]
                    public List<string> NameList { get; set; }

                    /// <summary>
                    /// <para>The operator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rawvalue</para>
                    /// </summary>
                    [NameInMap("operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <para>The percentage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("rate")]
                    [Validation(Required=false)]
                    public int? Rate { get; set; }

                    /// <summary>
                    /// <para>The remainder.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("remainder")]
                    [Validation(Required=false)]
                    public int? Remainder { get; set; }

                    /// <summary>
                    /// <para>The matching type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cookie</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The information about the gateway route. This parameter is used when a cloud-native gateway or an API Gateway instance is used as the ingress.</para>
            /// </summary>
            [NameInMap("GatewaySwimmingLaneRoute")]
            [Validation(Required=false)]
            public QueryAllSwimmingLaneResponseBodyDataGatewaySwimmingLaneRoute GatewaySwimmingLaneRoute { get; set; }
            public class QueryAllSwimmingLaneResponseBodyDataGatewaySwimmingLaneRoute : TeaModel {
                /// <summary>
                /// <para>The mode of the end-to-end canary release. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0: route by the content of the request</para>
                /// </description></item>
                /// <item><description><para>1: route by proportion</para>
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
                /// <para>The condition for the canary release.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AND、OR</para>
                /// </summary>
                [NameInMap("Condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                /// <summary>
                /// <para>The list of matching conditions. This parameter is used when you route requests by content.</para>
                /// </summary>
                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public List<QueryAllSwimmingLaneResponseBodyDataGatewaySwimmingLaneRouteConditions> Conditions { get; set; }
                public class QueryAllSwimmingLaneResponseBodyDataGatewaySwimmingLaneRouteConditions : TeaModel {
                    /// <summary>
                    /// <para>The condition. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>PRE: prefix match</para>
                    /// </description></item>
                    /// <item><description><para>EQUAL: exact match</para>
                    /// </description></item>
                    /// <item><description><para>REGULAR: regular expression match</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PRE</para>
                    /// </summary>
                    [NameInMap("Cond")]
                    [Validation(Required=false)]
                    public string Cond { get; set; }

                    /// <summary>
                    /// <para>The parameter name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>name</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>NameList</para>
                    /// </summary>
                    [NameInMap("NameList")]
                    [Validation(Required=false)]
                    public List<string> NameList { get; set; }

                    /// <summary>
                    /// <para>The parameter type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>header: Header</para>
                    /// </description></item>
                    /// <item><description><para>param: Parameter</para>
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
                    /// <para>The parameter value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xiaoming</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The gateway ID.</para>
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
                /// <para>The traffic proportion. This parameter is used when you route requests by proportion. Valid values: 0 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Percentage")]
                [Validation(Required=false)]
                public int? Percentage { get; set; }

                /// <summary>
                /// <para>The list of route IDs. This parameter is optional if the canary release is effective at the gateway level.</para>
                /// </summary>
                [NameInMap("RouteIdList")]
                [Validation(Required=false)]
                public List<long?> RouteIdList { get; set; }

                /// <summary>
                /// <para>Indicates whether to independently set the percentage for each path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("RouteIndependentPercentageEnable")]
                [Validation(Required=false)]
                public string RouteIndependentPercentageEnable { get; set; }

                /// <summary>
                /// <para>The list of routes and percentages.</para>
                /// </summary>
                [NameInMap("RouteIndependentPercentageList")]
                [Validation(Required=false)]
                public List<QueryAllSwimmingLaneResponseBodyDataGatewaySwimmingLaneRouteRouteIndependentPercentageList> RouteIndependentPercentageList { get; set; }
                public class QueryAllSwimmingLaneResponseBodyDataGatewaySwimmingLaneRouteRouteIndependentPercentageList : TeaModel {
                    /// <summary>
                    /// <para>The percentage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>60</para>
                    /// </summary>
                    [NameInMap("Percentage")]
                    [Validation(Required=false)]
                    public string Percentage { get; set; }

                    /// <summary>
                    /// <para>The route ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("RouteId")]
                    [Validation(Required=false)]
                    public string RouteId { get; set; }

                }

            }

            /// <summary>
            /// <para>The information about the gateway. This parameter is used when an MSE cloud-native gateway or a cloud-native API Gateway instance is used as the ingress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;GatewayUniqueId\&quot;:\&quot;gw-cf815503e0a8441b8956d8e349fa8fb5\&quot;,\&quot;Percentage\&quot;:0,\&quot;RouteIdList\&quot;:[32295,32298,32297,32309,32307,32294,32303,32292,32299,35278],\&quot;CanaryModel\&quot;:1,\&quot;Conditions\&quot;:[]}</para>
            /// </summary>
            [NameInMap("GatewaySwimmingLaneRouteJson")]
            [Validation(Required=false)]
            public string GatewaySwimmingLaneRouteJson { get; set; }

            /// <summary>
            /// <para>The ID of the lane group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6859</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The lane ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The side on which canary release for messages is implemented.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Client</para>
            /// </summary>
            [NameInMap("MessageQueueFilterSide")]
            [Validation(Required=false)]
            public string MessageQueueFilterSide { get; set; }

            /// <summary>
            /// <para>Indicates whether canary release for messages is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("MessageQueueGrayEnable")]
            [Validation(Required=false)]
            public bool? MessageQueueGrayEnable { get; set; }

            /// <summary>
            /// <para>The name of the lane group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>swimmingGroup</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The MSE namespace to which the lane belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>Indicates whether to set the percentage for each path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PathIndependentPercentageEnable")]
            [Validation(Required=false)]
            public bool? PathIndependentPercentageEnable { get; set; }

            /// <summary>
            /// <para>Indicates whether to record the request details. This is for the observability of end-to-end canary releases.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("RecordCanaryDetail")]
            [Validation(Required=false)]
            public bool? RecordCanaryDetail { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The tag of the lane.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gray</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The ID of the user to which the lane belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>Indicates whether rules are enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableRules")]
            [Validation(Required=false)]
            public bool? EnableRules { get; set; }

            /// <summary>
            /// <para>The time when the lane was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683598484000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the lane was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683598484000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC34E4A3-5F1C-4E40-86EA-02EDF967****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
