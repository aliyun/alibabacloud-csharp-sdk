// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeDedicatedHostMetricResponseBody : TeaModel {
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public DescribeDedicatedHostMetricResponseBodyMetrics Metrics { get; set; }
        public class DescribeDedicatedHostMetricResponseBodyMetrics : TeaModel {
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public List<DescribeDedicatedHostMetricResponseBodyMetricsMetrics> Metrics { get; set; }
            public class DescribeDedicatedHostMetricResponseBodyMetricsMetrics : TeaModel {
                public float? AvgMemUsage { get; set; }
                public string EndDate { get; set; }
                public int? AvgIops { get; set; }
                public float? MaxMemUsage { get; set; }
                public string StartDate { get; set; }
                public string DedicatedHostId { get; set; }
                public int? MaxIops { get; set; }
                public float? AvgCpuUsage { get; set; }
                public float? DiskUsage { get; set; }
                public float? MaxCpuUsage { get; set; }
                public DescribeDedicatedHostMetricResponseBodyMetricsMetricsRisks Risks { get; set; }
                public class DescribeDedicatedHostMetricResponseBodyMetricsMetricsRisks : TeaModel {
                    [NameInMap("Risks")]
                    [Validation(Required=false)]
                    public List<string> Risks { get; set; }

                }
            }
        };

    }

}
