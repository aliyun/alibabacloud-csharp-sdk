// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDBNodePerformanceResponseBody : TeaModel {
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("PerformanceKeys")]
        [Validation(Required=false)]
        public DescribeDBNodePerformanceResponseBodyPerformanceKeys PerformanceKeys { get; set; }
        public class DescribeDBNodePerformanceResponseBodyPerformanceKeys : TeaModel {
            [NameInMap("PerformanceItem")]
            [Validation(Required=false)]
            public List<DescribeDBNodePerformanceResponseBodyPerformanceKeysPerformanceItem> PerformanceItem { get; set; }
            public class DescribeDBNodePerformanceResponseBodyPerformanceKeysPerformanceItem : TeaModel {
                public string DBNodeId { get; set; }
                public string Measurement { get; set; }
                public string MetricName { get; set; }
                public DescribeDBNodePerformanceResponseBodyPerformanceKeysPerformanceItemPoints Points { get; set; }
                public class DescribeDBNodePerformanceResponseBodyPerformanceKeysPerformanceItemPoints : TeaModel {
                    [NameInMap("PerformanceItemValue")]
                    [Validation(Required=false)]
                    public List<DescribeDBNodePerformanceResponseBodyPerformanceKeysPerformanceItemPointsPerformanceItemValue> PerformanceItemValue { get; set; }
                    public class DescribeDBNodePerformanceResponseBodyPerformanceKeysPerformanceItemPointsPerformanceItemValue : TeaModel {
                        [NameInMap("Timestamp")]
                        [Validation(Required=false)]
                        public long? Timestamp { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
