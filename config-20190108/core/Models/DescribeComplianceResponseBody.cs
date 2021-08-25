// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class DescribeComplianceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ComplianceResult")]
        [Validation(Required=false)]
        public DescribeComplianceResponseBodyComplianceResult ComplianceResult { get; set; }
        public class DescribeComplianceResponseBodyComplianceResult : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
            [NameInMap("Compliances")]
            [Validation(Required=false)]
            public List<DescribeComplianceResponseBodyComplianceResultCompliances> Compliances { get; set; }
            public class DescribeComplianceResponseBodyComplianceResultCompliances : TeaModel {
                public int? Count { get; set; }
                public string ComplianceType { get; set; }
            }
        };

    }

}
