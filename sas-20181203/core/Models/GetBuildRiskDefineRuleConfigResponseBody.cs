// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetBuildRiskDefineRuleConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetBuildRiskDefineRuleConfigResponseBodyData Data { get; set; }
        public class GetBuildRiskDefineRuleConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>273698***</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("RuleCount")]
            [Validation(Required=false)]
            public int? RuleCount { get; set; }

            [NameInMap("RuleTree")]
            [Validation(Required=false)]
            public List<GetBuildRiskDefineRuleConfigResponseBodyDataRuleTree> RuleTree { get; set; }
            public class GetBuildRiskDefineRuleConfigResponseBodyDataRuleTree : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>other</para>
                /// </summary>
                [NameInMap("ClassKey")]
                [Validation(Required=false)]
                public string ClassKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>other</para>
                /// </summary>
                [NameInMap("ClassName")]
                [Validation(Required=false)]
                public string ClassName { get; set; }

                [NameInMap("RuleList")]
                [Validation(Required=false)]
                public List<GetBuildRiskDefineRuleConfigResponseBodyDataRuleTreeRuleList> RuleList { get; set; }
                public class GetBuildRiskDefineRuleConfigResponseBodyDataRuleTreeRuleList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>add</para>
                    /// </summary>
                    [NameInMap("RuleKey")]
                    [Validation(Required=false)]
                    public string RuleKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>used ADD</para>
                    /// </summary>
                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Selected")]
                    [Validation(Required=false)]
                    public bool? Selected { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("SelectedCount")]
            [Validation(Required=false)]
            public int? SelectedCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>69BFFCDE-37D6-5A49-A8BC-BB03AC83****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
