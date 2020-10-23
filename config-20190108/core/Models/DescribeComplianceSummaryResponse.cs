// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class DescribeComplianceSummaryResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ComplianceSummary")]
        [Validation(Required=true)]
        public DescribeComplianceSummaryResponseComplianceSummary ComplianceSummary { get; set; }
        public class DescribeComplianceSummaryResponseComplianceSummary : TeaModel {
            [NameInMap("ComplianceSummaryByConfigRule")]
            [Validation(Required=true)]
            public DescribeComplianceSummaryResponseComplianceSummaryComplianceSummaryByConfigRule ComplianceSummaryByConfigRule { get; set; }
            public class DescribeComplianceSummaryResponseComplianceSummaryComplianceSummaryByConfigRule : TeaModel {
                [NameInMap("ComplianceSummaryTimestamp")]
                [Validation(Required=true)]
                public long ComplianceSummaryTimestamp { get; set; }

                [NameInMap("CompliantCount")]
                [Validation(Required=true)]
                public int? CompliantCount { get; set; }

                [NameInMap("NonCompliantCount")]
                [Validation(Required=true)]
                public int? NonCompliantCount { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=true)]
                public long TotalCount { get; set; }

            }
            [NameInMap("ComplianceSummaryByResource")]
            [Validation(Required=true)]
            public DescribeComplianceSummaryResponseComplianceSummaryComplianceSummaryByResource ComplianceSummaryByResource { get; set; }
            public class DescribeComplianceSummaryResponseComplianceSummaryComplianceSummaryByResource : TeaModel {
                [NameInMap("ComplianceSummaryTimestamp")]
                [Validation(Required=true)]
                public long ComplianceSummaryTimestamp { get; set; }

                [NameInMap("CompliantCount")]
                [Validation(Required=true)]
                public int? CompliantCount { get; set; }

                [NameInMap("NonCompliantCount")]
                [Validation(Required=true)]
                public int? NonCompliantCount { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=true)]
                public long TotalCount { get; set; }

            }
        };

    }

}
