// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBProxyPerformanceResponseBody : TeaModel {
        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// An internal parameter. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("DBProxyEngineType")]
        [Validation(Required=false)]
        public string DBProxyEngineType { get; set; }

        /// <summary>
        /// The end time of the query.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The performance list.
        /// </summary>
        [NameInMap("PerformanceKeys")]
        [Validation(Required=false)]
        public DescribeDBProxyPerformanceResponseBodyPerformanceKeys PerformanceKeys { get; set; }
        public class DescribeDBProxyPerformanceResponseBodyPerformanceKeys : TeaModel {
            [NameInMap("PerformanceKey")]
            [Validation(Required=false)]
            public List<DescribeDBProxyPerformanceResponseBodyPerformanceKeysPerformanceKey> PerformanceKey { get; set; }
            public class DescribeDBProxyPerformanceResponseBodyPerformanceKeysPerformanceKey : TeaModel {
                /// <summary>
                /// The performance parameter.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The format in which the value of the performance metric is returned.
                /// </summary>
                [NameInMap("ValueFormat")]
                [Validation(Required=false)]
                public string ValueFormat { get; set; }

                /// <summary>
                /// The performance metrics.
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public DescribeDBProxyPerformanceResponseBodyPerformanceKeysPerformanceKeyValues Values { get; set; }
                public class DescribeDBProxyPerformanceResponseBodyPerformanceKeysPerformanceKeyValues : TeaModel {
                    [NameInMap("PerformanceValue")]
                    [Validation(Required=false)]
                    public List<DescribeDBProxyPerformanceResponseBodyPerformanceKeysPerformanceKeyValuesPerformanceValue> PerformanceValue { get; set; }
                    public class DescribeDBProxyPerformanceResponseBodyPerformanceKeysPerformanceKeyValuesPerformanceValue : TeaModel {
                        /// <summary>
                        /// The date and time when the value of the performance metric was recorded. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                        /// </summary>
                        [NameInMap("Date")]
                        [Validation(Required=false)]
                        public string Date { get; set; }

                        /// <summary>
                        /// The value of the performance metric.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The start time of the query.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
