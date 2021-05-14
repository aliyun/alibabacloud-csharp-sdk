// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeRdsPerformanceSummaryResponseBody : TeaModel {
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RdsPerformanceInfos")]
        [Validation(Required=false)]
        public List<DescribeRdsPerformanceSummaryResponseBodyRdsPerformanceInfos> RdsPerformanceInfos { get; set; }
        public class DescribeRdsPerformanceSummaryResponseBodyRdsPerformanceInfos : TeaModel {
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public float? Cpu { get; set; }

            [NameInMap("ActiveSessions")]
            [Validation(Required=false)]
            public int? ActiveSessions { get; set; }

            [NameInMap("TotalSessions")]
            [Validation(Required=false)]
            public int? TotalSessions { get; set; }

            [NameInMap("RdsId")]
            [Validation(Required=false)]
            public string RdsId { get; set; }

            [NameInMap("Iops")]
            [Validation(Required=false)]
            public float? Iops { get; set; }

            [NameInMap("SpaceUsage")]
            [Validation(Required=false)]
            public long? SpaceUsage { get; set; }

        }

    }

}
