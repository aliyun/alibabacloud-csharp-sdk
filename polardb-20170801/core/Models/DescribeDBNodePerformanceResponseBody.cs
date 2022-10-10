// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBNodePerformanceResponseBody : TeaModel {
        [NameInMap("DBNodeId")]
        [Validation(Required=false)]
        public string DBNodeId { get; set; }

        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

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
                [NameInMap("Measurement")]
                [Validation(Required=false)]
                public string Measurement { get; set; }

                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                [NameInMap("Points")]
                [Validation(Required=false)]
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

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
