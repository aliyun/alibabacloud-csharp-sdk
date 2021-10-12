// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeInstancePerformanceResponseBody : TeaModel {
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
        public DescribeInstancePerformanceResponseBodyData Data { get; set; }
        public class DescribeInstancePerformanceResponseBodyData : TeaModel {
            [NameInMap("PerformanceItems")]
            [Validation(Required=false)]
            public List<DescribeInstancePerformanceResponseBodyDataPerformanceItems> PerformanceItems { get; set; }
            public class DescribeInstancePerformanceResponseBodyDataPerformanceItems : TeaModel {
                public string MetricName { get; set; }
                public string Measurement { get; set; }
                public List<DescribeInstancePerformanceResponseBodyDataPerformanceItemsPoints> Points { get; set; }
                public class DescribeInstancePerformanceResponseBodyDataPerformanceItemsPoints : TeaModel {
                    public string Value { get; set; }
                    public long? Timestamp { get; set; }
                }
            }
        };

    }

}
