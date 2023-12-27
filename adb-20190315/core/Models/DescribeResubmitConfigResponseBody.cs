// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeResubmitConfigResponseBody : TeaModel {
        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Warehouse Edition (V3.0) cluster.
        /// 
        /// >  You can call the [DescribeDBClusters](~~129857~~) operation to query the IDs of all AnalyticDB for MySQL Data Warehouse Edition (V3.0) clusters within a region.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The job resubmission rules.
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<DescribeResubmitConfigResponseBodyRules> Rules { get; set; }
        public class DescribeResubmitConfigResponseBodyRules : TeaModel {
            /// <summary>
            /// Indicates whether out-of-memory (OOM) check is configured.
            /// </summary>
            [NameInMap("ExceedMemoryException")]
            [Validation(Required=false)]
            public bool? ExceedMemoryException { get; set; }

            /// <summary>
            /// The name of the source resource group.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The peak memory usage.
            /// </summary>
            [NameInMap("PeakMemory")]
            [Validation(Required=false)]
            public string PeakMemory { get; set; }

            /// <summary>
            /// The duration of the SQL statement. Unit: milliseconds.
            /// </summary>
            [NameInMap("QueryTime")]
            [Validation(Required=false)]
            public string QueryTime { get; set; }

            /// <summary>
            /// The name of the destination resource group.
            /// </summary>
            [NameInMap("TargetGroupName")]
            [Validation(Required=false)]
            public string TargetGroupName { get; set; }

        }

    }

}
