// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDesensitizationRuleResponseBody : TeaModel {
        /// <summary>
        /// The list of masking rules.
        /// </summary>
        [NameInMap("DesensitizationRuleList")]
        [Validation(Required=false)]
        public List<ListDesensitizationRuleResponseBodyDesensitizationRuleList> DesensitizationRuleList { get; set; }
        public class ListDesensitizationRuleResponseBodyDesensitizationRuleList : TeaModel {
            /// <summary>
            /// The parameter.
            /// </summary>
            [NameInMap("FuncParams")]
            [Validation(Required=false)]
            public string FuncParams { get; set; }

            /// <summary>
            /// The example.
            /// </summary>
            [NameInMap("FuncSample")]
            [Validation(Required=false)]
            public string FuncSample { get; set; }

            /// <summary>
            /// The algorithm type.
            /// </summary>
            [NameInMap("FunctionType")]
            [Validation(Required=false)]
            public string FunctionType { get; set; }

            /// <summary>
            /// The ID of the user who last modified the masking rule.
            /// </summary>
            [NameInMap("LastModifierId")]
            [Validation(Required=false)]
            public string LastModifierId { get; set; }

            /// <summary>
            /// The name of the user who last modified the masking rule.
            /// </summary>
            [NameInMap("LastModifierName")]
            [Validation(Required=false)]
            public string LastModifierName { get; set; }

            /// <summary>
            /// The number of times that the masking was used.
            /// </summary>
            [NameInMap("ReferenceCount")]
            [Validation(Required=false)]
            public int? ReferenceCount { get; set; }

            /// <summary>
            /// The description of the rule.
            /// </summary>
            [NameInMap("RuleDesc")]
            [Validation(Required=false)]
            public string RuleDesc { get; set; }

            /// <summary>
            /// The ID of the masking rule.
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public int? RuleId { get; set; }

            /// <summary>
            /// The name of the masking rule.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The algorithm used for masking.
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

        }

        /// <summary>
        /// The error code returned if the request failed.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true: The request was successful.
        /// *   false: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of entries returned. By default, this parameter is not returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
