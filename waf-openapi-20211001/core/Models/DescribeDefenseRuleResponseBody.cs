// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseRuleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Rule")]
        [Validation(Required=false)]
        public DescribeDefenseRuleResponseBodyRule Rule { get; set; }
        public class DescribeDefenseRuleResponseBodyRule : TeaModel {
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            [NameInMap("DefenseOrigin")]
            [Validation(Required=false)]
            public string DefenseOrigin { get; set; }

            [NameInMap("DefenseScene")]
            [Validation(Required=false)]
            public string DefenseScene { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

        }

    }

}
