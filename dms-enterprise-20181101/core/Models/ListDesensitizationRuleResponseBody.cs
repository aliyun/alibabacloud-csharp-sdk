// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDesensitizationRuleResponseBody : TeaModel {
        [NameInMap("DesensitizationRuleList")]
        [Validation(Required=false)]
        public List<ListDesensitizationRuleResponseBodyDesensitizationRuleList> DesensitizationRuleList { get; set; }
        public class ListDesensitizationRuleResponseBodyDesensitizationRuleList : TeaModel {
            [NameInMap("FuncParams")]
            [Validation(Required=false)]
            public string FuncParams { get; set; }

            [NameInMap("FuncSample")]
            [Validation(Required=false)]
            public string FuncSample { get; set; }

            [NameInMap("FunctionType")]
            [Validation(Required=false)]
            public string FunctionType { get; set; }

            [NameInMap("LastModifierId")]
            [Validation(Required=false)]
            public string LastModifierId { get; set; }

            [NameInMap("LastModifierName")]
            [Validation(Required=false)]
            public string LastModifierName { get; set; }

            [NameInMap("ReferenceCount")]
            [Validation(Required=false)]
            public int? ReferenceCount { get; set; }

            [NameInMap("RuleDesc")]
            [Validation(Required=false)]
            public string RuleDesc { get; set; }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public int? RuleId { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
