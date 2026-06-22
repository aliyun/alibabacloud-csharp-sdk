// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetBuildRiskDefineRuleConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> indicates success. Any other value indicates failure. You can use this field to determine the cause of the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetBuildRiskDefineRuleConfigResponseBodyData Data { get; set; }
        public class GetBuildRiskDefineRuleConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the risk scan configuration for image build commands.</para>
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
            /// <para>The collection of check item selections.</para>
            /// </summary>
            [NameInMap("RuleTree")]
            [Validation(Required=false)]
            public List<GetBuildRiskDefineRuleConfigResponseBodyDataRuleTree> RuleTree { get; set; }
            public class GetBuildRiskDefineRuleConfigResponseBodyDataRuleTree : TeaModel {
                /// <summary>
                /// <para>The classification of the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>other</para>
                /// </summary>
                [NameInMap("ClassKey")]
                [Validation(Required=false)]
                public string ClassKey { get; set; }

                /// <summary>
                /// <para>The name of the check item classification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>other</para>
                /// </summary>
                [NameInMap("ClassName")]
                [Validation(Required=false)]
                public string ClassName { get; set; }

                /// <summary>
                /// <para>The collection of check items.</para>
                /// </summary>
                [NameInMap("RuleList")]
                [Validation(Required=false)]
                public List<GetBuildRiskDefineRuleConfigResponseBodyDataRuleTreeRuleList> RuleList { get; set; }
                public class GetBuildRiskDefineRuleConfigResponseBodyDataRuleTreeRuleList : TeaModel {
                    /// <summary>
                    /// <para>The check item key.</para>
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
        /// <para>The message returned for the API request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of this request, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69BFFCDE-37D6-5A49-A8BC-BB03AC83****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The API call is successful.</description></item>
        /// <item><description><b>false</b>: The API call failed.</description></item>
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
