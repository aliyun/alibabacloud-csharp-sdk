// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBClusterPerformanceResponseBody : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The end time of the query. The time follows the ISO 8601 standard in the `YYYY-MM-DDTHH:mmZ` format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// Details of the performance metrics of the instance.
        /// </summary>
        [NameInMap("PerformanceKeys")]
        [Validation(Required=false)]
        public List<DescribeDBClusterPerformanceResponseBodyPerformanceKeys> PerformanceKeys { get; set; }
        public class DescribeDBClusterPerformanceResponseBodyPerformanceKeys : TeaModel {
            /// <summary>
            /// The name of the performance metric. For more information, see [Performance parameters](~~86943~~).
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Details of the performance metric of a node.
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public List<DescribeDBClusterPerformanceResponseBodyPerformanceKeysSeries> Series { get; set; }
            public class DescribeDBClusterPerformanceResponseBodyPerformanceKeysSeries : TeaModel {
                /// <summary>
                /// The name of the compute node or compute group.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The role of the node. Valid values:
                /// 
                /// *   **master**: primary coordinator node
                /// *   **standby**: standby coordinator node
                /// *   **segment**: compute node
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// The value of the performance metric collected at a point in time.
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<DescribeDBClusterPerformanceResponseBodyPerformanceKeysSeriesValues> Values { get; set; }
                public class DescribeDBClusterPerformanceResponseBodyPerformanceKeysSeriesValues : TeaModel {
                    /// <summary>
                    /// The value of the performance metric and the time when the metric value was collected.
                    /// </summary>
                    [NameInMap("Point")]
                    [Validation(Required=false)]
                    public List<string> Point { get; set; }

                }

            }

            /// <summary>
            /// The unit of the performance metric.
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The start time of the query. The time follows the ISO 8601 standard in the `YYYY-MM-DDTHH:mmZ` format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
