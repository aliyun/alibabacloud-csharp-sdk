// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeDedicatedInstanceMetricResponseBody : TeaModel {
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public DescribeDedicatedInstanceMetricResponseBodyMetrics Metrics { get; set; }
        public class DescribeDedicatedInstanceMetricResponseBodyMetrics : TeaModel {
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public List<DescribeDedicatedInstanceMetricResponseBodyMetricsMetrics> Metrics { get; set; }
            public class DescribeDedicatedInstanceMetricResponseBodyMetricsMetrics : TeaModel {
                public string EndDate { get; set; }
                public float? MaxMemUsage { get; set; }
                public string DedicatedInstanceId { get; set; }
                public string StartDate { get; set; }
                public float? DiskUsage { get; set; }
                public float? AvgMemUsage { get; set; }
                public int? MaxIOPS { get; set; }
                public float? Memory { get; set; }
                public float? AvgCpuUsage { get; set; }
                public int? AvgIOPS { get; set; }
                public string Role { get; set; }
                public float? MaxCpuUsage { get; set; }
                public DescribeDedicatedInstanceMetricResponseBodyMetricsMetricsRisks Risks { get; set; }
                public class DescribeDedicatedInstanceMetricResponseBodyMetricsMetricsRisks : TeaModel {
                    [NameInMap("Risks")]
                    [Validation(Required=false)]
                    public List<string> Risks { get; set; }

                }
            }
        };

    }

}
