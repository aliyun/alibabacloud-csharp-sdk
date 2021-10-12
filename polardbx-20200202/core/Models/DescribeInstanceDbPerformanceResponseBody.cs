// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeInstanceDbPerformanceResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeInstanceDbPerformanceResponseBodyData Data { get; set; }
        public class DescribeInstanceDbPerformanceResponseBodyData : TeaModel {
            [NameInMap("PerformanceItems")]
            [Validation(Required=false)]
            public List<DescribeInstanceDbPerformanceResponseBodyDataPerformanceItems> PerformanceItems { get; set; }
            public class DescribeInstanceDbPerformanceResponseBodyDataPerformanceItems : TeaModel {
                public string MetricName { get; set; }
                public string Measurement { get; set; }
                public List<DescribeInstanceDbPerformanceResponseBodyDataPerformanceItemsPoints> Points { get; set; }
                public class DescribeInstanceDbPerformanceResponseBodyDataPerformanceItemsPoints : TeaModel {
                    public string Value { get; set; }
                    public long? Timestamp { get; set; }
                }
            }
        };

    }

}
