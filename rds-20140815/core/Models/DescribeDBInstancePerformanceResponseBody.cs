// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstancePerformanceResponseBody : TeaModel {
        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The end time of the query. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm*Z format. The time must be in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The database engine of the instance.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// An array that consists of performance metrics.
        /// </summary>
        [NameInMap("PerformanceKeys")]
        [Validation(Required=false)]
        public DescribeDBInstancePerformanceResponseBodyPerformanceKeys PerformanceKeys { get; set; }
        public class DescribeDBInstancePerformanceResponseBodyPerformanceKeys : TeaModel {
            [NameInMap("PerformanceKey")]
            [Validation(Required=false)]
            public List<DescribeDBInstancePerformanceResponseBodyPerformanceKeysPerformanceKey> PerformanceKey { get; set; }
            public class DescribeDBInstancePerformanceResponseBodyPerformanceKeysPerformanceKey : TeaModel {
                /// <summary>
                /// The name of the performance metric.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The unit of the performance metrics.
                /// </summary>
                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                /// <summary>
                /// The format in which the value of the performance metric is returned.
                /// 
                /// >  If a performance metric value consists of multiple fields, the values are separated with ampersands (&). Example: com_delete\&com_insert\&com_insert_select\&com_replace.
                /// </summary>
                [NameInMap("ValueFormat")]
                [Validation(Required=false)]
                public string ValueFormat { get; set; }

                /// <summary>
                /// The performance metric values.
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public DescribeDBInstancePerformanceResponseBodyPerformanceKeysPerformanceKeyValues Values { get; set; }
                public class DescribeDBInstancePerformanceResponseBodyPerformanceKeysPerformanceKeyValues : TeaModel {
                    [NameInMap("PerformanceValue")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstancePerformanceResponseBodyPerformanceKeysPerformanceKeyValuesPerformanceValue> PerformanceValue { get; set; }
                    public class DescribeDBInstancePerformanceResponseBodyPerformanceKeysPerformanceKeyValuesPerformanceValue : TeaModel {
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
        /// The start time of the query. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm*Z format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
