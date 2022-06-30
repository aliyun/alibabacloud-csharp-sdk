// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebPreciseAccessRuleResponseBody : TeaModel {
        [NameInMap("PreciseAccessConfigList")]
        [Validation(Required=false)]
        public List<DescribeWebPreciseAccessRuleResponseBodyPreciseAccessConfigList> PreciseAccessConfigList { get; set; }
        public class DescribeWebPreciseAccessRuleResponseBodyPreciseAccessConfigList : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<DescribeWebPreciseAccessRuleResponseBodyPreciseAccessConfigListRuleList> RuleList { get; set; }
            public class DescribeWebPreciseAccessRuleResponseBodyPreciseAccessConfigListRuleList : TeaModel {
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("ConditionList")]
                [Validation(Required=false)]
                public List<DescribeWebPreciseAccessRuleResponseBodyPreciseAccessConfigListRuleListConditionList> ConditionList { get; set; }
                public class DescribeWebPreciseAccessRuleResponseBodyPreciseAccessConfigListRuleListConditionList : TeaModel {
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("Field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    [NameInMap("HeaderName")]
                    [Validation(Required=false)]
                    public string HeaderName { get; set; }

                    [NameInMap("MatchMethod")]
                    [Validation(Required=false)]
                    public string MatchMethod { get; set; }

                }

                [NameInMap("Expires")]
                [Validation(Required=false)]
                public long? Expires { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
