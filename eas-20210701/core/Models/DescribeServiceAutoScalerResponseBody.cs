// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeServiceAutoScalerResponseBody : TeaModel {
        [NameInMap("Behavior")]
        [Validation(Required=false)]
        public Dictionary<string, object> Behavior { get; set; }

        [NameInMap("CurrentMetrics")]
        [Validation(Required=false)]
        public List<DescribeServiceAutoScalerResponseBodyCurrentMetrics> CurrentMetrics { get; set; }
        public class DescribeServiceAutoScalerResponseBodyCurrentMetrics : TeaModel {
            [NameInMap("metricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            [NameInMap("service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public float? Value { get; set; }

        }

        [NameInMap("MaxReplica")]
        [Validation(Required=false)]
        public int? MaxReplica { get; set; }

        [NameInMap("MinReplica")]
        [Validation(Required=false)]
        public int? MinReplica { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScaleStrategies")]
        [Validation(Required=false)]
        public List<DescribeServiceAutoScalerResponseBodyScaleStrategies> ScaleStrategies { get; set; }
        public class DescribeServiceAutoScalerResponseBodyScaleStrategies : TeaModel {
            [NameInMap("metricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            [NameInMap("service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            [NameInMap("threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }

        }

        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

    }

}
