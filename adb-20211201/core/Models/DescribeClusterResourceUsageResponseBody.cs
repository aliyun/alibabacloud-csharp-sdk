// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeClusterResourceUsageResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The queried resource usage.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeClusterResourceUsageResponseBodyData Data { get; set; }
        public class DescribeClusterResourceUsageResponseBodyData : TeaModel {
            /// <summary>
            /// The AnalyticDB compute unit (ACU) usage of the cluster.
            /// </summary>
            [NameInMap("AcuInfo")]
            [Validation(Required=false)]
            public List<DescribeClusterResourceUsageResponseBodyDataAcuInfo> AcuInfo { get; set; }
            public class DescribeClusterResourceUsageResponseBodyDataAcuInfo : TeaModel {
                /// <summary>
                /// The resource usage metric. Valid values:
                /// 
                /// *   `TotalAcuNumber`: the total number of ACUs.
                /// *   `ReservedAcuNumber`: the number of ACUs for the reserved resources.
                /// *   `ReservedAcuUsageNumber`: the number of ACUs for the reserved resources that are used.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The values of the metric at specific points in time.
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// The end time of the query. The time follows the ISO 8601 standard in the *yyyy-MM-ddTHH:mm:ssZ* format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The start time of the query. The time follows the ISO 8601 standard in the *yyyy-MM-ddTHH:mm:ssZ* format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
