// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CapacityPlanRequest : TeaModel {
        [NameInMap("complexQueryAvailable")]
        [Validation(Required=false)]
        public bool? ComplexQueryAvailable { get; set; }

        [NameInMap("dataInfo")]
        [Validation(Required=false)]
        public List<CapacityPlanRequestDataInfo> DataInfo { get; set; }
        public class CapacityPlanRequestDataInfo : TeaModel {
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        [NameInMap("metric")]
        [Validation(Required=false)]
        public List<CapacityPlanRequestMetric> Metric { get; set; }
        public class CapacityPlanRequestMetric : TeaModel {
            [NameInMap("averageQps")]
            [Validation(Required=false)]
            public int? AverageQps { get; set; }

            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("concurrent")]
            [Validation(Required=false)]
            public long? Concurrent { get; set; }

            [NameInMap("peakQps")]
            [Validation(Required=false)]
            public int? PeakQps { get; set; }

            [NameInMap("responseTime")]
            [Validation(Required=false)]
            public int? ResponseTime { get; set; }

            [NameInMap("throughput")]
            [Validation(Required=false)]
            public long? Throughput { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("usageScenario")]
        [Validation(Required=false)]
        public string UsageScenario { get; set; }

    }

}
