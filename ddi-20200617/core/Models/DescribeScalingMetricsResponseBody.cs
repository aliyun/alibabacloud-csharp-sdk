// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class DescribeScalingMetricsResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MetricList")]
        [Validation(Required=false)]
        public List<DescribeScalingMetricsResponseBodyMetricList> MetricList { get; set; }
        public class DescribeScalingMetricsResponseBodyMetricList : TeaModel {
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("MinValue")]
            [Validation(Required=false)]
            public long? MinValue { get; set; }

            [NameInMap("MaxValue")]
            [Validation(Required=false)]
            public long? MaxValue { get; set; }

        }

    }

}
