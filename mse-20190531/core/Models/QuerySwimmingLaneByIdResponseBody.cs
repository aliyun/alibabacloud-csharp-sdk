// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QuerySwimmingLaneByIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{id:102,name:&quot;test&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySwimmingLaneByIdResponseBodyData Data { get; set; }
        public class QuerySwimmingLaneByIdResponseBodyData : TeaModel {
            /// <summary>
            /// <para>This parameter is discontinued. This parameter is used to specify whether to enable grayscale by path when Java gateway is used as the entry for the swimming lane group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("PathIndependentPercentageEnable")]
            [Validation(Required=false)]
            public bool? PathIndependentPercentageEnable { get; set; }

            /// <summary>
            /// <para>The swimming lane switch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the rule. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableRules")]
            [Validation(Required=false)]
            public bool? EnableRules { get; set; }

            /// <summary>
            /// <para>The entry application rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("entryRule")]
            [Validation(Required=false)]
            public string EntryRule { get; set; }

            /// <summary>
            /// <para>The details of the entry application rules.</para>
            /// </summary>
            [NameInMap("entryRules")]
            [Validation(Required=false)]
            public List<QuerySwimmingLaneByIdResponseBodyDataEntryRules> EntryRules { get; set; }
            public class QuerySwimmingLaneByIdResponseBodyDataEntryRules : TeaModel {
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
                /// <para>/</para>
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
                /// <para>The Restful matching rules.</para>
                /// </summary>
                [NameInMap("restItems")]
                [Validation(Required=false)]
                public List<QuerySwimmingLaneByIdResponseBodyDataEntryRulesRestItems> RestItems { get; set; }
                public class QuerySwimmingLaneByIdResponseBodyDataEntryRulesRestItems : TeaModel {
                    /// <summary>
                    /// <para>The matching character.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>==</para>
                    /// </summary>
                    [NameInMap("cond")]
                    [Validation(Required=false)]
                    public string Cond { get; set; }

                    /// <summary>
                    /// <para>The number.</para>
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
                    /// <para>11111</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The names.</para>
                    /// </summary>
                    [NameInMap("nameList")]
                    [Validation(Required=false)]
                    public List<string> NameList { get; set; }

                    /// <summary>
                    /// <para>The filter operator.</para>
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
                    /// <para>hello</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The MSE gateway routing rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("gatewaySwimmingLaneRouteJson")]
            [Validation(Required=false)]
            public string GatewaySwimmingLaneRouteJson { get; set; }

            /// <summary>
            /// <para>Rule Created At</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683598484000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>Rule Modified At</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683598484000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The swimming lane group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// <para>The swimming lane ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The swimming lane name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The swimming lane status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The tag corresponding to the swimming lane.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gray</para>
            /// </summary>
            [NameInMap("tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-100-000</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request is processed successfully.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69AD2AA7-DB47-449B-941B-B14409DF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
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
