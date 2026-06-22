// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetSensitiveDefineRuleConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned by the API request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSensitiveDefineRuleConfigResponseBodyData Data { get; set; }
        public class GetSensitiveDefineRuleConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether automatic check is enabled for new rules. This parameter takes effect only for agentless checks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Disabled.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("EnableNewRule")]
            [Validation(Required=false)]
            public int? EnableNewRule { get; set; }

            /// <summary>
            /// <para>The custom configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>44616</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The total number of check items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("RuleCount")]
            [Validation(Required=false)]
            public int? RuleCount { get; set; }

            /// <summary>
            /// <para>The check item rule tree.</para>
            /// </summary>
            [NameInMap("RuleTree")]
            [Validation(Required=false)]
            public List<GetSensitiveDefineRuleConfigResponseBodyDataRuleTree> RuleTree { get; set; }
            public class GetSensitiveDefineRuleConfigResponseBodyDataRuleTree : TeaModel {
                /// <summary>
                /// <para>The classification keyword of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>password</para>
                /// </summary>
                [NameInMap("ClassKey")]
                [Validation(Required=false)]
                public string ClassKey { get; set; }

                /// <summary>
                /// <para>The classification name of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>password</para>
                /// </summary>
                [NameInMap("ClassName")]
                [Validation(Required=false)]
                public string ClassName { get; set; }

                /// <summary>
                /// <para>The list of check item rules.</para>
                /// </summary>
                [NameInMap("RuleList")]
                [Validation(Required=false)]
                public List<GetSensitiveDefineRuleConfigResponseBodyDataRuleTreeRuleList> RuleList { get; set; }
                public class GetSensitiveDefineRuleConfigResponseBodyDataRuleTreeRuleList : TeaModel {
                    /// <summary>
                    /// <para>The rule keyword.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>huaweicloud_ak</para>
                    /// </summary>
                    [NameInMap("RuleKey")]
                    [Validation(Required=false)]
                    public string RuleKey { get; set; }

                    /// <summary>
                    /// <para>The rule name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>huaweicloud_ak</para>
                    /// </summary>
                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the rule is selected. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: Selected.</description></item>
                    /// <item><description><b>false</b>: Not selected.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Selected")]
                    [Validation(Required=false)]
                    public bool? Selected { get; set; }

                }

            }

            /// <summary>
            /// <para>The number of selected check items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("SelectedCount")]
            [Validation(Required=false)]
            public int? SelectedCount { get; set; }

        }

        /// <summary>
        /// <para>The message returned for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E0618A9-D5EF-4220-9471-C42B5E92****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the query was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Successful.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
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
