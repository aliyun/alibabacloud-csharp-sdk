// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceSupportMaxPerformanceResponseBody : TeaModel {
        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("Performances")]
        [Validation(Required=false)]
        public DescribeDBInstanceSupportMaxPerformanceResponseBodyPerformances Performances { get; set; }
        public class DescribeDBInstanceSupportMaxPerformanceResponseBodyPerformances : TeaModel {
            [NameInMap("Performance")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceSupportMaxPerformanceResponseBodyPerformancesPerformance> Performance { get; set; }
            public class DescribeDBInstanceSupportMaxPerformanceResponseBodyPerformancesPerformance : TeaModel {
                /// <summary>
                /// The performance bottleneck type.
                /// </summary>
                [NameInMap("Bottleneck")]
                [Validation(Required=false)]
                public string Bottleneck { get; set; }

                /// <summary>
                /// The name of the performance metric.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The unit of the performance metric.
                /// </summary>
                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                /// <summary>
                /// The value of the performance metric.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
