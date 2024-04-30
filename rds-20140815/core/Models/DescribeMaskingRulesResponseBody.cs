// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeMaskingRulesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeMaskingRulesResponseBodyData Data { get; set; }
        public class DescribeMaskingRulesResponseBodyData : TeaModel {
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeMaskingRulesResponseBodyDataRules> Rules { get; set; }
            public class DescribeMaskingRulesResponseBodyDataRules : TeaModel {
                [NameInMap("DefaultAlgo")]
                [Validation(Required=false)]
                public string DefaultAlgo { get; set; }

                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public string Enabled { get; set; }

                [NameInMap("MaskingAlgo")]
                [Validation(Required=false)]
                public string MaskingAlgo { get; set; }

                [NameInMap("RuleConfig")]
                [Validation(Required=false)]
                public DescribeMaskingRulesResponseBodyDataRulesRuleConfig RuleConfig { get; set; }
                public class DescribeMaskingRulesResponseBodyDataRulesRuleConfig : TeaModel {
                    [NameInMap("Columns")]
                    [Validation(Required=false)]
                    public List<string> Columns { get; set; }

                    [NameInMap("Databases")]
                    [Validation(Required=false)]
                    public List<string> Databases { get; set; }

                    [NameInMap("Tables")]
                    [Validation(Required=false)]
                    public List<string> Tables { get; set; }

                }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
