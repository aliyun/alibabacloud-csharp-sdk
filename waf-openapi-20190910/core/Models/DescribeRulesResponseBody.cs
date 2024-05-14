// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20190910.Models
{
    public class DescribeRulesResponseBody : TeaModel {
        [NameInMap("IsSubscribe")]
        [Validation(Required=false)]
        public long? IsSubscribe { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleGroupName")]
        [Validation(Required=false)]
        public string RuleGroupName { get; set; }

        [NameInMap("RuleGroupTemplateId")]
        [Validation(Required=false)]
        public string RuleGroupTemplateId { get; set; }

        [NameInMap("RuleGroupTemplateName")]
        [Validation(Required=false)]
        public string RuleGroupTemplateName { get; set; }

        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<DescribeRulesResponseBodyRules> Rules { get; set; }
        public class DescribeRulesResponseBodyRules : TeaModel {
            [NameInMap("ApplicationType")]
            [Validation(Required=false)]
            public int? ApplicationType { get; set; }

            /// <summary>
            /// CVE ID。
            /// </summary>
            [NameInMap("CveId")]
            [Validation(Required=false)]
            public string CveId { get; set; }

            [NameInMap("CveUrl")]
            [Validation(Required=false)]
            public string CveUrl { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ProtectionType")]
            [Validation(Required=false)]
            public int? ProtectionType { get; set; }

            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
