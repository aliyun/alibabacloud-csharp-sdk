// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class DescribeComplianceSummaryResponseBody : TeaModel {
        [NameInMap("ComplianceSummary")]
        [Validation(Required=false)]
        public DescribeComplianceSummaryResponseBodyComplianceSummary ComplianceSummary { get; set; }
        public class DescribeComplianceSummaryResponseBodyComplianceSummary : TeaModel {
            [NameInMap("ComplianceSummaryByConfigRule")]
            [Validation(Required=false)]
            public DescribeComplianceSummaryResponseBodyComplianceSummaryComplianceSummaryByConfigRule ComplianceSummaryByConfigRule { get; set; }
            public class DescribeComplianceSummaryResponseBodyComplianceSummaryComplianceSummaryByConfigRule : TeaModel {
                [NameInMap("ComplianceSummaryTimestamp")]
                [Validation(Required=false)]
                public long? ComplianceSummaryTimestamp { get; set; }

                [NameInMap("CompliantCount")]
                [Validation(Required=false)]
                public int? CompliantCount { get; set; }

                [NameInMap("NonCompliantCount")]
                [Validation(Required=false)]
                public int? NonCompliantCount { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }
            [NameInMap("ComplianceSummaryByResource")]
            [Validation(Required=false)]
            public DescribeComplianceSummaryResponseBodyComplianceSummaryComplianceSummaryByResource ComplianceSummaryByResource { get; set; }
            public class DescribeComplianceSummaryResponseBodyComplianceSummaryComplianceSummaryByResource : TeaModel {
                [NameInMap("ComplianceSummaryTimestamp")]
                [Validation(Required=false)]
                public long? ComplianceSummaryTimestamp { get; set; }

                [NameInMap("CompliantCount")]
                [Validation(Required=false)]
                public int? CompliantCount { get; set; }

                [NameInMap("NonCompliantCount")]
                [Validation(Required=false)]
                public int? NonCompliantCount { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
