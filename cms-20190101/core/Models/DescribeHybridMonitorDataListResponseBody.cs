// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeHybridMonitorDataListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("TimeSeries")]
        [Validation(Required=false)]
        public List<DescribeHybridMonitorDataListResponseBodyTimeSeries> TimeSeries { get; set; }
        public class DescribeHybridMonitorDataListResponseBodyTimeSeries : TeaModel {
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<DescribeHybridMonitorDataListResponseBodyTimeSeriesLabels> Labels { get; set; }
            public class DescribeHybridMonitorDataListResponseBodyTimeSeriesLabels : TeaModel {
                [NameInMap("K")]
                [Validation(Required=false)]
                public string K { get; set; }

                [NameInMap("V")]
                [Validation(Required=false)]
                public string V { get; set; }

            }

            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<DescribeHybridMonitorDataListResponseBodyTimeSeriesValues> Values { get; set; }
            public class DescribeHybridMonitorDataListResponseBodyTimeSeriesValues : TeaModel {
                [NameInMap("Ts")]
                [Validation(Required=false)]
                public string Ts { get; set; }

                [NameInMap("V")]
                [Validation(Required=false)]
                public string V { get; set; }

            }

        }

    }

}
