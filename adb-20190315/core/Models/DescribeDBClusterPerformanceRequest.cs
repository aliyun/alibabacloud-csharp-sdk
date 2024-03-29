// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBClusterPerformanceRequest : TeaModel {
        /// <summary>
        /// The ID of the AnalyticDB for MySQL cluster.
        /// 
        /// >  You can call the [DescribeDBClusters](~~129857~~) operation to query the IDs of all AnalyticDB for MySQL clusters within a region.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The end time of the query. Specify the time in the ISO 8601 standard in the *yyyy-MM-ddTHH:mmZ* format. The time must be in UTC.
        /// 
        /// > The end time must be later than the start time. The maximum time range that can be specified is two days.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The performance metrics to be queried. Separate multiple values with commas (,). Valid values:
        /// 
        /// *   CPU
        /// 
        ///     *   **AnalyticDB_CPU**: the average CPU utilization.
        /// 
        /// *   Connections
        /// 
        ///     *   **AnalyticDB_Connections**: the number of database connections.
        /// 
        /// *   Writes
        /// 
        ///     *   **AnalyticDB_TPS**: the write transactions per second (TPS).
        ///     *   **AnalyticDB_InsertRT**: the write response time.
        ///     *   **AnalyticDB_InsertBytes**: the write throughput.
        /// 
        /// *   Updates
        /// 
        ///     *   **AnalyticDB_UpdateRT**: the update response time.
        /// 
        /// *   Deletion
        /// 
        ///     *   **AnalyticDB_DeleteRT**: the delete response time.
        /// 
        /// *   Queries
        /// 
        ///     *   **AnalyticDB_QPS**: the queries per second (QPS).
        ///     *   **AnalyticDB_QueryRT**: the query response time.
        ///     *   **AnalyticDB_QueryWaitTime**: the query wait time.
        /// 
        /// *   Disks
        /// 
        ///     *   **AnalyticDB_IO**: the disk I/O throughput.
        ///     *   **AnalyticDB_IO_UTIL**: the I/O utilization.
        ///     *   **AnalyticDB_IO_WAIT**: the I/O wait time.
        ///     *   **AnalyticDB_IOPS**: the disk input/output operations per second (IOPS).
        ///     *   **AnalyticDB_DiskUsage**: the disk space that is used.
        ///     *   **AnalyticDB_HotDataDiskUsage**: the disk space that is used by hot data.
        ///     *   **AnalyticDB_ColdDataDiskUsage**: the disk space that is used by cold data.
        /// 
        /// >  If you leave this parameter empty, the values of all the preceding performance metrics are returned.
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [NameInMap("ResourcePools")]
        [Validation(Required=false)]
        public string ResourcePools { get; set; }

        /// <summary>
        /// The start time of the query. Specify the time in the ISO 8601 standard in the *yyyy-MM-ddTHH:mmZ* format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
