// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeInstanceSummaryResponseBody : TeaModel {
        [NameInMap("InstanceSummary")]
        [Validation(Required=false)]
        public DescribeInstanceSummaryResponseBodyInstanceSummary InstanceSummary { get; set; }
        public class DescribeInstanceSummaryResponseBodyInstanceSummary : TeaModel {
            [NameInMap("AlarmSummaryCount")]
            [Validation(Required=false)]
            public long? AlarmSummaryCount { get; set; }

            [NameInMap("AnomalySQLCount")]
            [Validation(Required=false)]
            public long? AnomalySQLCount { get; set; }

            [NameInMap("ClusterInstancesCount")]
            [Validation(Required=false)]
            public long? ClusterInstancesCount { get; set; }

            [NameInMap("ExpiredInstancesCount")]
            [Validation(Required=false)]
            public long? ExpiredInstancesCount { get; set; }

            [NameInMap("ImmediatelyExpiredInstancesCount")]
            [Validation(Required=false)]
            public long? ImmediatelyExpiredInstancesCount { get; set; }

            [NameInMap("InsufficientDiskInstancesCount")]
            [Validation(Required=false)]
            public long? InsufficientDiskInstancesCount { get; set; }

            [NameInMap("OverLoadInstancesCount")]
            [Validation(Required=false)]
            public long? OverLoadInstancesCount { get; set; }

            [NameInMap("RegionalInstanceSummaryList")]
            [Validation(Required=false)]
            public List<DescribeInstanceSummaryResponseBodyInstanceSummaryRegionalInstanceSummaryList> RegionalInstanceSummaryList { get; set; }
            public class DescribeInstanceSummaryResponseBodyInstanceSummaryRegionalInstanceSummaryList : TeaModel {
                [NameInMap("ExpiredInstancesCount")]
                [Validation(Required=false)]
                public string ExpiredInstancesCount { get; set; }

                [NameInMap("ImmediatelyExpiredInstancesCount")]
                [Validation(Required=false)]
                public string ImmediatelyExpiredInstancesCount { get; set; }

                [NameInMap("RecentCreatedInstancesCount")]
                [Validation(Required=false)]
                public string RecentCreatedInstancesCount { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("RunningInstancesCount")]
                [Validation(Required=false)]
                public string RunningInstancesCount { get; set; }

                [NameInMap("TotalInstancesCount")]
                [Validation(Required=false)]
                public string TotalInstancesCount { get; set; }

            }

            [NameInMap("RunningInstancesCount")]
            [Validation(Required=false)]
            public long? RunningInstancesCount { get; set; }

            [NameInMap("TenantInstancesCount")]
            [Validation(Required=false)]
            public long? TenantInstancesCount { get; set; }

            [NameInMap("TotalInstancesCount")]
            [Validation(Required=false)]
            public long? TotalInstancesCount { get; set; }

            [NameInMap("TotalOmsInstancesCount")]
            [Validation(Required=false)]
            public long? TotalOmsInstancesCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
