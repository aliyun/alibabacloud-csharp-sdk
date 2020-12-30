// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribePbrRulesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PbrRules")]
        [Validation(Required=false)]
        public DescribePbrRulesResponseBodyPbrRules PbrRules { get; set; }
        public class DescribePbrRulesResponseBodyPbrRules : TeaModel {
            [NameInMap("PbrRule")]
            [Validation(Required=false)]
            public List<DescribePbrRulesResponseBodyPbrRulesPbrRule> PbrRule { get; set; }
            public class DescribePbrRulesResponseBodyPbrRulesPbrRule : TeaModel {
                public string DstCidr { get; set; }
                public string Description { get; set; }
                public string PbrRuleId { get; set; }
                public string Protocol { get; set; }
                public string DstPort { get; set; }
                public string SrcCidr { get; set; }
                public string Name { get; set; }
                public string SrcPort { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}
