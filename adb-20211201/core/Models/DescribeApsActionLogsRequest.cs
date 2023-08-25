// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeApsActionLogsRequest : TeaModel {
        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
        /// 
        /// >  You can call the [DescribeDBClusters](~~454250~~) operation to query the ID of the cluster.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The end time of the logs to be queried. Specify the time in the ISO 8601 standard in the **yyyy-MM-ddTHH:mmZ** format. The time must be in UTC.
        /// 
        /// >  The end time must be later than the start time. Their interval cannot be longer than 30 days.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The keyword that you want to use for fuzzy match in the query.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return. The value must be an integer that is greater than 0. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 30. Valid values:
        /// 
        /// *   **30**
        /// *   **50**
        /// *   **100**
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// 
        /// >  You can call the [DescribeRegions](~~454314~~) operation to query the most recent region list.
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
        /// The task phase during which the logs to be queried are generated. Valid values:
        /// 
        /// *   **StructureMigrate**: schema migration.
        /// *   **FullDataSync**: full data synchronization.
        /// *   **IncrementalSync**: incremental data synchronization.
        /// 
        /// >  If you do not specify this parameter, logs of all the task phases are queried.
        /// </summary>
        [NameInMap("Stage")]
        [Validation(Required=false)]
        public string Stage { get; set; }

        /// <summary>
        /// The start time of the logs to be queried. Specify the time in the ISO 8601 standard in the **yyyy-MM-ddTHH:mm:ssZ** format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The type of the log. Separate multiple log types with commas (,). Valid values:
        /// 
        /// *   **INFO**
        /// *   **WARN**
        /// *   **ERROR**
        /// 
        /// >  If you do not specify this parameter, logs of all types are queried.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// The ID of the real-time data ingestion task.
        /// </summary>
        [NameInMap("WorkloadId")]
        [Validation(Required=false)]
        public string WorkloadId { get; set; }

    }

}
