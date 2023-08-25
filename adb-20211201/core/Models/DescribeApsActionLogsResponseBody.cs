// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeApsActionLogsResponseBody : TeaModel {
        /// <summary>
        /// Details of the logs.
        /// </summary>
        [NameInMap("ActionLogs")]
        [Validation(Required=false)]
        public List<DescribeApsActionLogsResponseBodyActionLogs> ActionLogs { get; set; }
        public class DescribeApsActionLogsResponseBodyActionLogs : TeaModel {
            /// <summary>
            /// The content of the log.
            /// </summary>
            [NameInMap("Context")]
            [Validation(Required=false)]
            public string Context { get; set; }

            /// <summary>
            /// The task phase during which the logs are generated. Valid values:
            /// 
            /// *   **StructureMigrate**: schema migration.
            /// *   **FullDataSync**: full data synchronization.
            /// *   **IncrementalSync**: incremental data synchronization.
            /// </summary>
            [NameInMap("Stage")]
            [Validation(Required=false)]
            public string Stage { get; set; }

            /// <summary>
            /// The type of the log. Multiple log types are separated by commas (,). Valid values:
            /// 
            /// *   **INFO**
            /// *   **WARN**
            /// *   **ERROR**
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The time when the log is generated. The time follows the ISO 8601 standard in the **yyyy-MM-ddTHH:mm:ssZ** format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

        }

        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        /// <summary>
        /// The ID of the real-time data ingestion task.
        /// </summary>
        [NameInMap("WorkloadId")]
        [Validation(Required=false)]
        public string WorkloadId { get; set; }

    }

}
