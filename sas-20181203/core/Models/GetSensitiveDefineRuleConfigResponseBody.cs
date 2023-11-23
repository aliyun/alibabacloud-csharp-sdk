// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetSensitiveDefineRuleConfigResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSensitiveDefineRuleConfigResponseBodyData Data { get; set; }
        public class GetSensitiveDefineRuleConfigResponseBodyData : TeaModel {
            /// <summary>
            /// The custom configuration ID.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The total number of check rules.
            /// </summary>
            [NameInMap("RuleCount")]
            [Validation(Required=false)]
            public int? RuleCount { get; set; }

            /// <summary>
            /// The tree of the check rules.
            /// </summary>
            [NameInMap("RuleTree")]
            [Validation(Required=false)]
            public List<GetSensitiveDefineRuleConfigResponseBodyDataRuleTree> RuleTree { get; set; }
            public class GetSensitiveDefineRuleConfigResponseBodyDataRuleTree : TeaModel {
                /// <summary>
                /// The category keyword of the check rule.
                /// </summary>
                [NameInMap("ClassKey")]
                [Validation(Required=false)]
                public string ClassKey { get; set; }

                /// <summary>
                /// The category name of the check rule.
                /// </summary>
                [NameInMap("ClassName")]
                [Validation(Required=false)]
                public string ClassName { get; set; }

                /// <summary>
                /// The list of check rules.
                /// </summary>
                [NameInMap("RuleList")]
                [Validation(Required=false)]
                public List<GetSensitiveDefineRuleConfigResponseBodyDataRuleTreeRuleList> RuleList { get; set; }
                public class GetSensitiveDefineRuleConfigResponseBodyDataRuleTreeRuleList : TeaModel {
                    /// <summary>
                    /// The keyword of the check rule.
                    /// </summary>
                    [NameInMap("RuleKey")]
                    [Validation(Required=false)]
                    public string RuleKey { get; set; }

                    /// <summary>
                    /// The name of the check rule.
                    /// </summary>
                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    /// <summary>
                    /// Indicates whether the check rule is selected. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false**
                    /// </summary>
                    [NameInMap("Selected")]
                    [Validation(Required=false)]
                    public bool? Selected { get; set; }

                }

            }

            /// <summary>
            /// The number of selected check rules.
            /// </summary>
            [NameInMap("SelectedCount")]
            [Validation(Required=false)]
            public int? SelectedCount { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
