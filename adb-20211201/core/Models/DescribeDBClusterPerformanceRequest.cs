// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDBClusterPerformanceRequest : TeaModel {
        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
        /// 
        /// > You can call the [DescribeDBClusters](~~~612397~~~) operation to query the IDs of all AnalyticDB for MySQL Data Lakehouse Edition (V3.0) clusters within a region.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the ISO 8601 standard in the *yyyy-MM-ddTHH:mmZ* format. The time must be in UTC.
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
        ///     *   **AnalyticDB_CPU_Usage_Percentage**: the average CPU utilization.
        /// 
        /// *   Connections
        /// 
        ///     *   **AnalyticDB_Instance_Connection_Count**: the number of database connections.
        /// 
        /// *   Writes
        /// 
        ///     *   **AnalyticDB_TPS**: the write transactions per second (TPS).
        ///     *   **AnalyticDB_InsertRT**: the write response time.
        ///     *   **AnalyticDB_InsertBytes**: the write throughput.
        /// 
        /// *   Queries
        /// 
        ///     *   **AnalyticDB_QPS**: the queries per second (QPS).
        ///     *   **AnalyticDB_QueryRT**: the query response time.
        ///     *   **AnalyticDB_QueryWaitTime**: the query wait time.
        /// 
        /// *   Disks
        /// 
        ///     *   **AnalyticDB_Disk_IO_Avg_Usage_Percentage**: the average I/O utilization.
        ///     *   **AnalyticDB_Disk_IO_Avg_Waiting_Time**: the average I/O wait time.
        ///     *   **AnalyticDB_IO_Throughput**: the disk throughput.
        ///     *   **AnalyticDB_IOPS**: the disk IOPS.
        ///     *   **AnalyticDB_Disk_Usage**: the disk space that is used.
        ///     *   **AnalyticDB_Disk_Usage_Percentage**: the disk usage.
        ///     *   **AnalyticDB_Hot_Data_Usage**: the disk space that is used by hot data.
        ///     *   **AnalyticDB_Cold_Data_Usage**: the disk space that is used by code data.
        /// 
        /// >  This parameter must be specified.
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// 
        /// > You can call the [DescribeRegions](~~612393~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource group ID.
        /// </summary>
        [NameInMap("ResourcePools")]
        [Validation(Required=false)]
        public string ResourcePools { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the *yyyy-MM-ddTHH:mmZ* format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
