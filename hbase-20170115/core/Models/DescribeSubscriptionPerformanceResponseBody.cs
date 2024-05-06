// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20170115.Models
{
    public class DescribeSubscriptionPerformanceResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("PerformanceKeys")]
        [Validation(Required=false)]
        public DescribeSubscriptionPerformanceResponseBodyPerformanceKeys PerformanceKeys { get; set; }
        public class DescribeSubscriptionPerformanceResponseBodyPerformanceKeys : TeaModel {
            [NameInMap("PerformanceKey")]
            [Validation(Required=false)]
            public List<DescribeSubscriptionPerformanceResponseBodyPerformanceKeysPerformanceKey> PerformanceKey { get; set; }
            public class DescribeSubscriptionPerformanceResponseBodyPerformanceKeysPerformanceKey : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("PerformanceValues")]
                [Validation(Required=false)]
                public DescribeSubscriptionPerformanceResponseBodyPerformanceKeysPerformanceKeyPerformanceValues PerformanceValues { get; set; }
                public class DescribeSubscriptionPerformanceResponseBodyPerformanceKeysPerformanceKeyPerformanceValues : TeaModel {
                    [NameInMap("PerformanceValue")]
                    [Validation(Required=false)]
                    public List<DescribeSubscriptionPerformanceResponseBodyPerformanceKeysPerformanceKeyPerformanceValuesPerformanceValue> PerformanceValue { get; set; }
                    public class DescribeSubscriptionPerformanceResponseBodyPerformanceKeysPerformanceKeyPerformanceValuesPerformanceValue : TeaModel {
                        [NameInMap("Date")]
                        [Validation(Required=false)]
                        public string Date { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                [NameInMap("ValueFormat")]
                [Validation(Required=false)]
                public string ValueFormat { get; set; }

            }

        }

        [NameInMap("ReplicaId")]
        [Validation(Required=false)]
        public string ReplicaId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
