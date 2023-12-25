// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeDBClusterPerformanceRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time must be in UTC.
        /// 
        /// >  The end time must be later than the start time. The interval cannot be more than 32 days.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The performance metrics that you want to query. Separate multiple performance metrics with commas (,). You can query up to five performance metrics at a time. You can query the following performance metrics:
        /// 
        /// >  The **Key** parameter is required.
        /// 
        /// *   **CPU**:
        /// 
        ///     *   **CPU_USAGE**: the CPU utilization
        /// 
        /// *   **Memory**:
        /// 
        ///     *   **MEM_USAGE**: the memory usage
        ///     *   **MEM_USAGE_SIZE**: the used memory. Unit: MB
        /// 
        /// *   **Disk**:
        /// 
        ///     *   **DISK_USAGE**: the disk usage
        ///     *   **DISK_USAGE_SIZE**: the size of the used disks. Unit: MB
        ///     *   **IOPS**: the disk Input/Output Operations per Second (IOPS)
        /// 
        /// *   **Connection**:
        /// 
        ///     *   **CONN_USAGE**: the database connection usage
        ///     *   **CONN_USAGE_COUNT**: the number of database connections used
        /// 
        /// *   **Write**:
        /// 
        ///     *   **TPS**: the number of rows written per second
        ///     *   **INSERT_SIZE**: the amount of data written per second. Unit: MB
        /// 
        /// *   **Query**:
        /// 
        ///     *   **QPS**: the queries per second
        ///     *   **AVG_SEEK**: the average number of random seek calls
        /// 
        /// *   **WAIT**:
        /// 
        ///     *   **ZK_WAIT**: the average ZooKeeper wait time. Unit: ms
        ///     *   **IO_WAIT**: the average I/O wait time. Unit: ms
        ///     *   **CPU_WAIT**: the average CPU wait time. Unit: ms
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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time must be in Coordinated Universal Time (UTC).
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
