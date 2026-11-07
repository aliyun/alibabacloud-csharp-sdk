// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreateOrUpdateSwimmingLaneResponseBody : TeaModel {
        /// <summary>
        /// <para>The code used only to synchronize with the Success parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data overview.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateOrUpdateSwimmingLaneResponseBodyData Data { get; set; }
        public class CreateOrUpdateSwimmingLaneResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The swimlane switch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>Specifies whether the rules are enabled.</para>
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
            /// <para>The name.</para>
            /// </summary>
            [NameInMap("entryRules")]
            [Validation(Required=false)]
            public List<CreateOrUpdateSwimmingLaneResponseBodyDataEntryRules> EntryRules { get; set; }
            public class CreateOrUpdateSwimmingLaneResponseBodyDataEntryRules : TeaModel {
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
                /// <para>The code group path.</para>
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
                /// <para>The list of REST matching rules.</para>
                /// </summary>
                [NameInMap("restItems")]
                [Validation(Required=false)]
                public List<CreateOrUpdateSwimmingLaneResponseBodyDataEntryRulesRestItems> RestItems { get; set; }
                public class CreateOrUpdateSwimmingLaneResponseBodyDataEntryRulesRestItems : TeaModel {
                    /// <summary>
                    /// <para>The match operator.</para>
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
                    /// <para>The list of names.</para>
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
                    /// <para>The match type.</para>
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
                    /// <para>9</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The MSE gateway routing rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("gatewaySwimmingLaneRouteJson")]
            [Validation(Required=false)]
            public string GatewaySwimmingLaneRouteJson { get; set; }

            /// <summary>
            /// <para>The time when the swimlane was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1545726028000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the swimlane was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1565701886000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The swimlane group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>72586</para>
            /// </summary>
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// <para>The swimlane ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>94765</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The swimlane name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> Specifies whether to enable percentage-based canary releases by path when a Java gateway is used as the entry point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("pathIndependentPercentageEnable")]
            [Validation(Required=false)]
            public bool? PathIndependentPercentageEnable { get; set; }

            /// <summary>
            /// <para>The region where the application is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The swimlane status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The tag corresponding to the swimlane.</para>
            /// 
            /// <b>Example:</b>
            /// <para>release</para>
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
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Succ</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE5C32A1-BC0E-4B79-817C-103E4EDF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request is successful.</description></item>
        /// <item><description><c>false</c>: The request fails.</description></item>
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
