// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetBuildRiskDefineRuleConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The status code <b>200</b> indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetBuildRiskDefineRuleConfigResponseBodyData Data { get; set; }
        public class GetBuildRiskDefineRuleConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The configuration ID for scanning image build command risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>273698***</para>
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
            /// <para>The details of all check items.</para>
            /// </summary>
            [NameInMap("RuleTree")]
            [Validation(Required=false)]
            public List<GetBuildRiskDefineRuleConfigResponseBodyDataRuleTree> RuleTree { get; set; }
            public class GetBuildRiskDefineRuleConfigResponseBodyDataRuleTree : TeaModel {
                /// <summary>
                /// <para>The check item type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>other</para>
                /// </summary>
                [NameInMap("ClassKey")]
                [Validation(Required=false)]
                public string ClassKey { get; set; }

                /// <summary>
                /// <para>The name of the check item type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>other</para>
                /// </summary>
                [NameInMap("ClassName")]
                [Validation(Required=false)]
                public string ClassName { get; set; }

                /// <summary>
                /// <para>The check items of the type.</para>
                /// </summary>
                [NameInMap("RuleList")]
                [Validation(Required=false)]
                public List<GetBuildRiskDefineRuleConfigResponseBodyDataRuleTreeRuleList> RuleList { get; set; }
                public class GetBuildRiskDefineRuleConfigResponseBodyDataRuleTreeRuleList : TeaModel {
                    /// <summary>
                    /// <para>The check item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>add</para>
                    /// </summary>
                    [NameInMap("RuleKey")]
                    [Validation(Required=false)]
                    public string RuleKey { get; set; }

                    /// <summary>
                    /// <para>The name of the check item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>used ADD</para>
                    /// </summary>
                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the check item is selected. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
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
        /// <para>The returned message.</para>
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
        /// <para>69BFFCDE-37D6-5A49-A8BC-BB03AC83****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
