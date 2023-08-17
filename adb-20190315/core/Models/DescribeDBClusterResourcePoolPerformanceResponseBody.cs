// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBClusterResourcePoolPerformanceResponseBody : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The end of the time range for monitoring the resource group. The time follows the ISO 8601 standard in the *yyyy-MM-ddTHH:mm:ssZ* format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The queried monitoring information about the metrics.
        /// </summary>
        [NameInMap("Performances")]
        [Validation(Required=false)]
        public List<DescribeDBClusterResourcePoolPerformanceResponseBodyPerformances> Performances { get; set; }
        public class DescribeDBClusterResourcePoolPerformanceResponseBodyPerformances : TeaModel {
            /// <summary>
            /// The metric of the resource group.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The queried monitoring information about the resource groups.
            /// </summary>
            [NameInMap("ResourcePoolPerformances")]
            [Validation(Required=false)]
            public List<DescribeDBClusterResourcePoolPerformanceResponseBodyPerformancesResourcePoolPerformances> ResourcePoolPerformances { get; set; }
            public class DescribeDBClusterResourcePoolPerformanceResponseBodyPerformancesResourcePoolPerformances : TeaModel {
                /// <summary>
                /// The name of the resource group.
                /// </summary>
                [NameInMap("ResourcePoolName")]
                [Validation(Required=false)]
                public string ResourcePoolName { get; set; }

                /// <summary>
                /// The sequential monitoring information about the resource groups.
                /// </summary>
                [NameInMap("ResourcePoolSeries")]
                [Validation(Required=false)]
                public List<DescribeDBClusterResourcePoolPerformanceResponseBodyPerformancesResourcePoolPerformancesResourcePoolSeries> ResourcePoolSeries { get; set; }
                public class DescribeDBClusterResourcePoolPerformanceResponseBodyPerformancesResourcePoolPerformancesResourcePoolSeries : TeaModel {
                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

            }

            /// <summary>
            /// The unit of the metric value.
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The beginning of the time range for monitoring the resource group. The time follows the ISO 8601 standard in the *yyyy-MM-ddTHH:mm:ssZ* format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
