// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeHealthChecksResponseBody : TeaModel {
        [NameInMap("HealthChecks")]
        [Validation(Required=false)]
        public DescribeHealthChecksResponseBodyHealthChecks HealthChecks { get; set; }
        public class DescribeHealthChecksResponseBodyHealthChecks : TeaModel {
            [NameInMap("HealthCheck")]
            [Validation(Required=false)]
            public List<DescribeHealthChecksResponseBodyHealthChecksHealthCheck> HealthCheck { get; set; }
            public class DescribeHealthChecksResponseBodyHealthChecksHealthCheck : TeaModel {
                public string Description { get; set; }
                public string DstIpAddr { get; set; }
                public int? DstPort { get; set; }
                public int? FailCountThreshold { get; set; }
                public string HcInstanceId { get; set; }
                public string Name { get; set; }
                public int? ProbeCount { get; set; }
                public int? ProbeInterval { get; set; }
                public int? ProbeTimeout { get; set; }
                public int? RelationCount { get; set; }
                public int? RttFailThreshold { get; set; }
                public int? RttThreshold { get; set; }
                public string SmartAGId { get; set; }
                public string SrcIpAddr { get; set; }
                public int? SrcPort { get; set; }
                public string Status { get; set; }
                public string Type { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
