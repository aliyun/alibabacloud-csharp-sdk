// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class DescribeComplianceResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ComplianceResult")]
        [Validation(Required=true)]
        public DescribeComplianceResponseComplianceResult ComplianceResult { get; set; }
        public class DescribeComplianceResponseComplianceResult : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public long TotalCount { get; set; }
            [NameInMap("Compliances")]
            [Validation(Required=true)]
            public List<DescribeComplianceResponseComplianceResultCompliances> Compliances { get; set; }
            public class DescribeComplianceResponseComplianceResultCompliances : TeaModel {
                public string ComplianceType { get; set; }
                public int? Count { get; set; }
            }
        };

    }

}
