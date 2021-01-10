// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DescribeDSTTimeSeriesMetricsRequest : TeaModel {
        [NameInMap("Aggregator")]
        [Validation(Required=false)]
        public string Aggregator { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public List<DescribeDSTTimeSeriesMetricsRequestMetrics> Metrics { get; set; }
        public class DescribeDSTTimeSeriesMetricsRequestMetrics : TeaModel {
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeDSTTimeSeriesMetricsRequestTags> Tags { get; set; }
        public class DescribeDSTTimeSeriesMetricsRequestTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
